﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PBO_B08.customeToolBox
{
    public class RoundedPanel : Panel
    {
        public int BorderRadius { get; set; } = 20; // Default radius
        public Color BorderColor { get; set; } = Color.Black;
        public int BorderWidth { get; set; } = 2;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Define the rounded rectangle
            using (GraphicsPath path = GetRoundedRectPath(this.ClientRectangle, BorderRadius))
            {
                this.Region = new Region(path);

                // Draw the border
                using (Pen pen = new Pen(BorderColor, BorderWidth))
                {
                    graphics.DrawPath(pen, path);
                }
            }
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
