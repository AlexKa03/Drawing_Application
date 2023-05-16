using System.Drawing.Drawing2D;
using System.Xml.Serialization;

namespace Drawing_App.Shapes
{
    [Serializable]
    [XmlInclude(typeof(Shapes.LineShape))]
    [XmlInclude(typeof(Shapes.RectangleShape))]
    [XmlInclude(typeof(Shapes.TriangleShape))]
    [XmlInclude(typeof(Shapes.EllipseShape))]
    public abstract class Shape : ICloneable
    {
        public virtual Size Size { get; set; }
        public Point Location { get; set; }
        [XmlIgnore]
        public Color OutlineColor { get; set; }

        [XmlElement("OutlineColor")]
        public string OutlineColorString
        {
            get { return ColorTranslator.ToHtml(OutlineColor); }
            set { OutlineColor = ColorTranslator.FromHtml(value); }
        }

        [XmlIgnore]
        public Color FillColor { get; set; }
        [XmlElement("FillColor")]
        public string FillColorString
        {
            get { return ColorTranslator.ToHtml(FillColor); }
            set { FillColor = ColorTranslator.FromHtml(value); }
        }
        public float OutlineWidth { get; set; }
        public virtual GraphicsPath GetPath()
        { 
            return new GraphicsPath(); 
        }
        public virtual void Draw(Graphics g, Pen pen) { }
        public virtual void Fill(Graphics g, Brush brush) { }
        public virtual bool Contains(Point point)
        {
            return false;
        }
        public abstract object Clone();
        public virtual double Perimeter() { return 0; }
        public virtual double Area() { return 0; }
    }
}
