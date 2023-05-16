using Drawing_App.Shapes.Shapes;
using Drawing_App.Shapes;

namespace Drawing_App.Forms
{
    public partial class ShapeProperties : Form
    {
        #region Fields
        //---------------------------------- Fields ------------------------------------
        public Size MySize { get; set; }
        public Point MyLocation { get; set; }
        public Color MyOutlineColor { get; set; }
        public Color MyFillColor { get; set; }
        public Point MyStartPoint { get; set; }
        public Point MyEndPoint { get; set; }
        public float MyOutlineWidth { get; set; }
        private enum Converter
        {
            ToCantimeters,
            ToInches,
            ToPixels
        }
        private Converter _converter;
        private ColorDialog colorDialogOutline = new();
        private ColorDialog colorDialogFill = new();
        private Shape _shapeType;
        //------------------------------------------------------------------------------
        #endregion

        #region Load
        //--------------------------------- Load ---------------------------------------
        public ShapeProperties(Shape shapeType)
        {
            InitializeComponent();
            LoadIcon();

            _converter = Converter.ToCantimeters;
            _shapeType = shapeType;

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            SpecificContentPerType(_shapeType);
        }
        //------------------------------------------------------------------------------
        #endregion

        #region Content Loader
        //------------------------------ Content Loader --------------------------------
        private void SpecificContentPerType(Shape shapeType)
        {
            if (shapeType is RectangleShape rectangle)
            {
                Text = "Rectangle Shape";

                Visible();
                ContentLoader(rectangle);
            }
            else if (shapeType is TriangleShape triangle)
            {
                Text = "Triangle Shape";

                Visible();
                ContentLoader(triangle);
            }
            else if (shapeType is EllipseShape ellipse)
            {
                Text = "Ellipse Shape";

                Visible();
                ContentLoader(ellipse);
            }
            else if (shapeType is LineShape line)
            {
                Text = "Line Shape";

                Visible();
                LabelHeight.Text = "Start point X";
                LabelWidth.Text = "Start point Y";
                LabelX.Text = "End point X";
                LabelY.Text = "End point Y";
                LabelPerimeter.Text = "Length";
                LabelOutlineWidth.Text = "Line Width";
                LabelOutlineColor.Text = "Line Color";

                LabelArea.Visible = false;
                TextBoxArea.Visible = false;
                LabelFillColor.Visible = false;
                ButtonFillColor.Visible = false;

                ContentLoader(line);
            }
            else
            {
                PictureBox pictureBoxGIF = new PictureBox();

                LoadGifAndFillForm();
                Text = "Unvalid shape";
            }
        }
        //------------------------------------------------------------------------------
        #endregion

        #region Buttons
        //--------------------------------- Buttons ------------------------------------
        private void ButtonRectangleOutlineColor_Click(object sender, EventArgs e)
        {

            if (colorDialogOutline.ShowDialog() == DialogResult.OK)
            {
                ButtonOutlineColor.BackColor = colorDialogOutline.Color;
            }
        }
        private void ButtonRectangleFillColor_Click(object sender, EventArgs e)
        {
            if (colorDialogFill.ShowDialog() == DialogResult.OK)
            {
                ButtonFillColor.BackColor = colorDialogFill.Color;
            }
        }
        //------------------------------------------------------------------------------
        #endregion

        #region Default Buttons
        //------------------------------ Default Buttons -------------------------------
        private void ButtonConvert_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();

            // 120 both of my Dots per Inches
            double dpiX = g.DpiX;
            double dpiY = g.DpiY;

            // getting average for more precision of the dpi of the user is not the same for x and y
            double dpi = (dpiX + dpiY) / 2;

