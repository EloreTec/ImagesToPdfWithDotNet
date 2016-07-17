namespace ImagesToPdfWithDotNet.WinForms
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
            this.generateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imagesFolderTextBox = new System.Windows.Forms.TextBox();
            this.searchImagesPathButton = new System.Windows.Forms.Button();
            this.savePdfFileButton = new System.Windows.Forms.Button();
            this.pdfFileTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imagesFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.savePdfFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generateButton.Location = new System.Drawing.Point(106, 64);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(426, 23);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Images Folder";
            // 
            // imagesFolderTextBox
            // 
            this.imagesFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagesFolderTextBox.Enabled = false;
            this.imagesFolderTextBox.Location = new System.Drawing.Point(106, 12);
            this.imagesFolderTextBox.Name = "imagesFolderTextBox";
            this.imagesFolderTextBox.Size = new System.Drawing.Size(426, 20);
            this.imagesFolderTextBox.TabIndex = 0;
            // 
            // searchImagesPathButton
            // 
            this.searchImagesPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchImagesPathButton.Location = new System.Drawing.Point(538, 10);
            this.searchImagesPathButton.Name = "searchImagesPathButton";
            this.searchImagesPathButton.Size = new System.Drawing.Size(36, 23);
            this.searchImagesPathButton.TabIndex = 3;
            this.searchImagesPathButton.Text = "...";
            this.searchImagesPathButton.UseVisualStyleBackColor = true;
            this.searchImagesPathButton.Click += new System.EventHandler(this.searchImagesPathButton_Click);
            // 
            // savePdfFileButton
            // 
            this.savePdfFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.savePdfFileButton.Location = new System.Drawing.Point(538, 36);
            this.savePdfFileButton.Name = "savePdfFileButton";
            this.savePdfFileButton.Size = new System.Drawing.Size(36, 23);
            this.savePdfFileButton.TabIndex = 4;
            this.savePdfFileButton.Text = "...";
            this.savePdfFileButton.UseVisualStyleBackColor = true;
            this.savePdfFileButton.Click += new System.EventHandler(this.savePdfFileButton_Click);
            // 
            // pdfFileTextBox
            // 
            this.pdfFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfFileTextBox.Enabled = false;
            this.pdfFileTextBox.Location = new System.Drawing.Point(106, 38);
            this.pdfFileTextBox.Name = "pdfFileTextBox";
            this.pdfFileTextBox.Size = new System.Drawing.Size(426, 20);
            this.pdfFileTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PDF File";
            // 
            // imagesFolderBrowserDialog
            // 
            this.imagesFolderBrowserDialog.Description = "Choose folder of images";
            // 
            // savePdfFileDialog
            // 
            this.savePdfFileDialog.Filter = "PDF File (.pdf)|*.pdf";
            this.savePdfFileDialog.RestoreDirectory = true;
            this.savePdfFileDialog.Title = "Choose path and name of PDF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 98);
            this.Controls.Add(this.savePdfFileButton);
            this.Controls.Add(this.pdfFileTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchImagesPathButton);
            this.Controls.Add(this.imagesFolderTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Images to PDF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imagesFolderTextBox;
        private System.Windows.Forms.Button searchImagesPathButton;
        private System.Windows.Forms.Button savePdfFileButton;
        private System.Windows.Forms.TextBox pdfFileTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog imagesFolderBrowserDialog;
        private System.Windows.Forms.SaveFileDialog savePdfFileDialog;
    }
}

