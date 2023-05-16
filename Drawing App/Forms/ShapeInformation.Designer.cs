using Drawing_App.Shapes;
using Drawing_App.Shapes.Shapes;

namespace Drawing_App.Forms
{
    public partial class ShapeInformation : Form
    {
        private Shape _shape;
        private string _shapeType;

        public ShapeInformation(Shape shape, string shapeType)
        {
            InitializeComponent();

            _shape = shape;
            _shapeType = shapeType;

            Label_One.Text = _shapeType;

            CreateLabelsBasedOnShapeType(_shapeType);

            CreateLabelsBasedOnShapeType(_shapeType);
        }

        private void CreateLabelsBasedOnShapeType(string shapeType)
        {
            Label label = new Label();
            label.AutoSize = true;

            switch (shapeType)
            {
                case nameof(LineShape):
                    label.Text = "This is a line.";
                    break;
                case nameof(EllipseShape):
                    label.Text = "This is an ellipse.";
                    break;
                case nameof(RectangleShape):
                    label.Text = "This is a rectangle.";
                    break;
                case nameof(TriangleShape):
                    label.Text = "This is a triangle.";
                    break;
                default:
                    label.Text = "Unknown shape.";
                    break;
            }

            label.Location = new Point(10, 50);
            this.Controls.Add(label);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label_One = new Label();
            SuspendLayout();
            // 
            // Label_One
            // 
            Label_One.AutoSize = true;
            Label_One.Location = new Point(12, 9);
            Label_One.Name = "Label_One";
            Label_One.Size = new Size(50, 20);
            Label_One.TabIndex = 0;
            Label_One.Text = "label1";
            // 
            // ShapeInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Label_One);
            Name = "ShapeInformation";
            Text = "Shape Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_One;
    }
}