            if (_converter == Converter.ToCantimeters)
            {
                if (_shapeType is RectangleShape rectangle)
                {
                    TextBoxPerimeter.Text = ((rectangle.Perimeter() / dpi) * 2.54).ToString("0.00");
                    TextBoxArea.Text = ((rectangle.Area() / dpi) * 2.54).ToString("0.00");
                }
                else if (_shapeType is TriangleShape triangle)
                {
                    TextBoxPerimeter.Text = ((triangle.Perimeter() / dpi) * 2.54).ToString("0.00");
                    TextBoxArea.Text = ((triangle.Area() / dpi) * 2.54).ToString("0.00");
                }
                else if (_shapeType is EllipseShape ellipse)
                {
                    TextBoxPerimeter.Text = ((ellipse.Perimeter() / dpi) * 2.54).ToString("0.00");
                    TextBoxArea.Text = ((ellipse.Area() / dpi) * 2.54).ToString("0.00");
                }
                else if (_shapeType is LineShape line)
                {
                    TextBoxPerimeter.Text = ((line.Length() / dpi) * 2.54).ToString("0.00");
                }

                _converter = Converter.ToInches;
                ButtonConvert.Text = "To inches";
            }
            else if (_converter == Converter.ToInches)
            {
                if (_shapeType is RectangleShape rectangle)
                {
                    TextBoxPerimeter.Text = (rectangle.Perimeter() / dpi).ToString("0.00");
                    TextBoxArea.Text = (rectangle.Area() / dpi).ToString("0.00");
                }
                else if (_shapeType is TriangleShape triangle)
                {
                    TextBoxPerimeter.Text = (triangle.Perimeter() / dpi).ToString("0.00");
                    TextBoxArea.Text = (triangle.Area() / dpi).ToString("0.00");
                }
                else if (_shapeType is EllipseShape ellipse)
                {
                    TextBoxPerimeter.Text = (ellipse.Perimeter() / dpi).ToString("0.00");
                    TextBoxArea.Text = (ellipse.Area() / dpi).ToString("0.00");
                }
                else if (_shapeType is LineShape line)
                {
                    TextBoxPerimeter.Text = (line.Length() / dpi).ToString("0.00");
                }

                _converter = Converter.ToPixels;
                ButtonConvert.Text = "To pixels";
            }
            else if (_converter == Converter.ToPixels)
            {
                if (_shapeType is RectangleShape rectangle)
                {
                    TextBoxPerimeter.Text = rectangle.Perimeter().ToString("0.00");
                    TextBoxArea.Text = rectangle.Area().ToString("0.00");
                }
                else if (_shapeType is TriangleShape triangle)
                {
                    TextBoxPerimeter.Text = triangle.Perimeter().ToString("0.00");
                    TextBoxArea.Text = triangle.Area().ToString("0.00");
                }
                else if (_shapeType is EllipseShape ellipse)
                {
                    TextBoxPerimeter.Text = ellipse.Perimeter().ToString("0.00");
                    TextBoxArea.Text = ellipse.Area().ToString("0.00");
                }
                else if (_shapeType is LineShape line)
                {
                    TextBoxPerimeter.Text = line.Length().ToString("0.00");
                }

                _converter = Converter.ToCantimeters;
                ButtonConvert.Text = "To cantimeters";
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            bool inputValid = true;

            if (_shapeType is LineShape line)
            {
                if (int.TryParse(TextBoxHeight.Text, out int xStart) &&
                    int.TryParse(TextBoxWidth.Text, out int yStart) &&
                    int.TryParse(TextBoxX.Text, out int xEnd) &&
                    int.TryParse(TextBoxY.Text, out int yEnd) &&
                    int.TryParse(TextBoxOutlineWidth.Text, out int lineWidth))
                {
                    MyStartPoint = new Point(xStart, yStart);
                    MyEndPoint = new Point(xEnd, yEnd);
                    MyOutlineWidth = lineWidth;
                }
                else
                {
                    inputValid = false;

                    DialogResult notNumbers = MessageBox.Show(
                    "You must only enter numbers inside all boxes!\nDo you want to try again?",
                    "Error",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);

                    if (notNumbers == DialogResult.Retry)
                    {
                        ContentLoader(line);
                    }
                    else
                    {
                        DialogResult = DialogResult.Cancel;
                    }
                }
            }
            else
            {
                if (int.TryParse(TextBoxHeight.Text, out int height) &&
                    int.TryParse(TextBoxWidth.Text, out int width) &&
                    int.TryParse(TextBoxX.Text, out int x) &&
                    int.TryParse(TextBoxY.Text, out int y) &&
                    int.TryParse(TextBoxOutlineWidth.Text, out int outlineWidth))
                {
                    MySize = new Size(width, height);
                    MyLocation = new Point(x, y);
                    MyOutlineWidth = outlineWidth;
                }
                else
                {
                    inputValid = false;

                    DialogResult notNumbers = MessageBox.Show(
                    "You must only enter numbers inside all boxes!\nDo you want to try again?",
                    "Error",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);

                    if (notNumbers == DialogResult.Retry)
                    {
                        if (_shapeType is RectangleShape rectangle)
                        {
                            ContentLoader(rectangle);
                        }
                        else if (_shapeType is TriangleShape triangle)
                        {
                            ContentLoader(triangle);
                        }
                        else if (_shapeType is EllipseShape ellipse)
                        {
                            ContentLoader(ellipse);
                        }
                    }
                    else
                    {
                        DialogResult = DialogResult.Cancel;
                    }
                }
            }

            if (inputValid)
            {
                MyOutlineColor = ButtonOutlineColor.BackColor;
                MyFillColor = ButtonFillColor.BackColor;
                DialogResult = DialogResult.OK;
            }
        }
        //------------------------------------------------------------------------------
        #endregion

