using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.Devices;

namespace File_Cacher
{
    /// <summary>
    /// Stores Files / Folders into cached RAM
    /// </summary>
    public partial class FileCacher : Form
    {

        private String[] files;
        private ulong freeMemory;
        private long allFilesSize;

        public FileCacher()
        {
            InitializeComponent();
            bw_FreeMemory.RunWorkerAsync();
        }

        private void button_Browse_Click(object sender, EventArgs e)
        {
            //If File selected
            if (radioButton_File.Checked)
                chooseFiles();
            //If Folder selected
            else if (radioButton_Folder.Checked)
                chooseFolders();
            //If no files selected then stop here
            if (files == null || files.Length == 0)
                return;

            //Updates Files Queued to amount of files in the files array
            label_FilesQueued.Text = files.Length.ToString();
            allFilesSize = 0; //Resets the total files size
            foreach (String file in files) //Goes through all files and adds length to allFilesSize
                allFilesSize += new FileInfo(file).Length;
            label_FileSize.Text = addComma(allFilesSize / 1024 / 1024) + " MB"; //Udpates file size in MB
        }

        /// <summary>
        /// Adds commas to a number
        /// </summary>
        /// <param name="number">The number to have commas added to</param>
        /// <returns>The number with commas</returns>
        private String addComma(long number)
        {
            return number.ToString("N0");
        }

        /// <summary>
        /// Prompts the user to select files and stores them into the files array
        /// </summary>
        private void chooseFiles()
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.Filter = "All Files (*.*)|*.*";
            fileChooser.Multiselect = true;
            if (fileChooser.ShowDialog() == DialogResult.OK) //Shows File Dialog
            {
                //If user clicks OK, resets files and adds the selected files to it
                files = null;
                files = fileChooser.FileNames;
            }
        }

        /// <summary>
        /// Prompts the user to select a folder and stores the files in that folder
        /// into the files array
        /// </summary>
        private void chooseFolders()
        {
            FolderBrowserDialog folderChooser = new FolderBrowserDialog(); //Shows folder browser
            String folderPath = "";
            if (folderChooser.ShowDialog() == DialogResult.OK)
            {
                // If user clicked OK, resets files and saves the folder path
                files = null;
                folderPath = folderChooser.SelectedPath;
            }

            // If the user did select a folder, than add the files in the folder
            // to the files array and updates the textbox
            if (folderPath != "")
            {
                files = GetFiles(folderPath).ToArray();
                textBox_ToBeCached.Text = folderPath;
            }
        }

        /// <summary>
        /// Gets all the files and subfiles in the specified directory
        /// ignoring files that are unable to be accessed
        /// </summary>
        /// <param name="directory">The directory to get files and subfiles from</param>
        /// <returns>All the files' paths in an array</returns>
        private String[] GetFiles(String directory)
        {
            SafeFileEnumerator fileEnum = new SafeFileEnumerator(directory, "*.*");
            return fileEnum.ToArray();
        }

        /// <summary>
        /// Determines whether the path given is a file or directory
        /// </summary>
        /// <param name="path">The path to be analyzed</param>
        /// <returns>true if path is a directory, false if not</returns>
        private Boolean isDirectory(String path)
        {
            FileAttributes attr = File.GetAttributes(path);

            if (attr.HasFlag(FileAttributes.Directory))
                return true;
            else
                return false;
        }

        private void button_Cache_Click(object sender, EventArgs e)
        {
            // If no files selected then stop here
            if (files == null || files.Length == 0)
            {
                MessageBox.Show("No files selected");
                return;
            }

            // If selected files is larger than free memory, promt the user what to do
            if ((ulong)allFilesSize > freeMemory)
            {
                DialogResult result = MessageBox.Show("You do not have enough free memory to store all the files into the cache. Continue?", "Not Enough Memory", MessageBoxButtons.AbortRetryIgnore);
                if (result == DialogResult.Abort) //Stop if user clicks abort
                    return;
                else if (result == DialogResult.Retry)// Simulate clicking cache again is user clicks retry
                {
                    button_Cache_Click(sender, e);
                }
                else if (result == DialogResult.Ignore)// Run anyway if ignored
                {
                    disableComponents();
                    bw_Cache.RunWorkerAsync();
                }
            }
            else// If there is enough memory, continue
            {
                disableComponents();
                bw_Cache.RunWorkerAsync();
            }
        }

