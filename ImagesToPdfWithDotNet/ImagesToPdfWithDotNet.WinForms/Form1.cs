using ImagesToPdfWithDotNet.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImagesToPdfWithDotNet.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchImagesPathButton_Click(object sender, EventArgs e)
        {
            if (imagesFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                imagesFolderTextBox.Text = imagesFolderBrowserDialog.SelectedPath;
            }
        }

        private void savePdfFileButton_Click(object sender, EventArgs e)
        {
            if (savePdfFileDialog.ShowDialog() == DialogResult.OK)
            {
                pdfFileTextBox.Text = savePdfFileDialog.FileName;
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(imagesFolderBrowserDialog.SelectedPath))
            {
                MessageBox.Show("Choose folder of images!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(pdfFileTextBox.Text))
            {
                MessageBox.Show("Select PDF file!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var imagesToPdf = new ImagesToPdf();

                imagesToPdf.AddImagesDirectory(imagesFolderBrowserDialog.SelectedPath);

                imagesToPdf.GeneratePdf(savePdfFileDialog.FileName);

                MessageBox.Show("PDF file successfully generated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}