using Drawing_App.Shapes;
using Drawing_App.Shapes.Shapes;

namespace Drawing_App.Forms
{
    public partial class ShapeProperties : Form
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ButtonConvert = new Button();
            ButtonOK = new Button();
            ButtonCancel = new Button();
            LabelHeight = new Label();
            LabelWidth = new Label();
            LabelX = new Label();
            LabelY = new Label();
            TextBoxHeight = new TextBox();
            TextBoxWidth = new TextBox();
            TextBoxX = new TextBox();
            TextBoxY = new TextBox();
            LabelPerimeter = new Label();
            LabelArea = new Label();
            TextBoxArea = new TextBox();
            TextBoxPerimeter = new TextBox();
            LabelFillColor = new Label();
            LabelOutlineColor = new Label();
            TextBoxOutlineWidth = new TextBox();
            LabelOutlineWidth = new Label();
            ButtonOutlineColor = new Button();
            ButtonFillColor = new Button();
            SuspendLayout();
            // 
            // ButtonConvert
            // 
            ButtonConvert.Anchor = AnchorStyles.None;
            ButtonConvert.Location = new Point(12, 316);
            ButtonConvert.Name = "ButtonConvert";
            ButtonConvert.Size = new Size(114, 29);
            ButtonConvert.TabIndex = 0;
            ButtonConvert.Text = "To cantimeters";
            ButtonConvert.UseVisualStyleBackColor = true;
            ButtonConvert.Click += ButtonConvert_Click;
            // 
            // ButtonOK
            // 
            ButtonOK.Anchor = AnchorStyles.None;
            ButtonOK.Location = new Point(442, 316);
            ButtonOK.Name = "ButtonOK";
            ButtonOK.Size = new Size(83, 29);
            ButtonOK.TabIndex = 1;
            ButtonOK.Text = "OK";
            ButtonOK.UseVisualStyleBackColor = true;
            ButtonOK.Click += ButtonOK_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Anchor = AnchorStyles.None;
            ButtonCancel.Location = new Point(353, 316);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(83, 29);
            ButtonCancel.TabIndex = 2;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // LabelHeight
            // 
            LabelHeight.Anchor = AnchorStyles.None;
            LabelHeight.AutoSize = true;
            LabelHeight.Location = new Point(12, 9);
            LabelHeight.Name = "LabelHeight";
            LabelHeight.Size = new Size(54, 20);
            LabelHeight.TabIndex = 3;
            LabelHeight.Text = "Height";
            LabelHeight.Visible = false;
            // 
            // LabelWidth
            // 
            LabelWidth.Anchor = AnchorStyles.None;
            LabelWidth.AutoSize = true;
            LabelWidth.Location = new Point(12, 74);
            LabelWidth.Name = "LabelWidth";
            LabelWidth.Size = new Size(49, 20);
            LabelWidth.TabIndex = 4;
            LabelWidth.Text = "Width";
            LabelWidth.Visible = false;
            // 
            // LabelX
            // 
            LabelX.Anchor = AnchorStyles.None;
            LabelX.AutoSize = true;
            LabelX.Location = new Point(12, 139);
            LabelX.Name = "LabelX";
            LabelX.Size = new Size(18, 20);
            LabelX.TabIndex = 22;
            LabelX.Text = "X";
            LabelX.Visible = false;
            // 
            // LabelY
            // 
            LabelY.Anchor = AnchorStyles.None;
            LabelY.AutoSize = true;
            LabelY.Location = new Point(12, 204);
            LabelY.Name = "LabelY";
            LabelY.Size = new Size(17, 20);
            LabelY.TabIndex = 26;
            LabelY.Text = "Y";
            LabelY.Visible = false;
            // 
            // TextBoxHeight
            // 
            TextBoxHeight.Anchor = AnchorStyles.None;
            TextBoxHeight.Location = new Point(12, 32);
            TextBoxHeight.Name = "TextBoxHeight";
            TextBoxHeight.Size = new Size(125, 27);
            TextBoxHeight.TabIndex = 12;
            TextBoxHeight.Visible = false;
            // 
            // TextBoxWidth
            // 
            TextBoxWidth.Anchor = AnchorStyles.None;
            TextBoxWidth.Location = new Point(12, 97);
            TextBoxWidth.Name = "TextBoxWidth";
            TextBoxWidth.Size = new Size(125, 27);
            TextBoxWidth.TabIndex = 13;
            TextBoxWidth.Visible = false;
            // 
            // TextBoxX
            // 
            TextBoxX.Anchor = AnchorStyles.None;
            TextBoxX.Location = new Point(12, 162);
            TextBoxX.Name = "TextBoxX";
            TextBoxX.Size = new Size(125, 27);
            TextBoxX.TabIndex = 24;
            TextBoxX.Visible = false;
            // 
            // TextBoxY
            // 
            TextBoxY.Anchor = AnchorStyles.None;
            TextBoxY.Location = new Point(12, 227);
            TextBoxY.Name = "TextBoxY";
            TextBoxY.Size = new Size(125, 27);
            TextBoxY.TabIndex = 28;
            TextBoxY.Visible = false;
            // 
            // LabelPerimeter
            // 
            LabelPerimeter.Anchor = AnchorStyles.None;
            LabelPerimeter.AutoSize = true;
            LabelPerimeter.Location = new Point(207, 9);
            LabelPerimeter.Name = "LabelPerimeter";
            LabelPerimeter.Size = new Size(72, 20);
            LabelPerimeter.TabIndex = 29;
            LabelPerimeter.Text = "Perimeter";
            // 
            // LabelArea
            // 
            LabelArea.Anchor = AnchorStyles.None;
            LabelArea.AutoSize = true;
            LabelArea.Location = new Point(400, 9);
            LabelArea.Name = "LabelArea";
            LabelArea.Size = new Size(40, 20);
            LabelArea.TabIndex = 33;
            LabelArea.Text = "Area";
            // 
            // TextBoxArea
            // 
            TextBoxArea.Anchor = AnchorStyles.None;
            TextBoxArea.Location = new Point(400, 32);
            TextBoxArea.Name = "TextBoxArea";
            TextBoxArea.ReadOnly = true;
            TextBoxArea.Size = new Size(125, 27);
            TextBoxArea.TabIndex = 34;
            // 
            // TextBoxPerimeter
            // 
            TextBoxPerimeter.Anchor = AnchorStyles.None;
            TextBoxPerimeter.Location = new Point(207, 32);
            TextBoxPerimeter.Name = "TextBoxPerimeter";
            TextBoxPerimeter.ReadOnly = true;
            TextBoxPerimeter.Size = new Size(125, 27);
            TextBoxPerimeter.TabIndex = 30;
            // 
            // LabelFillColor
            // 
            LabelFillColor.Anchor = AnchorStyles.None;
            LabelFillColor.AutoSize = true;
            LabelFillColor.Location = new Point(207, 139);
            LabelFillColor.Name = "LabelFillColor";
            LabelFillColor.Size = new Size(66, 20);
            LabelFillColor.TabIndex = 37;
            LabelFillColor.Text = "Fill color";
            // 
            // LabelOutlineColor
            // 
            LabelOutlineColor.Anchor = AnchorStyles.None;
            LabelOutlineColor.AutoSize = true;
            LabelOutlineColor.Location = new Point(207, 74);
            LabelOutlineColor.Name = "LabelOutlineColor";
            LabelOutlineColor.Size = new Size(95, 20);
            LabelOutlineColor.TabIndex = 35;
            LabelOutlineColor.Text = "Outline color";
            // 
            // TextBoxOutlineWidth
            // 
            TextBoxOutlineWidth.Anchor = AnchorStyles.None;
            TextBoxOutlineWidth.Location = new Point(400, 97);
            TextBoxOutlineWidth.Name = "TextBoxOutlineWidth";
            TextBoxOutlineWidth.Size = new Size(125, 27);
            TextBoxOutlineWidth.TabIndex = 42;
            // 
            // LabelOutlineWidth
            // 
            LabelOutlineWidth.Anchor = AnchorStyles.None;
            LabelOutlineWidth.AutoSize = true;
            LabelOutlineWidth.Location = new Point(400, 74);
            LabelOutlineWidth.Name = "LabelOutlineWidth";
            LabelOutlineWidth.Size = new Size(98, 20);
            LabelOutlineWidth.TabIndex = 41;
            LabelOutlineWidth.Text = "Outline width";
            // 
            // ButtonOutlineColor
            // 
            ButtonOutlineColor.Anchor = AnchorStyles.None;
            ButtonOutlineColor.Location = new Point(207, 97);
            ButtonOutlineColor.Name = "ButtonOutlineColor";
            ButtonOutlineColor.Size = new Size(125, 29);
            ButtonOutlineColor.TabIndex = 47;
            ButtonOutlineColor.UseVisualStyleBackColor = true;
            ButtonOutlineColor.Click += ButtonRectangleOutlineColor_Click;
            // 
            // ButtonFillColor
            // 
            ButtonFillColor.Anchor = AnchorStyles.None;
            ButtonFillColor.Location = new Point(207, 162);
            ButtonFillColor.Name = "ButtonFillColor";
            ButtonFillColor.Size = new Size(125, 29);
            ButtonFillColor.TabIndex = 48;
            ButtonFillColor.UseVisualStyleBackColor = true;
            ButtonFillColor.Click += ButtonRectangleFillColor_Click;
            // 
            // ShapeProperties
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 357);
            Controls.Add(ButtonFillColor);
            Controls.Add(ButtonOutlineColor);
            Controls.Add(TextBoxOutlineWidth);
            Controls.Add(LabelOutlineWidth);
            Controls.Add(LabelFillColor);
            Controls.Add(LabelOutlineColor);
            Controls.Add(TextBoxArea);
            Controls.Add(LabelArea);
            Controls.Add(TextBoxPerimeter);
            Controls.Add(LabelPerimeter);
            Controls.Add(TextBoxY);
            Controls.Add(LabelY);
            Controls.Add(TextBoxX);
            Controls.Add(LabelX);
            Controls.Add(TextBoxWidth);
            Controls.Add(TextBoxHeight);
            Controls.Add(LabelWidth);
            Controls.Add(LabelHeight);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonOK);
            Controls.Add(ButtonConvert);
            Name = "ShapeProperties";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Shape Properties";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonConvert;
        private Button ButtonOK;
        private Button ButtonCancel;
        private Label LabelHeight;
        private Label LabelWidth;
        private Label LabelX;
        private Label LabelY;
        private TextBox TextBoxHeight;
        private TextBox TextBoxWidth;
        private TextBox TextBoxX;
        private TextBox TextBoxY;
        private Label LabelPerimeter;
        private Label LabelArea;
        private TextBox TextBoxArea;
        private TextBox TextBoxPerimeter;
        private Label LabelFillColor;
        private Label LabelOutlineColor;
        private TextBox TextBoxOutlineWidth;
        private Label LabelOutlineWidth;
        private Button ButtonOutlineColor;
        private Button ButtonFillColor;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}