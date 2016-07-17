using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesToPdfWithDotNet.Core
{
    /// <summary>
    /// Represents methods to convert images to PDF file.
    /// </summary>
    public class ImagesToPdf
    {
        private readonly IList<string> _imagesPaths;

        /// <summary>
        /// Page size of PDF file.
        /// </summary>
        public Rectangle PageSize { get; set; }

        /// <summary>
        /// Margin of pages of PDF file.
        /// </summary>
        public float Margin { get; set; }

        /// <summary>
        /// Orientation of pages of PDF file.
        /// </summary>
        public Orientation Orientation { get; set; }

        public ImagesToPdf()
        {
            _imagesPaths = new List<string>();

            PageSize = iTextSharp.text.PageSize.A4;
            Margin = 15f;
            Orientation = Orientation.Auto;
        }

        /// <summary>
        /// Adds images from a directory.
        /// </summary>
        /// <param name="directory">Directory of images.</param>
        /// <param name="extensions">Extensions of images.</param>
        /// <param name="searchOption">Options to search.</param>
        public void AddImagesDirectory(string directory, string extensions = "*.jpg|*.png|*.bmp", SearchOption searchOption = SearchOption.TopDirectoryOnly)
        {
            var split = extensions.Split('|');

            AddImages(split.SelectMany(i => Directory.EnumerateFiles(directory, i, searchOption)));
        }

        /// <summary>
        /// Adds image from a path.
        /// </summary>
        /// <param name="imagePath">Path of image.</param>
        public void AddImage(string imagePath)
        {
            _imagesPaths.Add(imagePath);
        }

        /// <summary>
        /// Adds images from multiple paths.
        /// </summary>
        /// <param name="imagePaths">Paths of images.</param>
        public void AddImages(IEnumerable<string> imagePaths)
        {
            foreach (var imagePath in imagePaths)
            {
                AddImage(imagePath);
            }
        }

        /// <summary>
        /// Generates PDF file.
        /// </summary>
        /// <param name="pdfPath">Path of PDF file.</param>
        public void GeneratePdf(string pdfPath)
        {
            var doc = new Document();

            doc.SetMargins(Margin, Margin, Margin, Margin);

            using (var stream = new FileStream(pdfPath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter.GetInstance(doc, stream);

                doc.Open();

                foreach (var imagePath in _imagesPaths)
                {
                    using (var imageStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        var image = Image.GetInstance(imageStream);

                        #region Checks orientation

                        switch (Orientation)
                        {
                            case Orientation.Auto:
                                doc.SetPageSize(image.Width > image.Height
                                    ? PageSize.Rotate()
                                    : PageSize);
                                break;

                            case Orientation.Portrait:
                                doc.SetPageSize(PageSize);
                                break;

                            case Orientation.Landscape:
                                doc.SetPageSize(PageSize.Rotate());
                                break;

                            default:
                                throw new ArgumentOutOfRangeException();
                        }

                        #endregion Checks orientation

                        doc.NewPage();

                        #region Configures image

                        image.ScaleToFit(new Rectangle(0, 0, doc.PageSize.Width - (doc.RightMargin + doc.LeftMargin + 1), doc.PageSize.Height - (doc.BottomMargin + doc.TopMargin + 1)));
                        image.Alignment = Image.ALIGN_CENTER;

                        #endregion Configures image

                        #region Creates elements

                        var table = new PdfPTable(1)
                        {
                            WidthPercentage = 100
                        };

                        var cell = new PdfPCell
                        {
                            VerticalAlignment = Element.ALIGN_MIDDLE,
                            MinimumHeight = doc.PageSize.Height - (doc.BottomMargin + doc.TopMargin),
                            Border = 0,
                            BorderWidth = 0,
                            Padding = 0,
                            Indent = 0
                        };

                        cell.AddElement(image);

                        table.AddCell(cell);

                        #endregion Creates elements

                        doc.Add(table);
                    }
                }

                doc.Close();
            }
        }
    }
}