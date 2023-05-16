using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Drawing_App.Shapes;
using Drawing_App.Shapes.Shapes;
using Drawing_App.Forms;

namespace Drawing_App
{
    public partial class DrawingApp : Form
    {
        public DrawingApp()
        {
            InitializeComponent();

            Width = 1172;
            Height = 751;

            bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            PictureBox.Image = bitmap;
        }


        //---------------------------------- Variables ---------------------------------
        List<Shape> shapes = new List<Shape>();
        Shape selectedShape = null;
        Graphics graphics;
        Bitmap bitmap;
        Point pointX, pointY;
        Pen pencil = new Pen(Color.Black, 5);
        Pen eraser = new Pen(Color.White, 50);
        int xOne, yOne, xTwo, yTwo, xThree, yThree = 0;
        bool isPainting = false;
        string whatToDo = string.Empty;
        ColorDialog colorDialog = new ColorDialog();
        Color newColor;
        //------------------------------------------------------------------------------


        //--------------------------------- Menu Strip ---------------------------------
        private void SaveMenu_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image(*.png)|*.png|(*.*|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bm = bitmap.Clone(new Rectangle(0, 0, PictureBox.Width, PictureBox.Height), bitmap.PixelFormat);
                bm.Save(saveFileDialog.FileName, ImageFormat.Png);

                MessageBox.Show("Image Saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //------------------------------------------------------------------------------


        //-------------------------- Preview what is drawing ---------------------------
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Pen previewPencil = new Pen(Color.Gray, 4);

            previewPencil.DashCap = System.Drawing.Drawing2D.DashCap.Round;
            previewPencil.DashPattern = new float[] { 3.3F, 1.6F, 0.8F, 2.2F };

            if (isPainting)
            {
                if (whatToDo == "line".ToLower())
                {
                    graphics.DrawLine(previewPencil, xThree, yThree, xOne, yOne);
                }
                else if (whatToDo == "circle".ToLower())
                {
                    graphics.DrawEllipse(previewPencil, xThree, yThree, xTwo, yTwo);
                }
                else if (whatToDo == "rectangle".ToLower())
                {
                    graphics.DrawRectangle(previewPencil, xThree, yThree, xTwo, yTwo);
                }
                else if (whatToDo == "triangle".ToLower())
                {
                    Point[] trianglePoints = new Point[]
                    {
                    new Point(xThree, yThree + yTwo),
                    new Point(xThree + xTwo, yThree + yTwo),
                    new Point(xThree + xTwo / 2, yThree)
                    };

                    graphics.DrawPolygon(previewPencil, trianglePoints);
                }
            }
        }
        //------------------------------------------------------------------------------

        //---------------------------------- Tools -------------------------------------
        private void Button_Clear_Click(object sender, EventArgs e)
        {
            DialogResult isCleared = MessageBox.Show("You are going to clear the drawing board and loose everything.\nDo you want to continue?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (isCleared == DialogResult.Yes)
            {
                graphics.Clear(Color.White);
                PictureBox.Image = bitmap;
                whatToDo = string.Empty;
            }
        }
        private void Button_Delete_Click(object sender, EventArgs e)
        {
            whatToDo = "delete";
        }
        private void Button_Pencil_Click(object sender, EventArgs e)
        {
            whatToDo = "pencil";
        }
        private void Button_Eraser_Click(object sender, EventArgs e)
        {
            whatToDo = "eraser";
        }
        private void Button_Fill_Click(object sender, EventArgs e)
        {
            whatToDo = "fill";
        }
        private void Button_Move_Click(object sender, EventArgs e)
        {
            whatToDo = "move";
        }
        //------------------------------------------------------------------------------


        //---------------------------------- Shapees -----------------------------------
        private void Button_Line_Click(object sender, EventArgs e)
        {
            whatToDo = "line";
        }
        private void Button_Circle_Click(object sender, EventArgs e)
        {
            whatToDo = "circle";
        }
        private void Button_Rectangle_Click(object sender, EventArgs e)
        {
            whatToDo = "rectangle";
        }
        private void Button_Triangle_Click(object sender, EventArgs e)
        {
            whatToDo = "triangle";
        }
        //------------------------------------------------------------------------------


        //---------------------------------- Colors ------------------------------------
        private void Button_Color_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            newColor = colorDialog.Color;
            SetTheNewColor(newColor);
        }

        // Redy color buttons
        private void Button_Black_Click(object sender, EventArgs e)
        {
            newColor = Button_Black.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_BlackOne_Click(object sender, EventArgs e)
        {
            newColor = Button_BlackOne.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_BlackTwo_Click(object sender, EventArgs e)
        {
            newColor = Button_BlackTwo.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_White_Click(object sender, EventArgs e)
        {
            newColor = Button_White.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_WhiteOne_Click(object sender, EventArgs e)
        {
            newColor = Button_WhiteOne.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_WhiteTwo_Click(object sender, EventArgs e)
        {
            newColor = Button_WhiteTwo.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_Orange_Click(object sender, EventArgs e)
        {
            newColor = Button_Orange.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_OrangeOne_Click(object sender, EventArgs e)
        {
            newColor = Button_OrangeOne.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_OrangeTwo_Click(object sender, EventArgs e)
        {
            newColor = Button_OrangeTwo.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_Green_Click(object sender, EventArgs e)
        {
            newColor = Button_Green.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_GreenOne_Click(object sender, EventArgs e)
        {
            newColor = Button_GreenOne.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_GreenTwo_Click(object sender, EventArgs e)
        {
            newColor = Button_GreenTwo.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_Brown_Click(object sender, EventArgs e)
        {
            newColor = Button_Brown.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_BrownOne_Click(object sender, EventArgs e)
        {
            newColor = Button_BrownOne.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_BrownTwo_Click(object sender, EventArgs e)
        {
            newColor = Button_BrownTwo.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_Red_Click(object sender, EventArgs e)
        {
            newColor = Button_Red.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_RedOne_Click(object sender, EventArgs e)
        {
            newColor = Button_RedOne.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_RedTwo_Click(object sender, EventArgs e)
        {
            newColor = Button_RedTwo.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_Yellow_Click(object sender, EventArgs e)
        {
            newColor = Button_Yellow.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_YellowOne_Click(object sender, EventArgs e)
        {
            newColor = Button_YellowOne.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_YellowTwo_Click(object sender, EventArgs e)
        {
            newColor = Button_YellowTwo.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_Purple_Click(object sender, EventArgs e)
        {
            newColor = Button_Purple.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_PurpleOne_Click(object sender, EventArgs e)
        {
            newColor = Button_PurpleOne.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_PurpleTwo_Click(object sender, EventArgs e)
        {
            newColor = Button_PurpleTwo.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_Blue_Click(object sender, EventArgs e)
        {
            newColor = Button_Blue.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_BlueOne_Click(object sender, EventArgs e)
        {
            newColor = Button_BlueOne.BackColor;
            SetTheNewColor(newColor);
        }
        private void Button_BlueTwo_Click(object sender, EventArgs e)
        {
            newColor = Button_BlueTwo.BackColor;
            SetTheNewColor(newColor);
        }
        //------------------------------------------------------------------------------


        //---------------------------------- Drawing -----------------------------------
        private void PictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Point clickPoint = SetPoint(PictureBox, e.Location);

            Shape clickedShape = shapes.FirstOrDefault(shape => shape.ContainsPoint(clickPoint));

            if (clickedShape != null)
            {
                string shapeType = clickedShape.GetType().Name;
                ShapeInformation shapeInformation = new ShapeInformation(clickedShape, shapeType);
                shapeInformation.ShowDialog();
            }
        }
        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            pointY = e.Location;
            isPainting = true;

            xThree = e.X;
            yThree = e.Y;

            // Handle shape selection
            if (whatToDo == "move")
            {
                selectedShape = shapes.FirstOrDefault(s => s.ContainsPoint(new Point(e.X, e.Y)));
            }
        }

        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (whatToDo == "fill".ToLower())
            {
                Point point = SetPoint(PictureBox, e.Location);
                FillMethod(bitmap, point.X, point.Y, newColor);
            }

            if (whatToDo == "delete".ToLower())
            {
                if (selectedShape != null)
                {
                    shapes.Remove(selectedShape);
                    graphics.Clear(Color.White);
                    foreach (var shape in shapes)
                    {
                        shape.Draw(graphics);
                    }
                    PictureBox.Refresh();
                    selectedShape = null;
                }
            }
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPainting && whatToDo == "pencil".ToLower())
            {
                pointX = e.Location;
                graphics.DrawLine(pencil, pointX, pointY);
                pointY = pointX;
            }
            else if (isPainting && whatToDo == "eraser".ToLower())
            {
                pointX = e.Location;
                graphics.DrawLine(eraser, pointX, pointY);
                pointY = pointX;
            }

            xOne = e.X;
            yOne = e.Y;
            xTwo = e.X - xThree;
            yTwo = e.Y - yThree;

            if (isPainting && whatToDo == "move" && selectedShape != null)
            {
                int deltaX = e.X - xThree;
                int deltaY = e.Y - yThree;

                selectedShape.Move(deltaX, deltaY);

                xThree = e.X;
                yThree = e.Y;

                // Redraw all shapes
                graphics.Clear(Color.White);
                foreach (var shape in shapes)
                {
                    shape.Draw(graphics);
                }
            }

            PictureBox.Refresh();
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isPainting = false;

            xTwo = xOne - xThree;
            yTwo = yOne - yThree;

            if (whatToDo == "line".ToLower())
            {
                LineShape line = new LineShape(xThree, yThree, xOne, yOne, pencil.Color, pencil.Width);
                line.Draw(graphics);
                shapes.Add(line);

                //graphics.DrawLine(pencil, xThree, yThree, xOne, yOne);
            }
            else if (whatToDo == "circle".ToLower())
            {
                EllipseShape circle = new EllipseShape(xThree, yThree, xTwo, yTwo, pencil.Color, pencil.Width);
                circle.Draw(graphics);
                shapes.Add(circle);

                //Just drawn
                //graphics.DrawEllipse(pencil, xThree, yThree, xTwo, yTwo);
            }
            else if (whatToDo == "rectangle".ToLower())
            {
                RectangleShape rectangle = new RectangleShape(xThree, yThree, xTwo, yTwo, pencil.Color, pencil.Width);
                rectangle.Draw(graphics);
                shapes.Add(rectangle);

                //Just drawn
                //graphics.DrawRectangle(pencil, xThree, yThree, xTwo, yTwo);
            }
            else if (whatToDo == "triangle".ToLower())
            {
                TriangleShape triangle = new TriangleShape(xThree, yThree, xTwo, yTwo, pencil.Color, pencil.Width);
                triangle.Draw(graphics);
                shapes.Add(triangle);

                //Point[] trianglePoints = new Point[]
                //{
                //    new Point(xThree, yThree + yTwo), // bottom left
                //    new Point(xThree + xTwo, yThree + yTwo), // bottom right
                //    new Point(xThree + xTwo / 2, yThree) // midpoint top line
                //};
                //graphics.DrawPolygon(pencil, trianglePoints);
            }

            if (whatToDo == "move")
            {
                selectedShape = null;
            }
            else
            {
                // Update shape selection on mouse up for delete operation
                Point clickPoint = new Point(e.X, e.Y);
                selectedShape = shapes.FirstOrDefault(shape => shape.ContainsPoint(clickPoint));
            }
        }
        //------------------------------------------------------------------------------


        //---------------------------------- Methods -----------------------------------
        private void SetTheNewColor(Color newColor)
        {
            pencil.Color = newColor;
            PictureBox_OutlineColor.BackColor = newColor;
        }
        static Point SetPoint(PictureBox pictureBox, Point point)
        {
            float pointX = 1f * pictureBox.Image.Width / pictureBox.Width;
            float pointY = 1f * pictureBox.Image.Height / pictureBox.Height;

            return new Point((int)(pointX * point.X), (int)(pointY * point.Y));
        }
        private void ValidatePixel(Bitmap bitMap, Stack<Point> pixel, int x, int y, Color oldColor, Color newColor)
        {
            Color currentPixel = bitMap.GetPixel(x, y);

            if (currentPixel == oldColor)
            {
                pixel.Push(new Point(x, y));
                bitMap.SetPixel(x, y, newColor);
            }
        }
        public void FillMethod(Bitmap bitMap, int x, int y, Color newColor)
        {
            Color oldColor = bitMap.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bitMap.SetPixel(x, y, newColor);

            if (oldColor == newColor)
            {
                return;
            }

            while (pixel.Count > 0)
            {
                Point point = (Point)pixel.Pop();

                if (point.X > 0 &&
                    point.Y > 0 &&
                    point.X < bitMap.Width - 1 &&
                    point.Y < bitMap.Height - 1)
                {
                    ValidatePixel(bitMap, pixel, point.X - 1, point.Y, oldColor, newColor);
                    ValidatePixel(bitMap, pixel, point.X + 1, point.Y, oldColor, newColor);
                    ValidatePixel(bitMap, pixel, point.X, point.Y - 1, oldColor, newColor);
                    ValidatePixel(bitMap, pixel, point.X, point.Y + 1, oldColor, newColor);
                }
            }
        }
        //------------------------------------------------------------------------------

    }
}