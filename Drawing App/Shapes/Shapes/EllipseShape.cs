using System.Drawing.Drawing2D;

namespace Drawing_App.Shapes.Shapes
{
    [Serializable]
    public class EllipseShape : Shape
    {
        public override GraphicsPath GetPath()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(new Rectangle(Location, Size));
            return path;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            using (pen = new Pen(OutlineColor, OutlineWidth))
            {
                g.DrawEllipse(pen, new Rectangle(Location, Size));
            }
        }

        public override void Fill(Graphics g, Brush brush)
        {
            g.FillEllipse(brush, new Rectangle(Location, Size));
        }

        public override bool Contains(Point point)
        {
            PointF center = new PointF(Location.X + Size.Width / 2f, Location.Y + Size.Height / 2f);
            double a = Size.Width / 2;
            double b = Size.Height / 2;
            double xDistance = Math.Pow(point.X - center.X, 2);
            double yDistance = Math.Pow(point.Y - center.Y, 2);
            return xDistance / (a * a) + yDistance / (b * b) <= 1;
        }
        public override object Clone()
        {
            return new EllipseShape
            {
                Location = Location,
                Size = Size,
                OutlineColor = OutlineColor,
                OutlineWidth = OutlineWidth,
                FillColor = FillColor
            };
        }

        public override double Perimeter()
        {
            // Srinivasa Ramanujan formula
            double a = Size.Width / 2;
            double b = Size.Height / 2;

            return Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b)));
        }

        public override double Area()
        {
            double a = Size.Width / 2;
            double b = Size.Height / 2;

            return Math.PI * a * b;
        }
    }
}
