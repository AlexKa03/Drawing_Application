using System.Drawing.Drawing2D;

namespace Drawing_App.Shapes.Shapes
{
    [Serializable]
    public class RectangleShape : Shape
    {
        public override GraphicsPath GetPath()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new Rectangle(Location, Size));
            return path;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            using (pen = new Pen(OutlineColor, OutlineWidth))
            {
                g.DrawRectangle(pen, new Rectangle(Location, Size));
            }
        }

        public override void Fill(Graphics g, Brush brush)
        {
            g.FillRectangle(brush, new Rectangle(Location, Size));
        }

        public override bool Contains(Point point)
        {
            return new Rectangle(Location, Size).Contains(point);
        }
        public override object Clone()
        {
            return new RectangleShape
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
            return (Size.Height + Size.Width) * 2;
        }

        public override double Area()
        {
            return Size.Height * Size.Width;
        }
    }
}
