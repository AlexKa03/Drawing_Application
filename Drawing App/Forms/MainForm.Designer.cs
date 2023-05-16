namespace Drawing_App
{
    partial class DrawingApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingApp));
            MenuStrip = new MenuStrip();
            FileMenu = new ToolStripMenuItem();
            SaveMenu = new ToolStripMenuItem();
            OpenMenu = new ToolStripMenuItem();
            ToolMenu = new ToolStripMenuItem();
            ColorPickerMenu = new ToolStripMenuItem();
            FillBucketMenu = new ToolStripMenuItem();
            DeleteMenu = new ToolStripMenuItem();
            MoveMenu = new ToolStripMenuItem();
            PointerMenu = new ToolStripMenuItem();
            ClearMenu = new ToolStripMenuItem();
            ShapesMenu = new ToolStripMenuItem();
            LineMenu = new ToolStripMenuItem();
            CircleMenu = new ToolStripMenuItem();
            RectangleMenu = new ToolStripMenuItem();
            TriangleMenu = new ToolStripMenuItem();
            HelpMenu = new ToolStripMenuItem();
            UndoMenu = new ToolStripMenuItem();
            RedoMenu = new ToolStripMenuItem();
            Panel = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            Button_Pointer = new Button();
            panel4 = new Panel();
            TextBox_Width = new TextBox();
            Label_Width = new Label();
            Button_Move = new Button();
            Button_Clear = new Button();
            Label_Colors = new Label();
            Label_Shapes = new Label();
            Label_Tools = new Label();
            Button_Delete = new Button();
            panel2 = new Panel();
            ShapesScrollMenu = new FlowLayoutPanel();
            Button_Line = new Button();
            Button_Circle = new Button();
            Button_Rectangle = new Button();
            Button_Triangle = new Button();
            panel1 = new Panel();
            Button_PurpleTwo = new Button();
            Button_PurpleOne = new Button();
            Button_BlueTwo = new Button();
            Button_BlueOne = new Button();
            Button_YellowTwo = new Button();
            Button_YellowOne = new Button();
            Button_Blue = new Button();
            Button_Purple = new Button();
            Button_Yellow = new Button();
            Button_RedTwo = new Button();
            Button_RedOne = new Button();
            Button_Red = new Button();
            Button_BrownTwo = new Button();
            Button_GreenTwo = new Button();
            Button_BrownOne = new Button();
            Button_GreenOne = new Button();
            Button_OrangeTwo = new Button();
            Button_WhiteTwo = new Button();
            Button_WhiteOne = new Button();
            Button_BlackTwo = new Button();
            Button_BlackOne = new Button();
            Button_OrangeOne = new Button();
            Button_Brown = new Button();
            Button_Green = new Button();
            Button_Orange = new Button();
            Button_White = new Button();
            Button_Black = new Button();
            Button_Fill = new Button();
            Button_Color = new Button();
            PictureBox_OutlineColor = new Button();
            PictureBox = new PictureBox();
            toolTip1 = new ToolTip(components);
            MenuStrip.SuspendLayout();
            Panel.SuspendLayout();
            ShapesScrollMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.BackColor = Color.FromArgb(243, 243, 243);
            MenuStrip.ImageScalingSize = new Size(20, 20);
            MenuStrip.Items.AddRange(new ToolStripItem[] { FileMenu, ToolMenu, ShapesMenu, HelpMenu, UndoMenu, RedoMenu });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(1153, 28);
            MenuStrip.TabIndex = 0;
            MenuStrip.Text = "MenuStrip";
            // 
            // FileMenu
            // 
            FileMenu.DropDownItems.AddRange(new ToolStripItem[] { SaveMenu, OpenMenu });
            FileMenu.Name = "FileMenu";
            FileMenu.Size = new Size(46, 24);
            FileMenu.Text = "File";
            // 
            // SaveMenu
            // 
            SaveMenu.Image = (Image)resources.GetObject("SaveMenu.Image");
            SaveMenu.Name = "SaveMenu";
            SaveMenu.ShortcutKeyDisplayString = "Ctrl + S";
            SaveMenu.ShortcutKeys = Keys.Control | Keys.S;
            SaveMenu.Size = new Size(189, 26);
            SaveMenu.Text = "Save";
            SaveMenu.Click += SaveMenu_Click;
            // 
            // OpenMenu
            // 
            OpenMenu.Image = (Image)resources.GetObject("OpenMenu.Image");
            OpenMenu.Name = "OpenMenu";
            OpenMenu.ShortcutKeyDisplayString = "Ctrl + O";
            OpenMenu.ShortcutKeys = Keys.Control | Keys.O;
            OpenMenu.Size = new Size(189, 26);
            OpenMenu.Text = "Open";
            OpenMenu.Click += OpenMenu_Click;
            // 
            // ToolMenu
            // 
            ToolMenu.DropDownItems.AddRange(new ToolStripItem[] { ColorPickerMenu, FillBucketMenu, DeleteMenu, MoveMenu, PointerMenu, ClearMenu });
            ToolMenu.Name = "ToolMenu";
            ToolMenu.Size = new Size(58, 24);
            ToolMenu.Text = "Tools";
            // 
            // ColorPickerMenu
            // 
            ColorPickerMenu.Image = Properties.Resources.Palette_icon_original1;
            ColorPickerMenu.Name = "ColorPickerMenu";
            ColorPickerMenu.ShortcutKeyDisplayString = "Ctrl + P";
            ColorPickerMenu.ShortcutKeys = Keys.Control | Keys.P;
            ColorPickerMenu.Size = new Size(233, 26);
            ColorPickerMenu.Text = "Color Picker";
            ColorPickerMenu.Click += Button_Color_Click;
            // 
            // FillBucketMenu
            // 
            FillBucketMenu.Image = (Image)resources.GetObject("FillBucketMenu.Image");
            FillBucketMenu.Name = "FillBucketMenu";
            FillBucketMenu.ShortcutKeyDisplayString = "Ctrl + F";
            FillBucketMenu.ShortcutKeys = Keys.Control | Keys.F;
            FillBucketMenu.Size = new Size(233, 26);
            FillBucketMenu.Text = "Fill Bucket";
            FillBucketMenu.Click += Button_Fill_Click;
            // 
            // DeleteMenu
            // 
            DeleteMenu.Image = (Image)resources.GetObject("DeleteMenu.Image");
            DeleteMenu.Name = "DeleteMenu";
            DeleteMenu.ShortcutKeyDisplayString = "Del";
            DeleteMenu.ShortcutKeys = Keys.Delete;
            DeleteMenu.Size = new Size(233, 26);
            DeleteMenu.Text = "Delete";
            DeleteMenu.Click += Button_Delete_Click;
            // 
            // MoveMenu
            // 
            MoveMenu.Image = Properties.Resources.Move_icon_original;
            MoveMenu.Name = "MoveMenu";
            MoveMenu.ShortcutKeyDisplayString = "Ctrl + M";
            MoveMenu.ShortcutKeys = Keys.Control | Keys.M;
            MoveMenu.Size = new Size(233, 26);
            MoveMenu.Text = "Move";
            MoveMenu.Click += Button_Move_Click;
            // 
            // PointerMenu
            // 
            PointerMenu.Image = Properties.Resources.Pointer_icon_original;
            PointerMenu.Name = "PointerMenu";
            PointerMenu.ShortcutKeyDisplayString = "Ctrl + Alt + P";
            PointerMenu.ShortcutKeys = Keys.Control | Keys.Alt | Keys.P;
            PointerMenu.Size = new Size(233, 26);
            PointerMenu.Text = "Pointer";
            // 
            // ClearMenu
            // 
            ClearMenu.Image = Properties.Resources.Clear_icon_original;
            ClearMenu.Name = "ClearMenu";
            ClearMenu.ShortcutKeyDisplayString = "Ctrl + Del";
            ClearMenu.ShortcutKeys = Keys.Control | Keys.Delete;
            ClearMenu.Size = new Size(233, 26);
            ClearMenu.Text = "Clear";
            ClearMenu.Click += Button_Clear_Click;
            // 
            // ShapesMenu
            // 
            ShapesMenu.DropDownItems.AddRange(new ToolStripItem[] { LineMenu, CircleMenu, RectangleMenu, TriangleMenu });
            ShapesMenu.Name = "ShapesMenu";
            ShapesMenu.Size = new Size(70, 24);
            ShapesMenu.Text = "Shapes";
            // 
            // LineMenu
            // 
            LineMenu.Image = (Image)resources.GetObject("LineMenu.Image");
            LineMenu.Name = "LineMenu";
            LineMenu.ShortcutKeyDisplayString = "Crtl + L";
            LineMenu.ShortcutKeys = Keys.Control | Keys.L;
            LineMenu.Size = new Size(217, 26);
            LineMenu.Text = "Line";
            LineMenu.Click += Button_Line_Click;
            // 
            // CircleMenu
            // 
            CircleMenu.Image = (Image)resources.GetObject("CircleMenu.Image");
            CircleMenu.Name = "CircleMenu";
            CircleMenu.ShortcutKeyDisplayString = "Ctrl + C";
            CircleMenu.ShortcutKeys = Keys.Control | Keys.C;
            CircleMenu.Size = new Size(217, 26);
            CircleMenu.Text = "Circle";
            CircleMenu.Click += Button_Circle_Click;
            // 
            // RectangleMenu
            // 
            RectangleMenu.Image = (Image)resources.GetObject("RectangleMenu.Image");
            RectangleMenu.Name = "RectangleMenu";
            RectangleMenu.ShortcutKeyDisplayString = "Ctrl + R";
            RectangleMenu.ShortcutKeys = Keys.Control | Keys.R;
            RectangleMenu.Size = new Size(217, 26);
            RectangleMenu.Text = "Rectangle";
            RectangleMenu.Click += Button_Rectangle_Click;
            // 
            // TriangleMenu
            // 
            TriangleMenu.Image = (Image)resources.GetObject("TriangleMenu.Image");
            TriangleMenu.Name = "TriangleMenu";
            TriangleMenu.ShortcutKeyDisplayString = "Ctrl + T";
            TriangleMenu.ShortcutKeys = Keys.Control | Keys.T;
            TriangleMenu.Size = new Size(217, 26);
            TriangleMenu.Text = "Triangle";
            TriangleMenu.Click += Button_Triangle_Click;
            // 
            // HelpMenu
            // 
            HelpMenu.Name = "HelpMenu";
            HelpMenu.Size = new Size(55, 24);
            HelpMenu.Text = "Help";
            HelpMenu.Click += HelpMenu_Click;
            HelpMenu.MouseEnter += HelpMenu_MouseEnter;
            HelpMenu.MouseLeave += HelpMenu_MouseLeave;
            // 
            // UndoMenu
            // 
            UndoMenu.Image = Properties.Resources.Undo_icon_original;
            UndoMenu.Name = "UndoMenu";
            UndoMenu.ShortcutKeys = Keys.Control | Keys.Z;
            UndoMenu.Size = new Size(34, 24);
            UndoMenu.Click += UndoMenu_Click;
            // 
            // RedoMenu
            // 
            RedoMenu.Image = Properties.Resources.Redo_icon_original;
            RedoMenu.Name = "RedoMenu";
            RedoMenu.ShortcutKeys = Keys.Control | Keys.Y;
            RedoMenu.Size = new Size(34, 24);
            RedoMenu.Click += RedoMenu_Click;
            // 
            // Panel
            // 
            Panel.BackColor = Color.FromArgb(249, 249, 249);
            Panel.Controls.Add(panel5);
            Panel.Controls.Add(panel3);
            Panel.Controls.Add(Button_Pointer);
            Panel.Controls.Add(panel4);
            Panel.Controls.Add(TextBox_Width);
            Panel.Controls.Add(Label_Width);
            Panel.Controls.Add(Button_Move);
            Panel.Controls.Add(Button_Clear);
            Panel.Controls.Add(Label_Colors);
            Panel.Controls.Add(Label_Shapes);
            Panel.Controls.Add(Label_Tools);
            Panel.Controls.Add(Button_Delete);
            Panel.Controls.Add(panel2);
            Panel.Controls.Add(ShapesScrollMenu);
            Panel.Controls.Add(panel1);
            Panel.Controls.Add(Button_PurpleTwo);
            Panel.Controls.Add(Button_PurpleOne);
            Panel.Controls.Add(Button_BlueTwo);
            Panel.Controls.Add(Button_BlueOne);
            Panel.Controls.Add(Button_YellowTwo);
            Panel.Controls.Add(Button_YellowOne);
            Panel.Controls.Add(Button_Blue);
            Panel.Controls.Add(Button_Purple);
            Panel.Controls.Add(Button_Yellow);
            Panel.Controls.Add(Button_RedTwo);
            Panel.Controls.Add(Button_RedOne);
            Panel.Controls.Add(Button_Red);
            Panel.Controls.Add(Button_BrownTwo);
            Panel.Controls.Add(Button_GreenTwo);
            Panel.Controls.Add(Button_BrownOne);
            Panel.Controls.Add(Button_GreenOne);
            Panel.Controls.Add(Button_OrangeTwo);
            Panel.Controls.Add(Button_WhiteTwo);
            Panel.Controls.Add(Button_WhiteOne);
            Panel.Controls.Add(Button_BlackTwo);
            Panel.Controls.Add(Button_BlackOne);
            Panel.Controls.Add(Button_OrangeOne);
            Panel.Controls.Add(Button_Brown);
            Panel.Controls.Add(Button_Green);
            Panel.Controls.Add(Button_Orange);
            Panel.Controls.Add(Button_White);
            Panel.Controls.Add(Button_Black);
            Panel.Controls.Add(Button_Fill);
            Panel.Controls.Add(Button_Color);
            Panel.Controls.Add(PictureBox_OutlineColor);
            Panel.Dock = DockStyle.Top;
            Panel.Location = new Point(0, 28);
            Panel.Name = "Panel";
            Panel.Size = new Size(1153, 145);
            Panel.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.FromArgb(243, 243, 243);
            panel5.Location = new Point(1149, 0);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(6, 148);
            panel5.TabIndex = 40;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(243, 243, 243);
            panel3.Location = new Point(-3, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 148);
            panel3.TabIndex = 40;
            // 
            // Button_Pointer
            // 
            Button_Pointer.Anchor = AnchorStyles.None;
            Button_Pointer.AutoSize = true;
            Button_Pointer.Cursor = Cursors.Hand;
            Button_Pointer.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Pointer.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_Pointer.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_Pointer.FlatStyle = FlatStyle.Flat;
            Button_Pointer.ForeColor = Color.White;
            Button_Pointer.Image = Properties.Resources.Pointer_icon_40x40;
            Button_Pointer.Location = new Point(88, 68);
            Button_Pointer.Name = "Button_Pointer";
            Button_Pointer.Size = new Size(48, 48);
            Button_Pointer.TabIndex = 53;
            Button_Pointer.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_Pointer, "Pointer");
            Button_Pointer.UseVisualStyleBackColor = true;
            Button_Pointer.Click += Button_Pointer_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(243, 243, 243);
            panel4.Location = new Point(462, 2);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(6, 148);
            panel4.TabIndex = 40;
            // 
            // TextBox_Width
            // 
            TextBox_Width.Anchor = AnchorStyles.None;
            TextBox_Width.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_Width.Location = new Point(487, 47);
            TextBox_Width.Name = "TextBox_Width";
            TextBox_Width.Size = new Size(154, 34);
            TextBox_Width.TabIndex = 52;
            TextBox_Width.TextAlign = HorizontalAlignment.Center;
            TextBox_Width.TextChanged += TextBox_Width_TextChanged;
            // 
            // Label_Width
            // 
            Label_Width.Anchor = AnchorStyles.None;
            Label_Width.AutoSize = true;
            Label_Width.ForeColor = Color.FromArgb(64, 64, 64);
            Label_Width.Location = new Point(540, 119);
            Label_Width.Name = "Label_Width";
            Label_Width.Size = new Size(49, 20);
            Label_Width.TabIndex = 51;
            Label_Width.Text = "Width";
            // 
            // Button_Move
            // 
            Button_Move.Anchor = AnchorStyles.None;
            Button_Move.AutoSize = true;
            Button_Move.Cursor = Cursors.Hand;
            Button_Move.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Move.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_Move.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_Move.FlatStyle = FlatStyle.Flat;
            Button_Move.ForeColor = Color.White;
            Button_Move.Image = (Image)resources.GetObject("Button_Move.Image");
            Button_Move.Location = new Point(88, 14);
            Button_Move.Name = "Button_Move";
            Button_Move.Size = new Size(48, 48);
            Button_Move.TabIndex = 49;
            Button_Move.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_Move, "Move");
            Button_Move.UseVisualStyleBackColor = true;
            Button_Move.Click += Button_Move_Click;
            // 
            // Button_Clear
            // 
            Button_Clear.Anchor = AnchorStyles.None;
            Button_Clear.AutoSize = true;
            Button_Clear.Cursor = Cursors.Hand;
            Button_Clear.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Clear.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_Clear.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_Clear.FlatStyle = FlatStyle.Flat;
            Button_Clear.ForeColor = Color.White;
            Button_Clear.Image = (Image)resources.GetObject("Button_Clear.Image");
            Button_Clear.Location = new Point(157, 42);
            Button_Clear.Name = "Button_Clear";
            Button_Clear.Size = new Size(48, 48);
            Button_Clear.TabIndex = 48;
            Button_Clear.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_Clear, "Clear");
            Button_Clear.UseVisualStyleBackColor = true;
            Button_Clear.Click += Button_Clear_Click;
            // 
            // Label_Colors
            // 
            Label_Colors.Anchor = AnchorStyles.None;
            Label_Colors.AutoSize = true;
            Label_Colors.ForeColor = Color.FromArgb(64, 64, 64);
            Label_Colors.Location = new Point(884, 119);
            Label_Colors.Name = "Label_Colors";
            Label_Colors.Size = new Size(51, 20);
            Label_Colors.TabIndex = 46;
            Label_Colors.Text = "Colors";
            // 
            // Label_Shapes
            // 
            Label_Shapes.Anchor = AnchorStyles.None;
            Label_Shapes.AutoSize = true;
            Label_Shapes.ForeColor = Color.FromArgb(64, 64, 64);
            Label_Shapes.Location = new Point(318, 119);
            Label_Shapes.Name = "Label_Shapes";
            Label_Shapes.Size = new Size(56, 20);
            Label_Shapes.TabIndex = 45;
            Label_Shapes.Text = "Shapes";
            // 
            // Label_Tools
            // 
            Label_Tools.Anchor = AnchorStyles.None;
            Label_Tools.AutoSize = true;
            Label_Tools.ForeColor = Color.FromArgb(64, 64, 64);
            Label_Tools.Location = new Point(91, 119);
            Label_Tools.Name = "Label_Tools";
            Label_Tools.Size = new Size(44, 20);
            Label_Tools.TabIndex = 3;
            Label_Tools.Text = "Tools";
            // 
            // Button_Delete
            // 
            Button_Delete.Anchor = AnchorStyles.None;
            Button_Delete.AutoSize = true;
            Button_Delete.Cursor = Cursors.Hand;
            Button_Delete.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Delete.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_Delete.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_Delete.FlatStyle = FlatStyle.Flat;
            Button_Delete.ForeColor = Color.White;
            Button_Delete.Image = (Image)resources.GetObject("Button_Delete.Image");
            Button_Delete.Location = new Point(21, 68);
            Button_Delete.Name = "Button_Delete";
            Button_Delete.Size = new Size(48, 48);
            Button_Delete.TabIndex = 44;
            Button_Delete.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_Delete, "Delete");
            Button_Delete.UseVisualStyleBackColor = true;
            Button_Delete.Click += Button_Delete_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(243, 243, 243);
            panel2.Location = new Point(661, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(6, 148);
            panel2.TabIndex = 39;
            // 
            // ShapesScrollMenu
            // 
            ShapesScrollMenu.Anchor = AnchorStyles.None;
            ShapesScrollMenu.AutoScroll = true;
            ShapesScrollMenu.Controls.Add(Button_Line);
            ShapesScrollMenu.Controls.Add(Button_Circle);
            ShapesScrollMenu.Controls.Add(Button_Rectangle);
            ShapesScrollMenu.Controls.Add(Button_Triangle);
            ShapesScrollMenu.Location = new Point(252, 14);
            ShapesScrollMenu.Name = "ShapesScrollMenu";
            ShapesScrollMenu.Size = new Size(186, 102);
            ShapesScrollMenu.TabIndex = 37;
            // 
            // Button_Line
            // 
            Button_Line.Anchor = AnchorStyles.None;
            Button_Line.AutoSize = true;
            Button_Line.Cursor = Cursors.Hand;
            Button_Line.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Line.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_Line.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_Line.FlatStyle = FlatStyle.Flat;
            Button_Line.ForeColor = Color.FromArgb(249, 249, 249);
            Button_Line.Image = (Image)resources.GetObject("Button_Line.Image");
            Button_Line.Location = new Point(3, 3);
            Button_Line.Name = "Button_Line";
            Button_Line.Size = new Size(61, 58);
            Button_Line.TabIndex = 5;
            Button_Line.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_Line, "Line");
            Button_Line.UseVisualStyleBackColor = true;
            Button_Line.Click += Button_Line_Click;
            // 
            // Button_Circle
            // 
            Button_Circle.Anchor = AnchorStyles.None;
            Button_Circle.AutoSize = true;
            Button_Circle.Cursor = Cursors.Hand;
            Button_Circle.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Circle.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_Circle.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_Circle.FlatStyle = FlatStyle.Flat;
            Button_Circle.ForeColor = Color.FromArgb(249, 249, 249);
            Button_Circle.Image = (Image)resources.GetObject("Button_Circle.Image");
            Button_Circle.Location = new Point(70, 3);
            Button_Circle.Name = "Button_Circle";
            Button_Circle.Size = new Size(61, 58);
            Button_Circle.TabIndex = 6;
            Button_Circle.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_Circle, "Circle");
            Button_Circle.UseVisualStyleBackColor = true;
            Button_Circle.Click += Button_Circle_Click;
            // 
            // Button_Rectangle
            // 
            Button_Rectangle.Anchor = AnchorStyles.None;
            Button_Rectangle.AutoSize = true;
            Button_Rectangle.Cursor = Cursors.Hand;
            Button_Rectangle.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Rectangle.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_Rectangle.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_Rectangle.FlatStyle = FlatStyle.Flat;
            Button_Rectangle.ForeColor = Color.FromArgb(249, 249, 249);
            Button_Rectangle.Image = (Image)resources.GetObject("Button_Rectangle.Image");
            Button_Rectangle.Location = new Point(3, 67);
            Button_Rectangle.Name = "Button_Rectangle";
            Button_Rectangle.Size = new Size(61, 58);
            Button_Rectangle.TabIndex = 7;
            Button_Rectangle.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_Rectangle, "Rectangle");
            Button_Rectangle.UseVisualStyleBackColor = true;
            Button_Rectangle.Click += Button_Rectangle_Click;
            // 
            // Button_Triangle
            // 
            Button_Triangle.Anchor = AnchorStyles.None;
            Button_Triangle.AutoSize = true;
            Button_Triangle.Cursor = Cursors.Hand;
            Button_Triangle.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Triangle.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_Triangle.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_Triangle.FlatStyle = FlatStyle.Flat;
            Button_Triangle.ForeColor = Color.White;
            Button_Triangle.Image = (Image)resources.GetObject("Button_Triangle.Image");
            Button_Triangle.Location = new Point(70, 67);
            Button_Triangle.Name = "Button_Triangle";
            Button_Triangle.Size = new Size(61, 58);
            Button_Triangle.TabIndex = 8;
            Button_Triangle.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_Triangle, "Triangle");
            Button_Triangle.UseVisualStyleBackColor = true;
            Button_Triangle.Click += Button_Triangle_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(243, 243, 243);
            panel1.Location = new Point(225, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(6, 148);
            panel1.TabIndex = 38;
            // 
            // Button_PurpleTwo
            // 
            Button_PurpleTwo.Anchor = AnchorStyles.None;
            Button_PurpleTwo.BackColor = Color.FromArgb(157, 83, 255);
            Button_PurpleTwo.Cursor = Cursors.Hand;
            Button_PurpleTwo.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_PurpleTwo.FlatAppearance.BorderSize = 0;
            Button_PurpleTwo.FlatStyle = FlatStyle.Popup;
            Button_PurpleTwo.ForeColor = Color.Transparent;
            Button_PurpleTwo.Location = new Point(1056, 78);
            Button_PurpleTwo.Name = "Button_PurpleTwo";
            Button_PurpleTwo.Size = new Size(35, 25);
            Button_PurpleTwo.TabIndex = 36;
            Button_PurpleTwo.Tag = "ColorButton";
            Button_PurpleTwo.UseVisualStyleBackColor = false;
            Button_PurpleTwo.Click += Button_Colored_Click;
            // 
            // Button_PurpleOne
            // 
            Button_PurpleOne.Anchor = AnchorStyles.None;
            Button_PurpleOne.BackColor = Color.FromArgb(182, 125, 252);
            Button_PurpleOne.Cursor = Cursors.Hand;
            Button_PurpleOne.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_PurpleOne.FlatAppearance.BorderSize = 0;
            Button_PurpleOne.FlatStyle = FlatStyle.Popup;
            Button_PurpleOne.ForeColor = Color.Transparent;
            Button_PurpleOne.Location = new Point(1056, 47);
            Button_PurpleOne.Name = "Button_PurpleOne";
            Button_PurpleOne.Size = new Size(35, 25);
            Button_PurpleOne.TabIndex = 35;
            Button_PurpleOne.Tag = "ColorButton";
            Button_PurpleOne.UseVisualStyleBackColor = false;
            Button_PurpleOne.Click += Button_Colored_Click;
            // 
            // Button_BlueTwo
            // 
            Button_BlueTwo.Anchor = AnchorStyles.None;
            Button_BlueTwo.BackColor = Color.FromArgb(72, 104, 231);
            Button_BlueTwo.Cursor = Cursors.Hand;
            Button_BlueTwo.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_BlueTwo.FlatAppearance.BorderSize = 0;
            Button_BlueTwo.FlatStyle = FlatStyle.Popup;
            Button_BlueTwo.ForeColor = Color.Transparent;
            Button_BlueTwo.Location = new Point(1097, 78);
            Button_BlueTwo.Name = "Button_BlueTwo";
            Button_BlueTwo.Size = new Size(35, 25);
            Button_BlueTwo.TabIndex = 34;
            Button_BlueTwo.Tag = "ColorButton";
            Button_BlueTwo.UseVisualStyleBackColor = false;
            Button_BlueTwo.Click += Button_Colored_Click;
            // 
            // Button_BlueOne
            // 
            Button_BlueOne.Anchor = AnchorStyles.None;
            Button_BlueOne.BackColor = Color.FromArgb(120, 144, 239);
            Button_BlueOne.Cursor = Cursors.Hand;
            Button_BlueOne.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_BlueOne.FlatAppearance.BorderSize = 0;
            Button_BlueOne.FlatStyle = FlatStyle.Popup;
            Button_BlueOne.ForeColor = Color.Transparent;
            Button_BlueOne.Location = new Point(1097, 47);
            Button_BlueOne.Name = "Button_BlueOne";
            Button_BlueOne.Size = new Size(35, 25);
            Button_BlueOne.TabIndex = 33;
            Button_BlueOne.Tag = "ColorButton";
            Button_BlueOne.UseVisualStyleBackColor = false;
            Button_BlueOne.Click += Button_Colored_Click;
            // 
            // Button_YellowTwo
            // 
            Button_YellowTwo.Anchor = AnchorStyles.None;
            Button_YellowTwo.BackColor = Color.FromArgb(252, 229, 97);
            Button_YellowTwo.Cursor = Cursors.Hand;
            Button_YellowTwo.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_YellowTwo.FlatAppearance.BorderSize = 0;
            Button_YellowTwo.FlatStyle = FlatStyle.Popup;
            Button_YellowTwo.ForeColor = Color.Transparent;
            Button_YellowTwo.Location = new Point(1015, 78);
            Button_YellowTwo.Name = "Button_YellowTwo";
            Button_YellowTwo.Size = new Size(35, 25);
            Button_YellowTwo.TabIndex = 32;
            Button_YellowTwo.Tag = "ColorButton";
            Button_YellowTwo.UseVisualStyleBackColor = false;
            Button_YellowTwo.Click += Button_Colored_Click;
            // 
            // Button_YellowOne
            // 
            Button_YellowOne.Anchor = AnchorStyles.None;
            Button_YellowOne.BackColor = Color.FromArgb(240, 227, 153);
            Button_YellowOne.Cursor = Cursors.Hand;
            Button_YellowOne.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_YellowOne.FlatAppearance.BorderSize = 0;
            Button_YellowOne.FlatStyle = FlatStyle.Popup;
            Button_YellowOne.ForeColor = Color.Transparent;
            Button_YellowOne.Location = new Point(1015, 47);
            Button_YellowOne.Name = "Button_YellowOne";
            Button_YellowOne.Size = new Size(35, 25);
            Button_YellowOne.TabIndex = 31;
            Button_YellowOne.Tag = "ColorButton";
            Button_YellowOne.UseVisualStyleBackColor = false;
            Button_YellowOne.Click += Button_Colored_Click;
            // 
            // Button_Blue
            // 
            Button_Blue.Anchor = AnchorStyles.None;
            Button_Blue.BackColor = Color.FromArgb(23, 53, 189);
            Button_Blue.Cursor = Cursors.Hand;
            Button_Blue.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Blue.FlatAppearance.BorderSize = 0;
            Button_Blue.FlatStyle = FlatStyle.Popup;
            Button_Blue.ForeColor = Color.Transparent;
            Button_Blue.Location = new Point(1097, 16);
            Button_Blue.Name = "Button_Blue";
            Button_Blue.Size = new Size(35, 25);
            Button_Blue.TabIndex = 30;
            Button_Blue.Tag = "ColorButton";
            toolTip1.SetToolTip(Button_Blue, "Blue");
            Button_Blue.UseVisualStyleBackColor = false;
            Button_Blue.Click += Button_Colored_Click;
            // 
            // Button_Purple
            // 
            Button_Purple.Anchor = AnchorStyles.None;
            Button_Purple.BackColor = Color.FromArgb(103, 34, 217);
            Button_Purple.Cursor = Cursors.Hand;
            Button_Purple.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Purple.FlatAppearance.BorderSize = 0;
            Button_Purple.FlatStyle = FlatStyle.Popup;
            Button_Purple.ForeColor = Color.Transparent;
            Button_Purple.Location = new Point(1056, 16);
            Button_Purple.Name = "Button_Purple";
            Button_Purple.Size = new Size(35, 25);
            Button_Purple.TabIndex = 29;
            Button_Purple.Tag = "ColorButton";
            toolTip1.SetToolTip(Button_Purple, "Purple");
            Button_Purple.UseVisualStyleBackColor = false;
            Button_Purple.Click += Button_Colored_Click;
            // 
            // Button_Yellow
            // 
            Button_Yellow.Anchor = AnchorStyles.None;
            Button_Yellow.BackColor = Color.FromArgb(255, 231, 0);
            Button_Yellow.Cursor = Cursors.Hand;
            Button_Yellow.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Yellow.FlatAppearance.BorderSize = 0;
            Button_Yellow.FlatStyle = FlatStyle.Popup;
            Button_Yellow.ForeColor = Color.Transparent;
            Button_Yellow.Location = new Point(1015, 16);
            Button_Yellow.Name = "Button_Yellow";
            Button_Yellow.Size = new Size(35, 25);
            Button_Yellow.TabIndex = 28;
            Button_Yellow.Tag = "ColorButton";
            toolTip1.SetToolTip(Button_Yellow, "Yellow");
            Button_Yellow.UseVisualStyleBackColor = false;
            Button_Yellow.Click += Button_Colored_Click;
            // 
            // Button_RedTwo
            // 
            Button_RedTwo.Anchor = AnchorStyles.None;
            Button_RedTwo.BackColor = Color.FromArgb(255, 67, 89);
            Button_RedTwo.Cursor = Cursors.Hand;
            Button_RedTwo.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_RedTwo.FlatAppearance.BorderSize = 0;
            Button_RedTwo.FlatStyle = FlatStyle.Popup;
            Button_RedTwo.ForeColor = Color.Transparent;
            Button_RedTwo.Location = new Point(974, 78);
            Button_RedTwo.Name = "Button_RedTwo";
            Button_RedTwo.Size = new Size(35, 25);
            Button_RedTwo.TabIndex = 27;
            Button_RedTwo.Tag = "ColorButton";
            Button_RedTwo.UseVisualStyleBackColor = false;
            Button_RedTwo.Click += Button_Colored_Click;
            // 
            // Button_RedOne
            // 
            Button_RedOne.Anchor = AnchorStyles.None;
            Button_RedOne.BackColor = Color.FromArgb(252, 115, 131);
            Button_RedOne.Cursor = Cursors.Hand;
            Button_RedOne.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_RedOne.FlatAppearance.BorderSize = 0;
            Button_RedOne.FlatStyle = FlatStyle.Popup;
            Button_RedOne.ForeColor = Color.Transparent;
            Button_RedOne.Location = new Point(974, 47);
            Button_RedOne.Name = "Button_RedOne";
            Button_RedOne.Size = new Size(35, 25);
            Button_RedOne.TabIndex = 26;
            Button_RedOne.Tag = "ColorButton";
            Button_RedOne.UseVisualStyleBackColor = false;
            Button_RedOne.Click += Button_Colored_Click;
            // 
            // Button_Red
            // 
            Button_Red.Anchor = AnchorStyles.None;
            Button_Red.BackColor = Color.FromArgb(213, 23, 33);
            Button_Red.Cursor = Cursors.Hand;
            Button_Red.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Red.FlatAppearance.BorderSize = 0;
            Button_Red.FlatStyle = FlatStyle.Popup;
            Button_Red.ForeColor = Color.Transparent;
            Button_Red.Location = new Point(974, 16);
            Button_Red.Name = "Button_Red";
            Button_Red.Size = new Size(35, 25);
            Button_Red.TabIndex = 23;
            Button_Red.Tag = "ColorButton";
            toolTip1.SetToolTip(Button_Red, "Red");
            Button_Red.UseVisualStyleBackColor = false;
            Button_Red.Click += Button_Colored_Click;
            // 
            // Button_BrownTwo
            // 
            Button_BrownTwo.Anchor = AnchorStyles.None;
            Button_BrownTwo.BackColor = Color.FromArgb(189, 150, 137);
            Button_BrownTwo.Cursor = Cursors.Hand;
            Button_BrownTwo.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_BrownTwo.FlatAppearance.BorderSize = 0;
            Button_BrownTwo.FlatStyle = FlatStyle.Popup;
            Button_BrownTwo.ForeColor = Color.Transparent;
            Button_BrownTwo.Location = new Point(933, 78);
            Button_BrownTwo.Name = "Button_BrownTwo";
            Button_BrownTwo.Size = new Size(35, 25);
            Button_BrownTwo.TabIndex = 21;
            Button_BrownTwo.Tag = "ColorButton";
            Button_BrownTwo.UseVisualStyleBackColor = false;
            Button_BrownTwo.Click += Button_Colored_Click;
            // 
            // Button_GreenTwo
            // 
            Button_GreenTwo.Anchor = AnchorStyles.None;
            Button_GreenTwo.BackColor = Color.FromArgb(0, 130, 38);
            Button_GreenTwo.Cursor = Cursors.Hand;
            Button_GreenTwo.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_GreenTwo.FlatAppearance.BorderSize = 0;
            Button_GreenTwo.FlatStyle = FlatStyle.Popup;
            Button_GreenTwo.ForeColor = Color.Transparent;
            Button_GreenTwo.Location = new Point(892, 78);
            Button_GreenTwo.Name = "Button_GreenTwo";
            Button_GreenTwo.Size = new Size(35, 25);
            Button_GreenTwo.TabIndex = 20;
            Button_GreenTwo.Tag = "ColorButton";
            Button_GreenTwo.UseVisualStyleBackColor = false;
            Button_GreenTwo.Click += Button_Colored_Click;
            // 
            // Button_BrownOne
            // 
            Button_BrownOne.Anchor = AnchorStyles.None;
            Button_BrownOne.BackColor = Color.FromArgb(209, 179, 165);
            Button_BrownOne.Cursor = Cursors.Hand;
            Button_BrownOne.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_BrownOne.FlatAppearance.BorderSize = 0;
            Button_BrownOne.FlatStyle = FlatStyle.Popup;
            Button_BrownOne.ForeColor = Color.Transparent;
            Button_BrownOne.Location = new Point(933, 47);
            Button_BrownOne.Name = "Button_BrownOne";
            Button_BrownOne.Size = new Size(35, 25);
            Button_BrownOne.TabIndex = 19;
            Button_BrownOne.Tag = "ColorButton";
            Button_BrownOne.UseVisualStyleBackColor = false;
            Button_BrownOne.Click += Button_Colored_Click;
            // 
            // Button_GreenOne
            // 
            Button_GreenOne.Anchor = AnchorStyles.None;
            Button_GreenOne.BackColor = Color.FromArgb(0, 158, 47);
            Button_GreenOne.Cursor = Cursors.Hand;
            Button_GreenOne.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_GreenOne.FlatAppearance.BorderSize = 0;
            Button_GreenOne.FlatStyle = FlatStyle.Popup;
            Button_GreenOne.ForeColor = Color.Transparent;
            Button_GreenOne.Location = new Point(892, 47);
            Button_GreenOne.Name = "Button_GreenOne";
            Button_GreenOne.Size = new Size(35, 25);
            Button_GreenOne.TabIndex = 18;
            Button_GreenOne.Tag = "ColorButton";
            Button_GreenOne.UseVisualStyleBackColor = false;
            Button_GreenOne.Click += Button_Colored_Click;
            // 
            // Button_OrangeTwo
            // 
            Button_OrangeTwo.Anchor = AnchorStyles.None;
            Button_OrangeTwo.BackColor = Color.FromArgb(181, 87, 0);
            Button_OrangeTwo.Cursor = Cursors.Hand;
            Button_OrangeTwo.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_OrangeTwo.FlatAppearance.BorderSize = 0;
            Button_OrangeTwo.FlatStyle = FlatStyle.Popup;
            Button_OrangeTwo.ForeColor = Color.Transparent;
            Button_OrangeTwo.Location = new Point(851, 78);
            Button_OrangeTwo.Name = "Button_OrangeTwo";
            Button_OrangeTwo.Size = new Size(35, 25);
            Button_OrangeTwo.TabIndex = 17;
            Button_OrangeTwo.Tag = "ColorButton";
            Button_OrangeTwo.UseVisualStyleBackColor = false;
            Button_OrangeTwo.Click += Button_Colored_Click;
            // 
            // Button_WhiteTwo
            // 
            Button_WhiteTwo.Anchor = AnchorStyles.None;
            Button_WhiteTwo.BackColor = Color.FromArgb(191, 188, 191);
            Button_WhiteTwo.Cursor = Cursors.Hand;
            Button_WhiteTwo.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_WhiteTwo.FlatAppearance.BorderSize = 0;
            Button_WhiteTwo.FlatStyle = FlatStyle.Popup;
            Button_WhiteTwo.ForeColor = Color.Transparent;
            Button_WhiteTwo.Location = new Point(810, 78);
            Button_WhiteTwo.Name = "Button_WhiteTwo";
            Button_WhiteTwo.Size = new Size(35, 25);
            Button_WhiteTwo.TabIndex = 16;
            Button_WhiteTwo.Tag = "ColorButton";
            Button_WhiteTwo.UseVisualStyleBackColor = false;
            Button_WhiteTwo.Click += Button_Colored_Click;
            // 
            // Button_WhiteOne
            // 
            Button_WhiteOne.Anchor = AnchorStyles.None;
            Button_WhiteOne.BackColor = Color.FromArgb(218, 215, 218);
            Button_WhiteOne.Cursor = Cursors.Hand;
            Button_WhiteOne.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_WhiteOne.FlatAppearance.BorderSize = 0;
            Button_WhiteOne.FlatStyle = FlatStyle.Popup;
            Button_WhiteOne.ForeColor = Color.Transparent;
            Button_WhiteOne.Location = new Point(810, 47);
            Button_WhiteOne.Name = "Button_WhiteOne";
            Button_WhiteOne.Size = new Size(35, 25);
            Button_WhiteOne.TabIndex = 15;
            Button_WhiteOne.Tag = "ColorButton";
            Button_WhiteOne.UseVisualStyleBackColor = false;
            Button_WhiteOne.Click += Button_Colored_Click;
            // 
            // Button_BlackTwo
            // 
            Button_BlackTwo.Anchor = AnchorStyles.None;
            Button_BlackTwo.BackColor = Color.FromArgb(44, 44, 44);
            Button_BlackTwo.Cursor = Cursors.Hand;
            Button_BlackTwo.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_BlackTwo.FlatAppearance.BorderSize = 0;
            Button_BlackTwo.FlatStyle = FlatStyle.Popup;
            Button_BlackTwo.ForeColor = Color.Transparent;
            Button_BlackTwo.Location = new Point(769, 78);
            Button_BlackTwo.Name = "Button_BlackTwo";
            Button_BlackTwo.Size = new Size(35, 25);
            Button_BlackTwo.TabIndex = 14;
            Button_BlackTwo.Tag = "ColorButton";
            Button_BlackTwo.UseVisualStyleBackColor = false;
            Button_BlackTwo.Click += Button_Colored_Click;
            // 
            // Button_BlackOne
            // 
            Button_BlackOne.Anchor = AnchorStyles.None;
            Button_BlackOne.BackColor = Color.FromArgb(101, 98, 101);
            Button_BlackOne.Cursor = Cursors.Hand;
            Button_BlackOne.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_BlackOne.FlatAppearance.BorderSize = 0;
            Button_BlackOne.FlatStyle = FlatStyle.Popup;
            Button_BlackOne.ForeColor = Color.Transparent;
            Button_BlackOne.Location = new Point(769, 47);
            Button_BlackOne.Name = "Button_BlackOne";
            Button_BlackOne.Size = new Size(35, 25);
            Button_BlackOne.TabIndex = 13;
            Button_BlackOne.Tag = "ColorButton";
            Button_BlackOne.UseVisualStyleBackColor = false;
            Button_BlackOne.Click += Button_Colored_Click;
            // 
            // Button_OrangeOne
            // 
            Button_OrangeOne.Anchor = AnchorStyles.None;
            Button_OrangeOne.BackColor = Color.FromArgb(240, 160, 78);
            Button_OrangeOne.Cursor = Cursors.Hand;
            Button_OrangeOne.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_OrangeOne.FlatAppearance.BorderSize = 0;
            Button_OrangeOne.FlatStyle = FlatStyle.Popup;
            Button_OrangeOne.ForeColor = Color.Transparent;
            Button_OrangeOne.Location = new Point(851, 47);
            Button_OrangeOne.Name = "Button_OrangeOne";
            Button_OrangeOne.Size = new Size(35, 25);
            Button_OrangeOne.TabIndex = 12;
            Button_OrangeOne.Tag = "ColorButton";
            Button_OrangeOne.UseVisualStyleBackColor = false;
            Button_OrangeOne.Click += Button_Colored_Click;
            // 
            // Button_Brown
            // 
            Button_Brown.Anchor = AnchorStyles.None;
            Button_Brown.BackColor = Color.FromArgb(142, 107, 94);
            Button_Brown.Cursor = Cursors.Hand;
            Button_Brown.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Brown.FlatAppearance.BorderSize = 0;
            Button_Brown.FlatStyle = FlatStyle.Popup;
            Button_Brown.ForeColor = Color.Transparent;
            Button_Brown.Location = new Point(933, 16);
            Button_Brown.Name = "Button_Brown";
            Button_Brown.Size = new Size(35, 25);
            Button_Brown.TabIndex = 11;
            Button_Brown.Tag = "ColorButton";
            toolTip1.SetToolTip(Button_Brown, "Light Brown");
            Button_Brown.UseVisualStyleBackColor = false;
            Button_Brown.Click += Button_Colored_Click;
            // 
            // Button_Green
            // 
            Button_Green.Anchor = AnchorStyles.None;
            Button_Green.BackColor = Color.FromArgb(0, 181, 54);
            Button_Green.Cursor = Cursors.Hand;
            Button_Green.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Green.FlatAppearance.BorderSize = 0;
            Button_Green.FlatStyle = FlatStyle.Popup;
            Button_Green.ForeColor = Color.Transparent;
            Button_Green.Location = new Point(892, 16);
            Button_Green.Name = "Button_Green";
            Button_Green.Size = new Size(35, 25);
            Button_Green.TabIndex = 10;
            Button_Green.Tag = "ColorButton";
            toolTip1.SetToolTip(Button_Green, "Green");
            Button_Green.UseVisualStyleBackColor = false;
            Button_Green.Click += Button_Colored_Click;
            // 
            // Button_Orange
            // 
            Button_Orange.Anchor = AnchorStyles.None;
            Button_Orange.BackColor = Color.FromArgb(255, 128, 0);
            Button_Orange.Cursor = Cursors.Hand;
            Button_Orange.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Orange.FlatAppearance.BorderSize = 0;
            Button_Orange.FlatStyle = FlatStyle.Popup;
            Button_Orange.ForeColor = Color.Transparent;
            Button_Orange.Location = new Point(851, 16);
            Button_Orange.Name = "Button_Orange";
            Button_Orange.Size = new Size(35, 25);
            Button_Orange.TabIndex = 9;
            Button_Orange.Tag = "ColorButton";
            toolTip1.SetToolTip(Button_Orange, "Orange");
            Button_Orange.UseVisualStyleBackColor = false;
            Button_Orange.Click += Button_Colored_Click;
            // 
            // Button_White
            // 
            Button_White.Anchor = AnchorStyles.None;
            Button_White.BackColor = Color.White;
            Button_White.Cursor = Cursors.Hand;
            Button_White.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_White.FlatAppearance.BorderSize = 0;
            Button_White.FlatStyle = FlatStyle.Popup;
            Button_White.ForeColor = Color.Transparent;
            Button_White.Location = new Point(810, 16);
            Button_White.Name = "Button_White";
            Button_White.Size = new Size(35, 25);
            Button_White.TabIndex = 8;
            Button_White.Tag = "ColorButton";
            toolTip1.SetToolTip(Button_White, "White");
            Button_White.UseVisualStyleBackColor = false;
            Button_White.Click += Button_Colored_Click;
            // 
            // Button_Black
            // 
            Button_Black.Anchor = AnchorStyles.None;
            Button_Black.BackColor = Color.Black;
            Button_Black.Cursor = Cursors.Hand;
            Button_Black.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Black.FlatAppearance.BorderSize = 0;
            Button_Black.FlatStyle = FlatStyle.Popup;
            Button_Black.ForeColor = Color.Transparent;
            Button_Black.Location = new Point(769, 16);
            Button_Black.Name = "Button_Black";
            Button_Black.Size = new Size(35, 25);
            Button_Black.TabIndex = 8;
            Button_Black.Tag = "ColorButton";
            toolTip1.SetToolTip(Button_Black, "Black");
            Button_Black.UseVisualStyleBackColor = false;
            Button_Black.Click += Button_Colored_Click;
            // 
            // Button_Fill
            // 
            Button_Fill.Anchor = AnchorStyles.None;
            Button_Fill.AutoSize = true;
            Button_Fill.Cursor = Cursors.Hand;
            Button_Fill.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Fill.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_Fill.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_Fill.FlatStyle = FlatStyle.Flat;
            Button_Fill.ForeColor = Color.Black;
            Button_Fill.Image = (Image)resources.GetObject("Button_Fill.Image");
            Button_Fill.Location = new Point(21, 14);
            Button_Fill.Name = "Button_Fill";
            Button_Fill.Size = new Size(48, 48);
            Button_Fill.TabIndex = 2;
            Button_Fill.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_Fill, "Fill Bucket");
            Button_Fill.UseVisualStyleBackColor = true;
            Button_Fill.Click += Button_Fill_Click;
            // 
            // Button_Color
            // 
            Button_Color.Anchor = AnchorStyles.None;
            Button_Color.AutoSize = true;
            Button_Color.BackColor = Color.FromArgb(249, 249, 249);
            Button_Color.Cursor = Cursors.Hand;
            Button_Color.FlatAppearance.BorderColor = Color.FromArgb(249, 249, 249);
            Button_Color.FlatAppearance.MouseDownBackColor = Color.Silver;
            Button_Color.FlatAppearance.MouseOverBackColor = Color.LightGray;
            Button_Color.FlatStyle = FlatStyle.Flat;
            Button_Color.ForeColor = Color.FromArgb(249, 249, 249);
            Button_Color.Image = (Image)resources.GetObject("Button_Color.Image");
            Button_Color.Location = new Point(685, 82);
            Button_Color.Name = "Button_Color";
            Button_Color.Size = new Size(58, 58);
            Button_Color.TabIndex = 1;
            Button_Color.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(Button_Color, "Color Picker");
            Button_Color.UseVisualStyleBackColor = false;
            Button_Color.Click += Button_Color_Click;
            // 
            // PictureBox_OutlineColor
            // 
            PictureBox_OutlineColor.Anchor = AnchorStyles.None;
            PictureBox_OutlineColor.AutoSize = true;
            PictureBox_OutlineColor.BackColor = Color.Black;
            PictureBox_OutlineColor.Enabled = false;
            PictureBox_OutlineColor.FlatAppearance.BorderSize = 3;
            PictureBox_OutlineColor.Location = new Point(685, 14);
            PictureBox_OutlineColor.Margin = new Padding(4);
            PictureBox_OutlineColor.Name = "PictureBox_OutlineColor";
            PictureBox_OutlineColor.Size = new Size(60, 58);
            PictureBox_OutlineColor.TabIndex = 0;
            toolTip1.SetToolTip(PictureBox_OutlineColor, "Active Color");
            PictureBox_OutlineColor.UseVisualStyleBackColor = false;
            // 
            // PictureBox
            // 
            PictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PictureBox.BackColor = Color.White;
            PictureBox.Location = new Point(-2, 173);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(1161, 531);
            PictureBox.TabIndex = 2;
            PictureBox.TabStop = false;
            PictureBox.Paint += PictureBox_Paint;
            PictureBox.MouseDoubleClick += PictureBox_MouseDoubleClick;
            PictureBox.MouseDown += PictureBox_MouseDown;
            PictureBox.MouseEnter += PictureBox_MouseEnter;
            PictureBox.MouseLeave += PictureBox_MouseLeave;
            PictureBox.MouseMove += PictureBox_MouseMove;
            PictureBox.MouseUp += PictureBox_MouseUp;
            // 
            // DrawingApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 704);
            Controls.Add(PictureBox);
            Controls.Add(Panel);
            Controls.Add(MenuStrip);
            MainMenuStrip = MenuStrip;
            Name = "DrawingApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Drawing App ver 0.3";
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
            ShapesScrollMenu.ResumeLayout(false);
            ShapesScrollMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem FileMenu;
        private ToolStripMenuItem SaveMenu;
        private ToolStripMenuItem OpenMenu;
        private Panel Panel;
        private PictureBox PictureBox;
        private Button Button_Color;
        private Button PictureBox_OutlineColor;
        private ToolStripMenuItem ToolMenu;
        private ToolStripMenuItem FillBucketMenu;
        private ToolStripMenuItem RotateReverseMenu;
        private Button Button_Fill;
        private Button Button_White;
        private Button Button_Black;
        private Button Button_BrownTwo;
        private Button Button_GreenTwo;
        private Button Button_BrownOne;
        private Button Button_GreenOne;
        private Button Button_OrangeTwo;
        private Button Button_WhiteTwo;
        private Button Button_WhiteOne;
        private Button Button_BlackTwo;
        private Button Button_BlackOne;
        private Button Button_OrangeOne;
        private Button Button_Brown;
        private Button Button_Green;
        private Button Button_Orange;
        private Button Button_Red;
        private Button Button_PurpleTwo;
        private Button Button_PurpleOne;
        private Button Button_BlueTwo;
        private Button Button_BlueOne;
        private Button Button_YellowTwo;
        private Button Button_YellowOne;
        private Button Button_Blue;
        private Button Button_Purple;
        private Button Button_Yellow;
        private Button Button_RedTwo;
        private Button Button_RedOne;
        private FlowLayoutPanel ShapesScrollMenu;
        private Button Button_Line;
        private Panel panel1;
        private Panel panel2;
        private Button Button_Circle;
        private Button Button_Rectangle;
        private Button Button_Triangle;
        private ToolTip toolTip1;
        private Button Button_Delete;
        private Label Label_Tools;
        private Label Label_Colors;
        private Label Label_Shapes;
        private ToolStripMenuItem RotateMenu;
        private ToolStripMenuItem DeleteMenu;
        private ToolStripMenuItem ShapesMenu;
        private ToolStripMenuItem LineMenu;
        private ToolStripMenuItem CircleMenu;
        private ToolStripMenuItem RectangleMenu;
        private ToolStripMenuItem TriangleMenu;
        private Button Button_Move;
        private Button Button_Clear;
        private Label Label_Width;
        private TextBox TextBox_Width;
        private Panel panel4;
        private ToolStripMenuItem MoveMenu;
        private ToolStripMenuItem ClearMenu;
        private ToolStripMenuItem ColorPickerMenu;
        private ToolStripMenuItem HelpMenu;
        private ToolStripMenuItem PointerMenu;
        private Button Button_Pointer;
        private ToolStripMenuItem UndoMenu;
        private ToolStripMenuItem RedoMenu;
        private Panel panel5;
        private Panel panel3;
    }
}