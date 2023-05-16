using System.Drawing.Drawing2D;

namespace Drawing_App.Shapes.Shapes
{
    public class LineShape : Shape
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public override void Draw(Graphics g, Pen pen)
        {
            using (pen = new Pen(OutlineColor, OutlineWidth))
            {
                g.DrawLine(pen, StartPoint, EndPoint);
            }
        }

        public override bool Contains(Point point)
        {
            return IsPointOnLine(point, OutlineWidth - (OutlineWidth * 0.60));
        }
        public bool IsPointOnLine(Point point, double tolerance)
        {
            float distance = PointToLineDistance(point, StartPoint, EndPoint);

            if (distance <= tolerance)
            {
                // Check if the point is within the bounds of the start and end points
                int minX = Math.Min(StartPoint.X, EndPoint.X) - (int)Math.Floor(tolerance);
                int maxX = Math.Max(StartPoint.X, EndPoint.X) + (int)Math.Floor(tolerance);
                int minY = Math.Min(StartPoint.Y, EndPoint.Y) - (int)Math.Floor(tolerance);
                int maxY = Math.Max(StartPoint.Y, EndPoint.Y) + (int)Math.Floor(tolerance);

                bool withinBounds = point.X >= minX && point.X <= maxX && point.Y >= minY && point.Y <= maxY;

                // Check if the point is close enough to the StartPoint or EndPoint
                bool nearStart = Math.Sqrt(Math.Pow(point.X - StartPoint.X, 2) + Math.Pow(point.Y - StartPoint.Y, 2)) <= tolerance;
                bool nearEnd = Math.Sqrt(Math.Pow(point.X - EndPoint.X, 2) + Math.Pow(point.Y - EndPoint.Y, 2)) <= tolerance;

                return withinBounds || nearStart || nearEnd;
                //return point.X >= minX && point.X <= maxX && point.Y >= minY && point.Y <= maxY;
            }

            return false;
        }
        private static float PointToLineDistance(Point p, Point a, Point b)
        {
            float num = Math.Abs((b.Y - a.Y) * p.X - (b.X - a.X) * p.Y + b.X * a.Y - b.Y * a.X);
            float den = (float)Math.Sqrt(Math.Pow(b.Y - a.Y, 2) + Math.Pow(b.X - a.X, 2));
            return num / den;
        }

        public override GraphicsPath GetPath()
        {
            return new GraphicsPath(); // Return an empty GraphicsPath
        }

        public double Length()
        {
            double deltaX = EndPoint.X - StartPoint.X;
            double deltaY = EndPoint.Y - StartPoint.Y;

            return Math.Sqrt((deltaY * deltaY) + (deltaX * deltaX)) ;
        }

        public override object Clone()
        {
            return new LineShape
            {
                StartPoint = StartPoint,
                EndPoint = EndPoint,
                OutlineColor = OutlineColor,
                OutlineWidth = OutlineWidth,
            };
        }
    }
}
