namespace JSact
{
    partial class Form1
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
            this.fbdFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.grpUpdateSet = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGetJS = new System.Windows.Forms.Button();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lbxFileList = new System.Windows.Forms.ListBox();
            this.lblUSPath = new System.Windows.Forms.Label();
            this.txtUSPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.grpUpdateSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUpdateSet
            // 
            this.grpUpdateSet.Controls.Add(this.btnExit);
            this.grpUpdateSet.Controls.Add(this.btnGetJS);
            this.grpUpdateSet.Controls.Add(this.lblFiles);
            this.grpUpdateSet.Controls.Add(this.lbxFileList);
            this.grpUpdateSet.Controls.Add(this.lblUSPath);
            this.grpUpdateSet.Controls.Add(this.txtUSPath);
            this.grpUpdateSet.Controls.Add(this.btnBrowse);
            this.grpUpdateSet.Location = new System.Drawing.Point(7, 12);
            this.grpUpdateSet.Name = "grpUpdateSet";
            this.grpUpdateSet.Size = new System.Drawing.Size(472, 222);
            this.grpUpdateSet.TabIndex = 5;
            this.grpUpdateSet.TabStop = false;
            this.grpUpdateSet.UseWaitCursor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(368, 181);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.UseWaitCursor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGetJS
            // 
            this.btnGetJS.Location = new System.Drawing.Point(107, 181);
            this.btnGetJS.Name = "btnGetJS";
            this.btnGetJS.Size = new System.Drawing.Size(75, 23);
            this.btnGetJS.TabIndex = 10;
            this.btnGetJS.Text = "Get &JS";
            this.btnGetJS.UseVisualStyleBackColor = true;
            this.btnGetJS.UseWaitCursor = true;
            this.btnGetJS.Click += new System.EventHandler(this.btnGetJS_Click);
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(73, 57);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(28, 13);
            this.lblFiles.TabIndex = 9;
            this.lblFiles.Text = "Files";
            this.lblFiles.UseWaitCursor = true;
            // 
            // lbxFileList
            // 
            this.lbxFileList.FormattingEnabled = true;
            this.lbxFileList.Location = new System.Drawing.Point(107, 57);
            this.lbxFileList.Name = "lbxFileList";
            this.lbxFileList.Size = new System.Drawing.Size(331, 95);
            this.lbxFileList.TabIndex = 8;
            this.lbxFileList.UseWaitCursor = true;
            // 
            // lblUSPath
            // 
            this.lblUSPath.AutoSize = true;
            this.lblUSPath.Location = new System.Drawing.Point(5, 17);
            this.lblUSPath.Name = "lblUSPath";
            this.lblUSPath.Size = new System.Drawing.Size(97, 13);
            this.lblUSPath.TabIndex = 7;
            this.lblUSPath.Text = "Update Set(s) Path";
            this.lblUSPath.UseWaitCursor = true;
            // 
            // txtUSPath
            // 
            this.txtUSPath.Location = new System.Drawing.Point(107, 14);
            this.txtUSPath.Name = "txtUSPath";
            this.txtUSPath.Size = new System.Drawing.Size(331, 20);
            this.txtUSPath.TabIndex = 6;
            this.txtUSPath.UseWaitCursor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(440, 13);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(25, 23);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.UseWaitCursor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(488, 243);
            this.Controls.Add(this.grpUpdateSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Script Extract Utility";
            this.grpUpdateSet.ResumeLayout(false);
            this.grpUpdateSet.PerformLayout();
            this.ResumeLayout(false);
            this.AcceptButton = this.btnGetJS;

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdFolderBrowser;
        private System.Windows.Forms.GroupBox grpUpdateSet;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGetJS;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.ListBox lbxFileList;
        private System.Windows.Forms.Label lblUSPath;
        private System.Windows.Forms.TextBox txtUSPath;
        private System.Windows.Forms.Button btnBrowse;
    }
}

