using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace PBO_B08.customeToolBox
{
    public class RoundedButton : Button
    {
        public int BorderRadius { get; set; } = 20; // Default radius
        public Color BorderColor { get; set; } = Color.Black;
        public int BorderWidth { get; set; } = 2;

        // Property to control image alignment
        private ContentAlignment imageAlignment = ContentAlignment.MiddleLeft;
        [Category("Appearance")]
        [Description("Sets the alignment of the image on the button.")]
        public ContentAlignment ImageAlignment
        {
            get => imageAlignment;
            set
            {
                imageAlignment = value;
                this.Invalidate(); // Redraw the button when the property changes
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = this.ClientRectangle;
            rect.Inflate(-BorderWidth, -BorderWidth);

            // Draw the button background
            using (GraphicsPath path = GetRoundedRectPath(rect, BorderRadius))
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                graphics.FillPath(brush, path);
                this.Region = new Region(path);
            }

            // Draw the border
            using (GraphicsPath path = GetRoundedRectPath(rect, BorderRadius))
            using (Pen pen = new Pen(BorderColor, BorderWidth))
            {
                graphics.DrawPath(pen, path);
            }

            // Draw the image (if any)
            if (this.Image != null)
            {
                // Calculate the image position based on ImageAlignment
                Point imagePosition = GetImagePosition(rect, this.Image.Size, ImageAlignment);

                graphics.DrawImage(this.Image, new Rectangle(imagePosition, this.Image.Size));
            }

            // Draw the text independently
            TextRenderer.DrawText(
                graphics,
                this.Text,
                this.Font,
                rect,
                this.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter // Adjust this if needed
            );
        }

        private Point GetImagePosition(Rectangle rect, Size imageSize, ContentAlignment alignment)
        {
            int x = rect.X;
            int y = rect.Y;

            switch (alignment)
            {
                case ContentAlignment.TopLeft:
                    x = rect.X;
                    y = rect.Y;
                    break;
                case ContentAlignment.TopCenter:
                    x = rect.X + (rect.Width - imageSize.Width) / 2;
                    y = rect.Y;
                    break;
                case ContentAlignment.TopRight:
                    x = rect.Right - imageSize.Width;
                    y = rect.Y;
                    break;
                case ContentAlignment.MiddleLeft:
                    x = rect.X;
                    y = rect.Y + (rect.Height - imageSize.Height) / 2;
                    break;
                case ContentAlignment.MiddleCenter:
                    x = rect.X + (rect.Width - imageSize.Width) / 2;
                    y = rect.Y + (rect.Height - imageSize.Height) / 2;
                    break;
                case ContentAlignment.MiddleRight:
                    x = rect.Right - imageSize.Width;
                    y = rect.Y + (rect.Height - imageSize.Height) / 2;
                    break;
                case ContentAlignment.BottomLeft:
                    x = rect.X;
                    y = rect.Bottom - imageSize.Height;
                    break;
                case ContentAlignment.BottomCenter:
                    x = rect.X + (rect.Width - imageSize.Width) / 2;
                    y = rect.Bottom - imageSize.Height;
                    break;
                case ContentAlignment.BottomRight:
                    x = rect.Right - imageSize.Width;
                    y = rect.Bottom - imageSize.Height;
                    break;
            }

            return new Point(x, y);
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }
    }

}
