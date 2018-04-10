namespace DCSLCopyDirectoryApp
{
    partial class CopyFacility
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
            this.SourceFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.DestinationFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.SourceFolderPath = new System.Windows.Forms.TextBox();
            this.DestinationFolderPath = new System.Windows.Forms.TextBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SourceDirectoryBtn = new System.Windows.Forms.Button();
            this.DestinationDirectoryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SourceFolder
            // 
            this.SourceFolder.HelpRequest += new System.EventHandler(this.SourceFolder_HelpRequest);
            // 
            // SourceFolderPath
            // 
            this.SourceFolderPath.Location = new System.Drawing.Point(74, 53);
            this.SourceFolderPath.Name = "SourceFolderPath";
            this.SourceFolderPath.Size = new System.Drawing.Size(386, 20);
            this.SourceFolderPath.TabIndex = 0;
            // 
            // DestinationFolderPath
            // 
            this.DestinationFolderPath.Location = new System.Drawing.Point(74, 107);
            this.DestinationFolderPath.Name = "DestinationFolderPath";
            this.DestinationFolderPath.Size = new System.Drawing.Size(386, 20);
            this.DestinationFolderPath.TabIndex = 1;
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(74, 164);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(142, 23);
            this.CopyButton.TabIndex = 2;
            this.CopyButton.Text = "Start Copying";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(74, 222);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(386, 23);
            this.progressBar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Two Pop-uUs for Source and Destination Folders will show subsquently. Please pick" +
    " Source and Destination Folders for the Copy!";
            // 
            // SourceDirectoryBtn
            // 
            this.SourceDirectoryBtn.Location = new System.Drawing.Point(495, 49);
            this.SourceDirectoryBtn.Name = "SourceDirectoryBtn";
            this.SourceDirectoryBtn.Size = new System.Drawing.Size(193, 23);
            this.SourceDirectoryBtn.TabIndex = 5;
            this.SourceDirectoryBtn.Text = "Choose Source Directory";
            this.SourceDirectoryBtn.UseVisualStyleBackColor = true;
            this.SourceDirectoryBtn.Click += new System.EventHandler(this.SourceDirectoryBtn_Click);
            // 
            // DestinationDirectoryBtn
            // 
            this.DestinationDirectoryBtn.Location = new System.Drawing.Point(495, 104);
            this.DestinationDirectoryBtn.Name = "DestinationDirectoryBtn";
            this.DestinationDirectoryBtn.Size = new System.Drawing.Size(193, 23);
            this.DestinationDirectoryBtn.TabIndex = 6;
            this.DestinationDirectoryBtn.Text = "Choose Destination Directory";
            this.DestinationDirectoryBtn.UseVisualStyleBackColor = true;
            this.DestinationDirectoryBtn.Click += new System.EventHandler(this.DestinationDirectoryBtn_Click);
            // 
            // CopyFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 326);
            this.Controls.Add(this.DestinationDirectoryBtn);
            this.Controls.Add(this.SourceDirectoryBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.DestinationFolderPath);
            this.Controls.Add(this.SourceFolderPath);
            this.Name = "CopyFacility";
            this.Text = "Folder Copying Facility";
            this.Load += new System.EventHandler(this.CopyFacility_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog SourceFolder;
        private System.Windows.Forms.FolderBrowserDialog DestinationFolder;
        private System.Windows.Forms.TextBox SourceFolderPath;
        private System.Windows.Forms.TextBox DestinationFolderPath;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SourceDirectoryBtn;
        private System.Windows.Forms.Button DestinationDirectoryBtn;
    }
}

