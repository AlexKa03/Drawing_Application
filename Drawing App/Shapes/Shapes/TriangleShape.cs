using System.Drawing.Drawing2D;

namespace Drawing_App.Shapes.Shapes
{
    [Serializable]
    public class TriangleShape : Shape
    {
        public override GraphicsPath GetPath()
        {
            GraphicsPath path = new GraphicsPath();
            Point[] points = GetTrianglePoints();
            path.AddPolygon(points);

            return path;
        }
        public Size Size { get; set; }

        public override void Draw(Graphics g, Pen pen)
        {
            Point[] trianglePoints = GetTrianglePoints();

            using (pen = new Pen(OutlineColor, OutlineWidth))
            {
                g.DrawPolygon(pen, trianglePoints);
            }
        }
        public override void Fill(Graphics g, Brush brush)
        {
            Point[] points = GetTrianglePoints();

            g.FillPolygon(brush, points);
        }

        public override bool Contains(Point point)
        {
            Point a = Location;
            Point b = new Point(Location.X + Size.Width, Location.Y);
            Point c = new Point(Location.X + Size.Width / 2, Location.Y + Size.Height);

            double denom = (b.Y - c.Y) * (a.X - c.X) + (c.X - b.X) * (a.Y - c.Y);
            double alpha = ((b.Y - c.Y) * (point.X - c.X) + (c.X - b.X) * (point.Y - c.Y)) / denom;
            double beta = ((c.Y - a.Y) * (point.X - c.X) + (a.X - c.X) * (point.Y - c.Y)) / denom;
            double gamma = 1.0 - alpha - beta;

            return alpha >= 0 && alpha <= 1 && beta >= 0 && beta <= 1 && gamma >= 0 && gamma <= 1;
        }
        public override object Clone()
        {
            return new TriangleShape
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
            double baseLength = Size.Width;
            double height = Size.Height;
            double halfBase = baseLength / 2;
            double hypotenuse = Math.Sqrt(Math.Pow(halfBase, 2) + Math.Pow(height, 2));

            return baseLength + 2 * hypotenuse;
        }

        public override double Area()
        {
            double height = Size.Height;
            double width = Size.Width;

            return (height * width) / 2;
        }

        private Point[] GetTrianglePoints()
        {
            // LINQ HERE

            return new[]
            {
                new { X = Location.X + Size.Width / 2, Y = Location.Y },
                new { X = Location.X, Y = Location.Y + Size.Height },
                new { X = Location.X + Size.Width, Y = Location.Y + Size.Height }
            }
            .Select(p => new Point(p.X, p.Y))
            .ToArray();
        }
    }
}
