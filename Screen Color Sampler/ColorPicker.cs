using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Screen_Color_Sampler
{
    internal class ColorPicker
    {
        /// <summary>
        /// Bitmap for storing the pixel color.
        /// </summary>
        private readonly Bitmap screenPixel = new(1, 1, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        /// <summary>
        /// Sample the pixel under the cursor and return it's color.
        /// </summary>
        /// <returns>Color of the pixel under the cursor.</returns>
        public Color TimerTick()
        {
            Point cursor = new();
            _ = GetCursorPos(ref cursor);

            return GetColorAt(cursor);
        }

        private Color GetColorAt(Point Location)
        {
            using Graphics gdest = Graphics.FromImage(screenPixel);
            using Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero);

            IntPtr hSrcDC = gsrc.GetHdc();
            IntPtr hDC = gdest.GetHdc();
            int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, Location.X, Location.Y, (int)CopyPixelOperation.SourceCopy);
            gdest.ReleaseHdc();
            gsrc.ReleaseHdc();

            return screenPixel.GetPixel(0, 0);
        }
    }
}
