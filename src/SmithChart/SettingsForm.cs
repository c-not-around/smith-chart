using System;
using System.Drawing;
using System.Windows.Forms;


namespace SmithChart
{
    public partial class SettingsForm : Form
    {
        #region Constructor
        public SettingsForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        public new Color BackColor
        {
            get => ColorBack.LinkColor;
            set => ColorBack.LinkColor = value;
        }

        public new Color ForeColor
        {
            get => ColorFore.LinkColor;
            set => ColorFore.LinkColor = value;
        }

        public Color RColor
        {
            get => ColorR.LinkColor;
            set => ColorR.LinkColor = value;
        }

        public Color XColor
        {
            get => ColorX.LinkColor; 
            set => ColorX.LinkColor = value;
        }

        public Color KColor
        {
            get => ColorK.LinkColor; 
            set => ColorK.LinkColor = value;
        }

        public Color RhoColor
        {
            get => ColorRho.LinkColor; 
            set => ColorRho.LinkColor = value;
        }

        public Color DxlColor
        {
            get => ColorDxl.LinkColor; 
            set => ColorDxl.LinkColor = value;
        }

        public float LinesWidth
        {
            get => (float)WidthLines.Value;
            set => WidthLines.Value = (decimal)value;
        }

        public double ScaleStep
        {
            get => 1.0 + (double)StepScale.Value / 100.0;
            set => StepScale.Value = (decimal)((value - 1.0) * 100.0);
        }

        public bool InfoEnable
        {
            get => InfoEnabled.Checked; 
            set => InfoEnabled.Checked = value;
        }
        #endregion

        #region Handlers
        private void ColorsClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel   label  = sender as LinkLabel;

            ColorDialog dialog = new ColorDialog();
            dialog.AnyColor    = true;
            dialog.Color       = label.LinkColor;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                label.LinkColor = dialog.Color;
            }
        }

        private void AcceptClick(object sender, EventArgs e) => DialogResult = DialogResult.OK;

        private void CancelClick(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
        #endregion
    }
}