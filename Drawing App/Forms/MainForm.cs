using Drawing_App.Shapes;
using Drawing_App.Shapes.Shapes;
using Drawing_App.Forms;
using System.Drawing.Drawing2D;
using System.Xml.Serialization;
using System.Text;

namespace Drawing_App
{
    public partial class DrawingApp : Form
    {
        #region Fields
        //---------------------------------- Fields ------------------------------------

        //Undo and Redo buttons
        private Stack<ShapesList> _undoStack = new Stack<ShapesList>();
        private Stack<ShapesList> _redoStack = new Stack<ShapesList>();

        // Colors
        private Color _newColor;
        private ColorDialog colorDialog = new();

        //Drawing
        private enum DrawingMode
        {
            None,
            DrawRectangle,
            DrawTriangle,
            DrawEllipse,
            DrawLine,
            Move,
            Fill,
            Delete,
            Clear
        }
        private DrawingMode _drawingMode;
        private Point _mouseDownPoint;
        private Point _currentMouseLocation;
        private bool _isDrawing;
        private Bitmap _bitmap;
        private Shape _selectedShape;
        private ShapesList _shapes = new ShapesList();

        //Pen
        private Pen _pen = new(Color.Black, 5);

        //Active Figure
        private Button lastPressedButton = null;

        //------------------------------------------------------------------------------
        #endregion

        #region Load
        //--------------------------------- Load ---------------------------------------
        public DrawingApp()
        {
            InitializeComponent();
            LoadIcon();
            InitializeBitmap();

            PictureBox.Invalidated += PictureBox_Invalidated;
            PictureBox.Image = new Bitmap(Width, Height);
            TextBox_Width.Text = _pen.Width.ToString();
        }
        private void InitializeBitmap()
        {
            _bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            PictureBox.Image = _bitmap;
        }
        //------------------------------------------------------------------------------
        #endregion

        #region Menu Strip
        //--------------------------------- Menu Strip ---------------------------------
        private void SaveMenu_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog.DefaultExt = "xml";
            saveFileDialog.FileName = "New Drawing";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _shapes.BackgroundColor = PictureBox.BackColor;
                XmlSerializer serializer = new XmlSerializer(typeof(ShapesList));
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    serializer.Serialize(writer, _shapes);
                }

                MessageBox.Show("File Saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void OpenMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ShapesList));
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    _shapes = (ShapesList)serializer.Deserialize(reader);
                    PictureBox.BackColor = _shapes.BackgroundColor;
                    PictureBox.Invalidate();
                }

                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Loaded {_shapes.ShapeList.Count} shapes:");
                int counter = 1;
                foreach (var shape in _shapes.ShapeList)
                {
                    if (shape.GetType().Name == "EllipseShape")
                    {
                        sb.AppendLine($"{counter}. Ellipse");
                    }
                    else if (shape.GetType().Name == "LineShape")
                    {
                        sb.AppendLine($"{counter}. Line");
                    }
                    else if (shape.GetType().Name == "RectangleShape")
                    {
                        sb.AppendLine($"{counter}. Rectangle");
                    }
                    else if (shape.GetType().Name == "TriangleShape")
                    {
                        sb.AppendLine($"{counter}. Triangle");
                    }

                    counter++;
                }

