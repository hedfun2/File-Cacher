namespace File_Cacher
{
    partial class FileCacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Cache = new System.Windows.Forms.Button();
            this.textBox_ToBeCached = new System.Windows.Forms.TextBox();
            this.label_ToBeCached = new System.Windows.Forms.Label();
            this.button_Browse = new System.Windows.Forms.Button();
            this.radioButton_Folder = new System.Windows.Forms.RadioButton();
            this.radioButton_File = new System.Windows.Forms.RadioButton();
            this.bw_Cache = new System.ComponentModel.BackgroundWorker();
            this.label_InfoFilesQueued = new System.Windows.Forms.Label();
            this.label_FilesQueued = new System.Windows.Forms.Label();
            this.progressBar_Single = new System.Windows.Forms.ProgressBar();
            this.label_InfoFreeMemory = new System.Windows.Forms.Label();
            this.label_FreeMemory = new System.Windows.Forms.Label();
            this.label_InfoFileSize = new System.Windows.Forms.Label();
            this.label_FileSize = new System.Windows.Forms.Label();
            this.bw_FreeMemory = new System.ComponentModel.BackgroundWorker();
            this.progressBar_Total = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button_Cache
            // 
            this.button_Cache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.button_Cache.FlatAppearance.BorderSize = 0;
            this.button_Cache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cache.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cache.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.button_Cache.Location = new System.Drawing.Point(410, 41);
            this.button_Cache.Margin = new System.Windows.Forms.Padding(0);
            this.button_Cache.Name = "button_Cache";
            this.button_Cache.Size = new System.Drawing.Size(75, 23);
            this.button_Cache.TabIndex = 0;
            this.button_Cache.Text = "Cache";
            this.button_Cache.UseVisualStyleBackColor = false;
            this.button_Cache.Click += new System.EventHandler(this.button_Cache_Click);
            // 
            // textBox_ToBeCached
            // 
            this.textBox_ToBeCached.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.textBox_ToBeCached.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ToBeCached.Enabled = false;
            this.textBox_ToBeCached.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.textBox_ToBeCached.Location = new System.Drawing.Point(128, 16);
            this.textBox_ToBeCached.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_ToBeCached.Name = "textBox_ToBeCached";
            this.textBox_ToBeCached.Size = new System.Drawing.Size(273, 20);
            this.textBox_ToBeCached.TabIndex = 2;
            // 
            // label_ToBeCached
            // 
            this.label_ToBeCached.AutoSize = true;
            this.label_ToBeCached.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label_ToBeCached.Location = new System.Drawing.Point(13, 18);
            this.label_ToBeCached.Name = "label_ToBeCached";
            this.label_ToBeCached.Size = new System.Drawing.Size(112, 13);
            this.label_ToBeCached.TabIndex = 3;
            this.label_ToBeCached.Text = "Folder / File to Cache:";
            // 
            // button_Browse
            // 
            this.button_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.button_Browse.FlatAppearance.BorderSize = 0;
            this.button_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Browse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.button_Browse.Location = new System.Drawing.Point(410, 13);
            this.button_Browse.Margin = new System.Windows.Forms.Padding(0);
            this.button_Browse.Name = "button_Browse";
            this.button_Browse.Size = new System.Drawing.Size(75, 23);
            this.button_Browse.TabIndex = 4;
            this.button_Browse.Text = "Browse";
            this.button_Browse.UseVisualStyleBackColor = false;
            this.button_Browse.Click += new System.EventHandler(this.button_Browse_Click);
            // 
            // radioButton_Folder
            // 
            this.radioButton_Folder.AutoSize = true;
            this.radioButton_Folder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.radioButton_Folder.Checked = true;
            this.radioButton_Folder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.radioButton_Folder.Location = new System.Drawing.Point(16, 46);
            this.radioButton_Folder.Name = "radioButton_Folder";
            this.radioButton_Folder.Size = new System.Drawing.Size(54, 17);
            this.radioButton_Folder.TabIndex = 5;
            this.radioButton_Folder.TabStop = true;
            this.radioButton_Folder.Text = "Folder";
            this.radioButton_Folder.UseVisualStyleBackColor = false;
            // 
            // radioButton_File
            // 
            this.radioButton_File.AutoSize = true;
            this.radioButton_File.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.radioButton_File.Location = new System.Drawing.Point(76, 46);
            this.radioButton_File.Name = "radioButton_File";
            this.radioButton_File.Size = new System.Drawing.Size(41, 17);
            this.radioButton_File.TabIndex = 6;
            this.radioButton_File.TabStop = true;
            this.radioButton_File.Text = "File";
            this.radioButton_File.UseVisualStyleBackColor = true;
            // 
            // bw_Cache
            // 
            this.bw_Cache.WorkerReportsProgress = true;
            this.bw_Cache.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_Cache_DoWork);
            this.bw_Cache.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_Cache_ProgressChanged);
            this.bw_Cache.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_Cache_RunWorkerCompleted);
            // 
            // label_InfoFilesQueued
            // 
            this.label_InfoFilesQueued.AutoSize = true;
            this.label_InfoFilesQueued.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label_InfoFilesQueued.Location = new System.Drawing.Point(13, 76);
            this.label_InfoFilesQueued.Name = "label_InfoFilesQueued";
            this.label_InfoFilesQueued.Size = new System.Drawing.Size(72, 13);
            this.label_InfoFilesQueued.TabIndex = 8;
            this.label_InfoFilesQueued.Text = "Files Queued:";
            // 
            // label_FilesQueued
            // 
            this.label_FilesQueued.AutoSize = true;
            this.label_FilesQueued.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label_FilesQueued.Location = new System.Drawing.Point(88, 76);
            this.label_FilesQueued.Name = "label_FilesQueued";
            this.label_FilesQueued.Size = new System.Drawing.Size(13, 13);
            this.label_FilesQueued.TabIndex = 9;
            this.label_FilesQueued.Text = "0";
            this.label_FilesQueued.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar_Single
            // 
            this.progressBar_Single.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.progressBar_Single.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.progressBar_Single.Location = new System.Drawing.Point(12, 167);
            this.progressBar_Single.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar_Single.Name = "progressBar_Single";
            this.progressBar_Single.Size = new System.Drawing.Size(473, 23);
            this.progressBar_Single.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_Single.TabIndex = 10;
            // 
            // label_InfoFreeMemory
            // 
            this.label_InfoFreeMemory.AutoSize = true;
            this.label_InfoFreeMemory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label_InfoFreeMemory.Location = new System.Drawing.Point(13, 99);
            this.label_InfoFreeMemory.Name = "label_InfoFreeMemory";
            this.label_InfoFreeMemory.Size = new System.Drawing.Size(71, 13);
            this.label_InfoFreeMemory.TabIndex = 11;
            this.label_InfoFreeMemory.Text = "Free Memory:";
            // 
            // label_FreeMemory
            // 
            this.label_FreeMemory.AutoSize = true;
            this.label_FreeMemory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label_FreeMemory.Location = new System.Drawing.Point(88, 99);
            this.label_FreeMemory.Name = "label_FreeMemory";
            this.label_FreeMemory.Size = new System.Drawing.Size(32, 13);
            this.label_FreeMemory.TabIndex = 12;
            this.label_FreeMemory.Text = "0 MB";
            // 
            // label_InfoFileSize
            // 
            this.label_InfoFileSize.AutoSize = true;
            this.label_InfoFileSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label_InfoFileSize.Location = new System.Drawing.Point(13, 122);
            this.label_InfoFileSize.Name = "label_InfoFileSize";
            this.label_InfoFileSize.Size = new System.Drawing.Size(95, 13);
            this.label_InfoFileSize.TabIndex = 13;
            this.label_InfoFileSize.Text = "Queued Files Size:";
            // 
            // label_FileSize
            // 
            this.label_FileSize.AutoSize = true;
            this.label_FileSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label_FileSize.Location = new System.Drawing.Point(114, 122);
            this.label_FileSize.Name = "label_FileSize";
            this.label_FileSize.Size = new System.Drawing.Size(32, 13);
            this.label_FileSize.TabIndex = 14;
            this.label_FileSize.Text = "0 MB";
            // 
            // bw_FreeMemory
            // 
            this.bw_FreeMemory.WorkerReportsProgress = true;
            this.bw_FreeMemory.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_FreeMemory_DoWork);
            this.bw_FreeMemory.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_FreeMemory_ProgressChanged);
            this.bw_FreeMemory.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_FreeMemory_RunWorkerCompleted);
            // 
            // progressBar_Total
            // 
            this.progressBar_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(64)))));
            this.progressBar_Total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
            this.progressBar_Total.Location = new System.Drawing.Point(12, 138);
            this.progressBar_Total.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar_Total.Name = "progressBar_Total";
            this.progressBar_Total.Size = new System.Drawing.Size(473, 23);
            this.progressBar_Total.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_Total.TabIndex = 7;
            // 
            // FileCacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(497, 199);
            this.Controls.Add(this.label_FileSize);
            this.Controls.Add(this.label_InfoFileSize);
            this.Controls.Add(this.label_FreeMemory);
            this.Controls.Add(this.label_InfoFreeMemory);
            this.Controls.Add(this.progressBar_Single);
            this.Controls.Add(this.label_FilesQueued);
            this.Controls.Add(this.label_InfoFilesQueued);
            this.Controls.Add(this.progressBar_Total);
            this.Controls.Add(this.radioButton_File);
            this.Controls.Add(this.radioButton_Folder);
            this.Controls.Add(this.button_Browse);
            this.Controls.Add(this.label_ToBeCached);
            this.Controls.Add(this.textBox_ToBeCached);
            this.Controls.Add(this.button_Cache);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FileCacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cache;
        private System.Windows.Forms.TextBox textBox_ToBeCached;
        private System.Windows.Forms.Label label_ToBeCached;
        private System.Windows.Forms.Button button_Browse;
        private System.Windows.Forms.RadioButton radioButton_Folder;
        private System.Windows.Forms.RadioButton radioButton_File;
        private System.ComponentModel.BackgroundWorker bw_Cache;
        private System.Windows.Forms.ProgressBar progressBar_Total;
        private System.Windows.Forms.Label label_InfoFilesQueued;
        private System.Windows.Forms.Label label_FilesQueued;
        private System.Windows.Forms.ProgressBar progressBar_Single;
        private System.Windows.Forms.Label label_InfoFreeMemory;
        private System.Windows.Forms.Label label_FreeMemory;
        private System.Windows.Forms.Label label_InfoFileSize;
        private System.Windows.Forms.Label label_FileSize;
        private System.ComponentModel.BackgroundWorker bw_FreeMemory;
    }
}

