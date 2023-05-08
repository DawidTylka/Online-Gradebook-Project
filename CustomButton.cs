using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Windows.Forms;

namespace Tylka
{
    public class CustomButton : Button
    {
        //Fields
        private int borderSize = 0;
        private int borderRadius = 50;
        private Color BordColor;
        private Color ColTop;
        private Color ColBott;

        //Properties
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; Invalidate(); }
        }
        
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = (value <= Height) ? value : Height; Invalidate(); }
        }
        /*public Color BackgroundColor
        {
            get => BackColor;
            set { BackColor = value; }
        }*/
        public Color TextColor
        {
            get => ForeColor;
            set { ForeColor = value; }
        }
        public Color borderColor
        {
            get => BordColor;
            set { BordColor = value; }
        }
        public Color ColorTop 
        {
            get => ColTop;
            set { ColTop = value; }
        }
        public Color ColorBottom 
        {
            get => ColBott;
            set { ColBott = value; }
        }

        // Constructor
        public CustomButton()
        {
            Color color1 = Color.FromArgb(255, 160, 114, 190);
            Color color2 = Color.FromArgb(255, 190, 129, 182);
            Color color3 = Color.FromArgb(255, 93, 89, 175);
            Size = new Size(200, 100);
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            BackColor = color1;
            ForeColor = Color.White;
            BordColor = color3;
            ColTop = color1;
            ColBott = color2;
            Resize += new EventHandler(Button_Resize);
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > Height) borderRadius = Height;
        }

        //Methods

        private GraphicsPath GetFigurePath(RectangleF rectangle, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            path.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            path.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //Sizes
            RectangleF rectangleSurface = new RectangleF(0, 0, Width, Height);
            RectangleF rectangleBorder = new RectangleF(1, 1, Width - 1, Height - 1);
            RectangleF drawtext = new RectangleF(0, Height / 2 - Font.Size, Width, Height);
            
            //Gradient
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 90F);
            base.OnPaint(e);
            e.Graphics.FillPath(lgb, this.GetFigurePath(rectangleSurface, borderRadius));
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (borderRadius > 1)
            {
                
                using (GraphicsPath graphicsPathSurface = GetFigurePath(rectangleSurface, borderRadius))
                using (GraphicsPath graphicsPathBorder = GetFigurePath(rectangleBorder, borderRadius - 1F))
                using (Pen penBorder = new Pen(BordColor, borderSize))
                {

                    
                    penBorder.Alignment = PenAlignment.Inset;
                    Region = new Region(graphicsPathSurface);
                    e.Graphics.DrawPath(penBorder, graphicsPathSurface);

                    //Draw text
                    StringFormat drawFormat = new StringFormat();
                    drawFormat.Alignment = StringAlignment.Center;
                    e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.TextColor), drawtext, drawFormat);

                    if (borderSize >= 1)
                        e.Graphics.DrawPath((Pen)penBorder, graphicsPathBorder);

                    
                }
            }
            else
            {
                Region = new Region(rectangleSurface);

                if (borderSize >= 1)
                    using (Pen penBorder = new Pen(BordColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            NewMethod();
        }

        private void NewMethod()
        {
            Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (DesignMode) Invalidate();
        }
    }
}