        /// <summary>
        /// Disables clickable components
        /// </summary>
        private void disableComponents()
        {
            radioButton_File.Enabled = false;
            radioButton_Folder.Enabled = false;
            button_Browse.Enabled = false;
            button_Cache.Enabled = false;
        }

        /// <summary>
        /// Enables clickable components
        /// </summary>
        private void enableComponents()
        {
            radioButton_File.Enabled = true;
            radioButton_Folder.Enabled = true;
            button_Browse.Enabled = true;
            button_Cache.Enabled = true;
        }

        private void bw_Cache_DoWork(object sender, DoWorkEventArgs e)
        {
            int previousPercentage = 0;
            long allBytesRead = 0;

            using (MemoryStream ms = new MemoryStream())// Opens a memorystream to write the files to
            {
                foreach (String file in files)// Cycles through all the files
                {
                    using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))// Opens the file in read mode
                    {
                        byte[] buffer = new byte[1024000];// Buffer to write the file to
                        int bytesRead;
                        long totalBytesRead = 0;
                        long fileSize = fs.Length;
                        bool reading = true;
                        int previousSinglePercent = 0;
                        while (reading && (bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)// Reads 1MB of the file and stores into buffer
                        {
                            ms.Write(buffer, 0, bytesRead);// Writes the buffer into the memorystream
                            ms.Position = 0;// Sets the memorystream position to 0 in order to overwrite the data in there
                            totalBytesRead += bytesRead;
                            allBytesRead += bytesRead;
                            if (totalBytesRead >= fileSize)// If read whole file, do not loop again
                                reading = false;
                            // If reading the single file is 1% further than before, update the progress bar
                            if ((int)(((double)totalBytesRead / (double)fileSize) * 100) > previousSinglePercent)
                            {
                                previousSinglePercent = (int)(((double)totalBytesRead / (double)fileSize) * 100);// Single file
                                previousPercentage = (int)(((double)allBytesRead / (double)allFilesSize) * 100);// All files
                                bw_Cache.ReportProgress(0, new BWData(previousSinglePercent, previousPercentage));// Report progress
                            }
                        }
                    }
                }
            }
        }

        private void bw_Cache_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Update both progress bars
            progressBar_Total.Value = ((BWData)e.UserState).total;
            progressBar_Single.Value = ((BWData)e.UserState).single;
        }

        private void bw_FreeMemory_DoWork(object sender, DoWorkEventArgs e)
        {
            ComputerInfo info = new ComputerInfo();

            while (true)// Every 3sec gets free memory and reports it in MB
            {
                freeMemory = info.AvailablePhysicalMemory;
                bw_FreeMemory.ReportProgress((int)(freeMemory / 1024 / 1024));
                new System.Threading.ManualResetEvent(false).WaitOne(3000);
            }

        }

        private void bw_FreeMemory_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Updates the free memory label
            label_FreeMemory.Text = addComma(e.ProgressPercentage) + " MB";
        }

        private void bw_Cache_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            enableComponents();
            bw_Cache.Dispose();
        }

        private void bw_FreeMemory_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bw_FreeMemory.Dispose();
        }

        /// <summary>
        /// Struct that stores values for single file and total file percentages
        /// </summary>
        private struct BWData
        {
            public int single;
            public int total;

            public BWData(int single, int total)
            {
                this.single = single;
                this.total = total;
            }
        }
    }
}