        #region Methods
        //---------------------------------- Methods -----------------------------------

        private void Visible()
        {
            LabelHeight.Visible = true;
            LabelWidth.Visible = true;
            LabelX.Visible = true;
            LabelY.Visible = true;
            TextBoxHeight.Visible = true;
            TextBoxWidth.Visible = true;
            TextBoxX.Visible = true;
            TextBoxY.Visible = true;
        }
        private void ContentLoader(RectangleShape rectangle)
        {
            TextBoxHeight.Text = rectangle.Size.Height.ToString();
            TextBoxWidth.Text = rectangle.Size.Width.ToString();
            TextBoxX.Text = rectangle.Location.X.ToString();
            TextBoxY.Text = rectangle.Location.Y.ToString();
            TextBoxOutlineWidth.Text = rectangle.OutlineWidth.ToString();
            ButtonOutlineColor.BackColor = rectangle.OutlineColor;
            ButtonFillColor.BackColor = rectangle.FillColor;
            TextBoxPerimeter.Text = rectangle.Perimeter().ToString("0.00");
            TextBoxArea.Text = rectangle.Area().ToString("0.00");
        }
        private void ContentLoader(TriangleShape triangle)
        {
            TextBoxHeight.Text = triangle.Size.Height.ToString();
            TextBoxWidth.Text = triangle.Size.Width.ToString();
            TextBoxX.Text = triangle.Location.X.ToString();
            TextBoxY.Text = triangle.Location.Y.ToString();
            TextBoxOutlineWidth.Text = triangle.OutlineWidth.ToString();
            ButtonOutlineColor.BackColor = triangle.OutlineColor;
            ButtonFillColor.BackColor = triangle.FillColor;
            TextBoxPerimeter.Text = triangle.Perimeter().ToString("0.00");
            TextBoxArea.Text = triangle.Area().ToString("0.00");
        }
        private void ContentLoader(EllipseShape ellipse)
        {
            TextBoxHeight.Text = ellipse.Size.Height.ToString();
            TextBoxWidth.Text = ellipse.Size.Width.ToString();
            TextBoxX.Text = ellipse.Location.X.ToString();
            TextBoxY.Text = ellipse.Location.Y.ToString();
            TextBoxOutlineWidth.Text = ellipse.OutlineWidth.ToString();
            ButtonOutlineColor.BackColor = ellipse.OutlineColor;
            ButtonFillColor.BackColor = ellipse.FillColor;
            TextBoxPerimeter.Text = ellipse.Perimeter().ToString("0.00");
            TextBoxArea.Text = ellipse.Area().ToString("0.00");
        }
        private void ContentLoader(LineShape line)
        {
            TextBoxHeight.Text = line.StartPoint.X.ToString();
            TextBoxWidth.Text = line.StartPoint.Y.ToString();
            TextBoxX.Text = line.EndPoint.X.ToString();
            TextBoxY.Text = line.EndPoint.Y.ToString();
            TextBoxOutlineWidth.Text = line.OutlineWidth.ToString();
            ButtonOutlineColor.BackColor = line.OutlineColor;
            TextBoxPerimeter.Text = line.Length().ToString("0.00");
        }
        private void LoadIcon()
        {
            string iconPath = Path.Combine(Application.StartupPath, "iconSettings.ico");
            var icons = new[] { iconPath }
                .Where(File.Exists)
                .Select(path => new Icon(path));

            Icon = icons.FirstOrDefault();
        }
        private void LoadGifAndFillForm()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox.Image = Properties.Resources._404;

            Controls.Add(pictureBox);
            Controls.SetChildIndex(pictureBox, 0);
        }
        //------------------------------------------------------------------------------
        #endregion
    }
}
