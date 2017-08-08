using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowPane
{
    internal static class IndependentFunctions
    {
        #region Get Char from Key Event Arg
        internal static char GetChar(KeyEventArgs e)
        {
            int keyValue = e.KeyValue;
            if (!e.Shift && keyValue >= (int)Keys.A && keyValue <= (int)Keys.Z)
                return (char)(keyValue + 32);
            return (char)keyValue;
        }
        #endregion

        #region Color Image for Tool Strip
        internal static Image FontColorImage(Color c)
        {
            Color color = c; //Your desired colour
                
            Bitmap bmp = new Bitmap(50, 50);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 35; y < bmp.Height; y++)
                {
                    if (x <= 1 || x >= bmp.Width - 5 || y <= 36 || y >= bmp.Height - 5)
                        bmp.SetPixel(x, y, Color.Black);
                    else
                        bmp.SetPixel(x, y, c);
                }
            }
            RectangleF rectf = new RectangleF(0,-5, bmp.Width,bmp.Height);

            Graphics g = Graphics.FromImage(bmp);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            StringFormat format = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            g.DrawString("A", new Font("Tahoma", 40,FontStyle.Bold), Brushes.Black, rectf,format);

            g.Flush();
            
            return (Image)bmp;
        }

        internal static Image HighlightColorImage(Color c)
        {

            Color color = c; //Your desired colour

            Bitmap bmp = new Bitmap(50, 50);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                   bmp.SetPixel(x, y, c);
                }
            }
            RectangleF rectf = new RectangleF(5, 5, bmp.Width-5, bmp.Height-5);

            Graphics g = Graphics.FromImage(bmp);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            StringFormat format = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            g.DrawString("A", new Font("Tahoma", 40, FontStyle.Bold), Brushes.Black, rectf, format);

            g.Flush();

            return (Image)bmp;
        }
        #endregion
    }
}
