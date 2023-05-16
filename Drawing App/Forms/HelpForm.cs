namespace Drawing_App.Forms
{
    public partial class HelpForm : Form
    {
        #region Load
        //--------------------------------- Load ---------------------------------------
        public HelpForm()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            LoadIcon();
        }
        //------------------------------------------------------------------------------
        #endregion

        #region Buttons
        //--------------------------------- Buttons ------------------------------------
        private void ButtonToolsPanel_Click(object sender, EventArgs e)
        {
            ToolsPanel(true);

            ShapesPanel(false);
            WidthPanel(false);
            ColorPanel(false);
            Shortcuts(false);
            Draw(false);
            OpenProperties(false);
            HowToMenus(false);
        }

        private void ButtonShapesPanel_Click(object sender, EventArgs e)
        {
            ShapesPanel(true);

            ToolsPanel(false);
            WidthPanel(false);
            ColorPanel(false);
            Shortcuts(false);
            Draw(false);
            OpenProperties(false);
            HowToMenus(false);
        }
        private void ButtonWidthPanel_Click(object sender, EventArgs e)
        {
            WidthPanel(true);

            ToolsPanel(false);
            ShapesPanel(false);
            ColorPanel(false);
            Shortcuts(false);
            Draw(false);
            OpenProperties(false);
            HowToMenus(false);
        }
        private void ButtonColorPanel_Click(object sender, EventArgs e)
        {
            ColorPanel(true);

            ToolsPanel(false);
            ShapesPanel(false);
            WidthPanel(false);
            Shortcuts(false);
            Draw(false);
            OpenProperties(false);
            HowToMenus(false);
        }
        private void ButtonShortcuts_Click(object sender, EventArgs e)
        {
            Shortcuts(true);

            ToolsPanel(false);
            ShapesPanel(false);
            WidthPanel(false);
            ColorPanel(false);
            Draw(false);
            OpenProperties(false);
            HowToMenus(false);
        }
        private void ButtonDraw_Click(object sender, EventArgs e)
        {
            Draw(true);

            ToolsPanel(false);
            ShapesPanel(false);
            WidthPanel(false);
            ColorPanel(false);
            Shortcuts(false);
            OpenProperties(false);
            HowToMenus(false);
        }
        private void ButtonOpenProperties_Click(object sender, EventArgs e)
        {
            OpenProperties(true);

            ToolsPanel(false);
            ShapesPanel(false);
            WidthPanel(false);
            ColorPanel(false);
            Shortcuts(false);
            Draw(false);
            HowToMenus(false);
        }
        private void ButtonHowToMenus_Click(object sender, EventArgs e)
        {
            HowToMenus(true);

            ToolsPanel(false);
            ShapesPanel(false);
            WidthPanel(false);
            ColorPanel(false);
            Shortcuts(false);
            Draw(false);
            OpenProperties(false);
        }
        //------------------------------------------------------------------------------
        #endregion

        #region Methods
        //---------------------------------- Methods -----------------------------------
        private void ToolsPanel(bool status)
        {
            LabelToolsPanel.Visible = status;

            LabelFillBucketName.Visible = status;
            LabelFillBucket.Visible = status;

            LabelMoveName.Visible = status;
            LabelMove.Visible = status;

            LabelDeleteName.Visible = status;
            LabelDelete.Visible = status;

            LabelPointerName.Visible = status;
            LabelPointer.Visible = status;

            LabelClearName.Visible = status;
            LabelClear.Visible = status;
        }
        private void ShapesPanel(bool status)
        {
            LabelShapesPanel.Visible = status;

            LabelLineName.Visible = status;
            LabelLine.Visible = status;

            LabelCircleName.Visible = status;
            LabelCircle.Visible = status;

            LabelRectangleName.Visible = status;
            LabelRectangle.Visible = status;

            LabelTriangleName.Visible = status;
            LabelTriangle.Visible = status;
        }
        private void WidthPanel(bool status)
        {
            LabelWidthPanel.Visible = status;
            LabelWidthName.Visible = status;
            LabelWidth.Visible = status;
        }
        private void ColorPanel(bool status)
        {
            LabelColorPanel.Visible = status;

            LabelActiveColorName.Visible = status;
            LabelActiveColor.Visible = status;

            LabelPremadeColorsName.Visible = status;
            LabelPremadeColors.Visible = status;

            LabelColorPaletteName.Visible = status;
            LabelColorPalette.Visible = status;
        }
        private void Shortcuts(bool status)
        {
            LabelShortcuts.Visible = status;

            LabelSaveShort.Visible = status;
            LabelSave.Visible = status;

            LabelOpenShort.Visible = status;
            LabelOpen.Visible = status;

            LabelColorPickerShort.Visible = status;
            LabelColorPicker.Visible = status;

            LabelFillShort.Visible = status;
            LabelFill.Visible = status;

            LabelDelShort.Visible = status;
            LabelDel.Visible = status;

            LabelMoveShort.Visible = status;
            LabelMov.Visible = status;

            LabelPointerShort.Visible = status;
            LabelPoint.Visible = status;

            LabelClearShort.Visible = status;
            LabelClea.Visible = status;

            LabelLineShort.Visible = status;
            LabelLin.Visible = status;

            LabelCircleShort.Visible = status;
            LabelCircl.Visible = status;

            LabelRectangleShort.Visible = status;
            LabelRectangl.Visible = status;

            LabelTriangleShort.Visible = status;
            LabelTriangl.Visible = status;

            LabelDoubleClickShort.Visible = status;
            LabelDoubleClick.Visible = status;

            LabelUndoShort.Visible = status;
            LabelUndo.Visible = status;

            LabelRedoShort.Visible = status;
            LabelRedo.Visible = status;
        }
        private void Draw(bool status)
        {
            LabelHowToDraw.Visible = status;
            LabelHowDraw.Visible = status;
        }
        private void OpenProperties(bool status)
        {
            LabelOpenShapeProperties.Visible = status;
            LabelShapeProperties.Visible = status;
        }
        private void HowToMenus(bool status)
        {
            LabelHowToUseMenus.Visible = status;
            LabelUseMenus.Visible = status;

            LabelUndoMenu.Visible = status;
            LabelUndoText.Visible = status;

            LabelRedoMenu.Visible = status;
            LabelRedoText.Visible = status;

            LabelOpenMenu.Visible = status;
            LabelopenMenuText.Visible = status;

            LabelSaveMenu.Visible = status;
            LabelSaveMenuText.Visible = status;
        }
        private void LoadIcon()
        {
            string iconPath = Path.Combine(Application.StartupPath, "iconHelp.ico");

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