                MessageBox.Show(sb.ToString(), "Shapes Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _undoStack = new Stack<ShapesList>();
                _redoStack = new Stack<ShapesList>();

                PictureBox.Refresh();
            }
        }
        private void UndoMenu_Click(object sender, EventArgs e)
        {
            if (_undoStack.Count > 0)
            {
                var currentState = new ShapesList { ShapeList = new List<Shape>(_shapes.ShapeList), BackgroundColor = PictureBox.BackColor };
                _redoStack.Push(currentState.Clone());
                var prevState = _undoStack.Pop();
                _shapes.ShapeList = new List<Shape>(prevState.ShapeList);
                PictureBox.BackColor = currentState.BackgroundColor;
                PictureBox.Invalidate();

                SetAllButtonInactive();
            }
        }
        private void RedoMenu_Click(object sender, EventArgs e)
        {
            if (_redoStack.Count > 0)
            {
                SaveStateForUndo();
                var nextState = _redoStack.Pop();
                _shapes.ShapeList = new List<Shape>(nextState.ShapeList);
                PictureBox.BackColor = nextState.BackgroundColor;
                PictureBox.Invalidate();

                SetAllButtonInactive();
            }
        }

        private void HelpMenu_Click(object sender, EventArgs e)
        {
            HelpForm shapeInformtion = new HelpForm();
            shapeInformtion.StartPosition = FormStartPosition.CenterScreen;
            shapeInformtion.Show();
        }
        //------------------------------------------------------------------------------
        #endregion

        #region Drawing
        //---------------------------------- Drawing -----------------------------------
        private void PictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Shape clickedShape = FindShapeAtPoint(e.Location);

            if (clickedShape != null)
            {
                using (ShapeProperties shapeInformtion = new ShapeProperties(clickedShape))
                {
                    if (clickedShape is RectangleShape rectangle)
                    {
                        shapeInformtion.MySize = rectangle.Size;
                        shapeInformtion.MyLocation = rectangle.Location;
                        shapeInformtion.MyOutlineWidth = rectangle.OutlineWidth;
                        shapeInformtion.MyOutlineColor = rectangle.OutlineColor;
                        shapeInformtion.MyFillColor = rectangle.FillColor;

                        if (shapeInformtion.ShowDialog() == DialogResult.OK)
                        {
                            SaveStateForUndo();
                            rectangle.Size = shapeInformtion.MySize;
                            rectangle.Location = shapeInformtion.MyLocation;
                            rectangle.OutlineColor = shapeInformtion.MyOutlineColor;
                            rectangle.OutlineWidth = shapeInformtion.MyOutlineWidth;
                            rectangle.FillColor = shapeInformtion.MyFillColor;
                        }
                    }
                    else if (clickedShape is TriangleShape triangle)
                    {
                        shapeInformtion.MySize = triangle.Size;
                        shapeInformtion.MyLocation = triangle.Location;
                        shapeInformtion.MyOutlineWidth = triangle.OutlineWidth;
                        shapeInformtion.MyOutlineColor = triangle.OutlineColor;
                        shapeInformtion.MyFillColor = triangle.FillColor;

                        if (shapeInformtion.ShowDialog() == DialogResult.OK)
                        {
                            SaveStateForUndo();
                            triangle.Size = shapeInformtion.MySize;
                            triangle.Location = shapeInformtion.MyLocation;
                            triangle.OutlineColor = shapeInformtion.MyOutlineColor;
                            triangle.OutlineWidth = shapeInformtion.MyOutlineWidth;
                            triangle.FillColor = shapeInformtion.MyFillColor;
                        }
                    }
                    else if (clickedShape is EllipseShape ellipse)
                    {
                        shapeInformtion.MySize = ellipse.Size;
                        shapeInformtion.MyLocation = ellipse.Location;
                        shapeInformtion.MyOutlineWidth = ellipse.OutlineWidth;
                        shapeInformtion.MyOutlineColor = ellipse.OutlineColor;
                        shapeInformtion.MyFillColor = ellipse.FillColor;

                        if (shapeInformtion.ShowDialog() == DialogResult.OK)
                        {
                            SaveStateForUndo();
                            ellipse.Size = shapeInformtion.MySize;
                            ellipse.Location = shapeInformtion.MyLocation;
                            ellipse.OutlineColor = shapeInformtion.MyOutlineColor;
                            ellipse.OutlineWidth = shapeInformtion.MyOutlineWidth;
                            ellipse.FillColor = shapeInformtion.MyFillColor;
                        }
                    }
                    else if (clickedShape is LineShape line)
                    {
                        shapeInformtion.MyStartPoint = line.StartPoint;
                        shapeInformtion.MyEndPoint = line.EndPoint;
                        shapeInformtion.MyOutlineColor = line.OutlineColor;
                        shapeInformtion.MyOutlineWidth = line.OutlineWidth;

                        if (shapeInformtion.ShowDialog() == DialogResult.OK)
                        {
                            SaveStateForUndo();
                            line.StartPoint = shapeInformtion.MyStartPoint;
                            line.EndPoint = shapeInformtion.MyEndPoint;
                            line.OutlineColor = shapeInformtion.MyOutlineColor;
                            line.OutlineWidth = shapeInformtion.MyOutlineWidth;
                        }
                    }

                    PictureBox.Refresh();
                }
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDrawing = false;

                if (_selectedShape != null && _drawingMode == DrawingMode.Move)
                {
                    _selectedShape = null;
                }
                else
                {
                    int width = Math.Abs(e.Location.X - _mouseDownPoint.X);
                    int height = Math.Abs(e.Location.Y - _mouseDownPoint.Y);
                    int x = Math.Min(_mouseDownPoint.X, PictureBox.PointToClient(Cursor.Position).X);
                    int y = Math.Min(_mouseDownPoint.Y, PictureBox.PointToClient(Cursor.Position).Y);

                    Shape shape = null;

                    switch (_drawingMode)
                    {
                        case DrawingMode.DrawLine:
                            shape = new LineShape { StartPoint = _mouseDownPoint, EndPoint = e.Location, OutlineColor = _pen.Color, OutlineWidth = _pen.Width };
                            PictureBox.Invalidate();
                            break;

                        case DrawingMode.DrawRectangle:
                            shape = new RectangleShape { Location = new Point(x, y), Size = new Size(width, height), OutlineColor = _pen.Color, FillColor = PictureBox.BackColor, OutlineWidth = _pen.Width };
                            break;

                        case DrawingMode.DrawTriangle:
                            shape = new TriangleShape { Location = new Point(x, y), Size = new Size(width, height), OutlineColor = _pen.Color, FillColor = PictureBox.BackColor, OutlineWidth = _pen.Width };
                            break;

                        case DrawingMode.DrawEllipse:
                            shape = new EllipseShape { Location = new Point(x, y), Size = new Size(width, height), OutlineColor = _pen.Color, FillColor = PictureBox.BackColor, OutlineWidth = _pen.Width };
                            break;
                    }

                    if (shape != null)
                    {
                        SaveStateForUndo();

                        _shapes.ShapeList.Add(shape);
                        PictureBox.Invalidate();
                    }
                }

                if (_drawingMode == DrawingMode.Fill)
                {
                    Shape shape = FindShapeAtPoint(e.Location);

                    if (shape != null)
                    {
                        SaveStateForUndo();

                        if (shape is LineShape)
                        {
                            shape.OutlineColor = _pen.Color;
                        }
                        else if (IsPointOnOutline(e.Location, shape))
                        {
                            shape.OutlineColor = _pen.Color;
                        }
                        else
                        {
                            shape.FillColor = _pen.Color;
                        }
                    }
                    else
                    {
                        PictureBox.BackColor = _pen.Color;
                    }

                    PictureBox.Invalidate();
                }
            }
        }
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Smoothing(e);

            foreach (Shape shape in _shapes.ShapeList)
            {
                using (Pen pen = new Pen(shape.OutlineColor, shape.OutlineWidth))
                using (Brush brush = new SolidBrush(shape.FillColor))
                {
                    shape.Fill(e.Graphics, brush);
                    shape.Draw(e.Graphics, pen);
                }
            }

            if (_isDrawing || (_selectedShape != null && _drawingMode == DrawingMode.Move))
            {
                int width = Math.Abs(PictureBox.PointToClient(Cursor.Position).X - _mouseDownPoint.X);
                int height = Math.Abs(PictureBox.PointToClient(Cursor.Position).Y - _mouseDownPoint.Y);
                int x = Math.Min(_mouseDownPoint.X, PictureBox.PointToClient(Cursor.Position).X);
                int y = Math.Min(_mouseDownPoint.Y, PictureBox.PointToClient(Cursor.Position).Y);

                Shape previewShape = null;

                switch (_drawingMode)
                {
                    case DrawingMode.DrawLine:
                        e.Graphics.DrawLine(_pen, _mouseDownPoint, _currentMouseLocation);
                        break;

                    case DrawingMode.DrawRectangle:
                        previewShape = new RectangleShape { Location = new Point(x, y), Size = new Size(width, height), OutlineColor = _pen.Color, OutlineWidth = _pen.Width };
                        break;

                    case DrawingMode.DrawTriangle:
                        previewShape = new TriangleShape { Location = new Point(x, y), Size = new Size(width, height), OutlineColor = _pen.Color, OutlineWidth = _pen.Width };
                        break;

                    case DrawingMode.DrawEllipse:
                        previewShape = new EllipseShape { Location = new Point(x, y), Size = new Size(width, height), OutlineColor = _pen.Color, OutlineWidth = _pen.Width };
                        break;

                    case DrawingMode.Move:
                        if (_selectedShape != null)
                        {
                            int deltaX = PictureBox.PointToClient(Cursor.Position).X - _mouseDownPoint.X;
                            int deltaY = PictureBox.PointToClient(Cursor.Position).Y - _mouseDownPoint.Y;
                            Point originalLocation = _selectedShape.Location;
                            _selectedShape.Location = new Point(_selectedShape.Location.X + deltaX, _selectedShape.Location.Y + deltaY);
                            previewShape = _selectedShape;
                            _selectedShape.Location = originalLocation;
                        }
                        break;
                }

                if (previewShape != null)
                {
                    previewShape.Draw(e.Graphics, _pen);
                }
            }
        }
        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseDownPoint = e.Location;

                if (_drawingMode == DrawingMode.Delete)
                {
                    Shape shapeToDelete = FindShapeAtPoint(e.Location);
                    if (shapeToDelete != null)
                    {
                        SaveStateForUndo();
                        _shapes.ShapeList.Remove(shapeToDelete);
                        PictureBox.Invalidate();
                    }
                }
                else if (_drawingMode == DrawingMode.Move)
                {
                    SaveStateForUndo();
                    //LINQ HERE
                    _selectedShape = _shapes.ShapeList
                        .LastOrDefault(shape => shape.Contains(e.Location));
                }
                else
                {
                    _isDrawing = true;
                }
            }
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            _currentMouseLocation = e.Location;

            if (e.Button == MouseButtons.Left)
            {
                if (_isDrawing)
                {
                    PictureBox.Invalidate();
                }
                else if (_selectedShape != null && _drawingMode == DrawingMode.Move)
                {
                    int deltaX = e.Location.X - _mouseDownPoint.X;
                    int deltaY = e.Location.Y - _mouseDownPoint.Y;               

                    if (_selectedShape is LineShape line)
                    {
                        line.StartPoint = new Point(line.StartPoint.X + deltaX, line.StartPoint.Y + deltaY);
                        line.EndPoint = new Point(line.EndPoint.X + deltaX, line.EndPoint.Y + deltaY);
                    }
                    else
                    {
                        _selectedShape.Location = new Point(_selectedShape.Location.X + deltaX, _selectedShape.Location.Y + deltaY);
                    }

                    _mouseDownPoint = e.Location;
                    PictureBox.Invalidate();
                }
            }
        }
        //------------------------------------------------------------------------------
        #endregion

        #region Tools
        //---------------------------------- Tools -------------------------------------
        private void Button_Clear_Click(object sender, EventArgs e)
        {
            SetButtonActive(Button_Clear);
            _drawingMode = DrawingMode.Clear;

            DialogResult isCleared = MessageBox.Show(
                "You are going to clear the drawing board and loose everything.\nDo you want to continue?",
                "Clearing Drawing Board",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if (isCleared == DialogResult.Yes)
            {
                _undoStack = new Stack<ShapesList>();
                _redoStack = new Stack<ShapesList>();

                _shapes.ShapeList.Clear();
                PictureBox.BackColor = Color.White;

                Refresh();
                UpdateUndoRedoButtonStates();
            }

            Button_Clear.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.Delete;
            SetButtonActive(Button_Delete);
        }
        private void Button_Fill_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.Fill;
            SetButtonActive(Button_Fill);
        }
        private void Button_Move_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.Move;
            SetButtonActive(Button_Move);
        }
        private void Button_Pointer_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            _drawingMode = DrawingMode.None;
            SetButtonActive(Button_Pointer);
        }
        //------------------------------------------------------------------------------
        #endregion

        #region Shapes
        //---------------------------------- Shapees -----------------------------------
        private void Button_Line_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.DrawLine;
            SetButtonActive(Button_Line);
        }
        private void Button_Circle_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.DrawEllipse;
            SetButtonActive(Button_Circle);
        }
        private void Button_Rectangle_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.DrawRectangle;
            SetButtonActive(Button_Rectangle);
        }
        private void Button_Triangle_Click(object sender, EventArgs e)
        {
            _drawingMode = DrawingMode.DrawTriangle;
            SetButtonActive(Button_Triangle);
        }
        //------------------------------------------------------------------------------
        #endregion

        #region Colors
        //-------------------------------- Colors --------------------------------------
        private void Button_Color_Click(object sender, EventArgs e)
        {
            if (lastPressedButton != null)
            {
                SetAllButtonInactive();
            }

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _newColor = colorDialog.Color;
                _pen.Color = _newColor;
                PictureBox_OutlineColor.BackColor = _newColor;

                //SetButtonActive(Button_Color);
                //Button_Color.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            }

            //Button_Color.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
        }
        private void Button_Colored_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            _newColor = clickedButton.BackColor;
            _pen.Color = _newColor;
            PictureBox_OutlineColor.BackColor = _newColor;
        }
        //------------------------------------------------------------------------------
        #endregion

        #region Appearance
        //------------------------------- Appearance -----------------------------------
        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (_drawingMode == DrawingMode.DrawLine ||
                _drawingMode == DrawingMode.DrawEllipse ||
                _drawingMode == DrawingMode.DrawRectangle ||
                _drawingMode == DrawingMode.DrawTriangle)
            {
                Cursor = Cursors.Cross;
            }
            else if (_drawingMode == DrawingMode.Move)
            {
                Cursor = Cursors.SizeAll;
            }
            else if (_drawingMode == DrawingMode.Clear)
            {
                Cursor = Cursors.Default;
            }
        }
        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void HelpMenu_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Help;
        }
        private void HelpMenu_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void TextBox_Width_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox_Width.Text) &&
                int.TryParse(TextBox_Width.Text, out int width))
            {
                _pen.Width = width;

                if (_pen.Width == null)
                {
                    TextBox_Width.Text = "1";
                    _pen.Width = 1;
                }
            }
        }

        private void PictureBox_Invalidated(object sender, InvalidateEventArgs e)
        {
            UpdateUndoRedoButtonStates();
        }
        private void UpdateUndoRedoButtonStates()
        {
            UndoMenu.Enabled = _undoStack.Count > 0;
            RedoMenu.Enabled = _redoStack.Count > 0;
        }
        //------------------------------------------------------------------------------
        #endregion

        #region Methods
        //---------------------------------- Methods -----------------------------------
        private void SaveStateForUndo()
        {
            var currentState = new ShapesList { ShapeList = new List<Shape>(_shapes.ShapeList), BackgroundColor = PictureBox.BackColor };
            _undoStack.Push(currentState.Clone());
        }
        private void Smoothing(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System
                        .Drawing
                        .Drawing2D
                        .SmoothingMode
                        .AntiAlias;
        }
        private Shape FindShapeAtPoint(Point point)
        {
            for (int i = _shapes.ShapeList.Count - 1; i >= 0; i--)
            {
                if (_shapes.ShapeList[i].Contains(point))
                {
                    return _shapes.ShapeList[i];
                }
            }

            return null;
        }
        private bool IsPointOnOutline(Point point, Shape shape)
        {
            using (GraphicsPath path = shape.GetPath())
            {
                // Check if the point is on the path (outline)
                float tolerance = shape.OutlineWidth;

                if (path.IsOutlineVisible(point, new Pen(shape.OutlineColor, shape.OutlineWidth + tolerance)))
                {
                    return true;
                }
            }
            return false;
        }
        private void SetButtonActive(Button button)
        {
            if (lastPressedButton != null)
            {
                lastPressedButton.FlatAppearance.BorderSize = 0;
            }
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = Color.Black;

            lastPressedButton = button;
        }
        private void SetAllButtonInactive()
        {
            lastPressedButton.FlatAppearance.BorderSize = 0;
        }

        private void LoadIcon()
        {

            string iconPath = Path.Combine(Application.StartupPath, "icon.ico");

            //LINQ HERE
            var icons = new[] { iconPath }
               .Where(File.Exists)
               .Select(path => new Icon(path));
            Icon = icons.FirstOrDefault();
        }
        //------------------------------------------------------------------------------
        #endregion
    }
}