using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Drawing_App.Shapes
{
    [Serializable]
    public class ShapesList
    {
        public List<Shape> ShapeList { get; set; }

        [XmlIgnore]
        public Color BackgroundColor { get; set; }

        [XmlElement("BackgroundColor")]
        public string BackgroundColorString
        {
            get { return ColorTranslator.ToHtml(BackgroundColor); }
            set { BackgroundColor = ColorTranslator.FromHtml(value); }
        }

        public ShapesList()
        {
            ShapeList = new List<Shape>();
        }

        public ShapesList Clone()
        {
            var clonedList = new ShapesList { BackgroundColor = BackgroundColor };

            foreach (var shape in ShapeList)
            {
                clonedList.ShapeList.Add((Shape)shape.Clone());
            }

            return clonedList;
        }
    }
}
