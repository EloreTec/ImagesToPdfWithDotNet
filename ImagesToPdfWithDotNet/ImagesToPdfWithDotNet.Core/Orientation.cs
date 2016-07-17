using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesToPdfWithDotNet.Core
{
    /// <summary>
    /// Represents the orientation of pages of PDF file.
    /// </summary>
    public enum Orientation
    {
        /// <summary>
        /// It indicates that the orientation is defined by the orientation of the image.
        /// </summary>
        Auto,

        /// <summary>
        /// It indicates that the orientation is set to portrait.
        /// </summary>
        Portrait,

        /// <summary>
        /// It indicates that the orientation is set to lanscape.
        /// </summary>
        Landscape
    }
}