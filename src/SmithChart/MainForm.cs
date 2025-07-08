using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;


namespace SmithChart
{
    public partial class MainForm : Form
    {
        #region Fields
        private HelpForm     _HelpForm;
        private SettingsForm _SettingsForm;
        #endregion

        #region Constructors
        public MainForm()
        {
            InitializeComponent();

            RValue.ContextMenu   = new ContextMenu();
            GValue.ContextMenu   = new ContextMenu();
            XValue.ContextMenu   = new ContextMenu();
            BValue.ContextMenu   = new ContextMenu();
            ZValue.ContextMenu   = new ContextMenu();
            YValue.ContextMenu   = new ContextMenu();
            Z0Value.ContextMenu  = new ContextMenu();
            Y0Value.ContextMenu  = new ContextMenu();
            RRValue.ContextMenu  = new ContextMenu();
            IRValue.ContextMenu  = new ContextMenu();
            RhoValue.ContextMenu = new ContextMenu();
            PhiValue.ContextMenu = new ContextMenu();
            KBValue.ContextMenu  = new ContextMenu();
            KSValue.ContextMenu  = new ContextMenu();
            DLValue.ContextMenu  = new ContextMenu();
            DL2Value.ContextMenu = new ContextMenu();

            Chart.RhoChanged += ChartChange;
            Chart.R          = 1.0;

            _HelpForm     = new HelpForm();
            _SettingsForm = new SettingsForm();
        }
        #endregion

        #region Handlers
        private void ValueBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (e.KeyChar == '/' || e.KeyChar == 'ю')
            {
                e.KeyChar = '.';
            }

            if (e.KeyChar == '.')
            {
                e.Handled = tb.Text.IndexOf('.') != -1;
            }
            else if (e.KeyChar == '-' && (tb == XValue || tb == BValue))
            {
                e.Handled = tb.Text.IndexOf('-') != -1;
            }
            else if (e.KeyChar == '\b')
            {
                if (tb.TextLength == 1 || tb.SelectionLength == tb.TextLength)
                {
                    
                    tb.Text            = "0.0";
                    tb.SelectionLength = 0;
                    tb.SelectionStart  = 3;
                    e.Handled          = true;
                }
            }
            else
            {
                e.Handled = !Char.IsDigit(e.KeyChar);
            }
        }

        private void XBTexChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            
            int pos = tb.Text.IndexOf('-');

            if (pos > 0)
            {
                tb.Text = '-' + tb.Text.Remove(pos, 1);
            }
        }

        private void RKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Chart.R = RValue.Text.Parse() / Z0Value.Text.Parse();
            }

            e.Handled = true;
        }

        private void GKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Chart.R = Y0Value.Text.Parse() / GValue.Text.Parse();
            }

            e.Handled = true;
        }

        private void XKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Chart.X = XValue.Text.Parse() / Z0Value.Text.Parse();
            }

            e.Handled = true;
        }

        private void BKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Chart.X = Y0Value.Text.Parse() / BValue.Text.Parse();
            }

            e.Handled = true;
        }

        private void Z0KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double Z0 = Z0Value.Text.Parse();

                if (Z0 == 0.0)
                {
                    Z0Value.Text = "1.0";
                    Y0Value.Text = "1.0";

                    SmithChart.ShowError("0 - Недопустимое значение для волнового сопротивления.");
                }
                else
                {
                    Y0Value.Text = (1.0 / Z0).Format(4);
                }
            }

            e.Handled = true;
        }

        private void Y0KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double Y0 = Y0Value.Text.Parse();

                if (Y0 == 0.0)
                {
                    Z0Value.Text = "1.0";
                    Y0Value.Text = "1.0";

                    SmithChart.ShowError("0 - Недопустимое значение для волновой проводимости.");
                }
                else
                {
                    Z0Value.Text = (1.0 / Y0).Format(4); 
                }
            }

            e.Handled = true;
        }

        private void RhoKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Chart.Rho = RhoValue.Text.Parse();
            }

            e.Handled = true;
        }

        private void PhiKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Chart.ArgRho = PhiValue.Text.Parse();
            }

            e.Handled = true; 
        }

        private void KBKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Chart.Ktw = KBValue.Text.Parse();
            }

            e.Handled = true;
        }

        private void KSKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (KSValue.Text.IndexOf('∞') == -1)
                {
                    Chart.Ksw = KSValue.Text.Parse();
                }
                else
                {
                    Chart.Ktw = 0.0;
                }
            }

            e.Handled = true;
        }

        private void DLKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Chart.Dxl = DLValue.Text.Parse();
            }

            e.Handled = true;
        }

        private void ChartChange(object sender, EventArgs e)
        {
            double Z0     = Z0Value.Text.Parse();
            double Y0     = Y0Value.Text.Parse();

            RValue.Text   = (Chart.R * Z0).Format(4);
            XValue.Text   = (Chart.X * Z0).Format(4);

            GValue.Text   = (Chart.G * Y0).Format(4);
            BValue.Text   = (Chart.B * Y0).Format(4);

            ZValue.Text   = (Chart.Z * Z0).Format(4);
            YValue.Text   = (Chart.Y * Y0).Format(4);

            RRValue.Text  = Chart.ReRho.Format(4);
            IRValue.Text  = Chart.ImRho.Format(4);
            RhoValue.Text = Chart.Rho.Format(4);
            PhiValue.Text = Chart.ArgRho.Format(4) + " (" + (180 / Math.PI * Chart.ArgRho).Format(2) + "°)";

            KBValue.Text  = Chart.Ktw.Format(4);
            KSValue.Text  = Chart.Ksw.Format(4);

            DLValue.Text  = Chart.Dxl.Format(4);
            DL2Value.Text = "(" + (0.5 - Chart.Dxl).Format(4) + ")";
        }

        private void ScreenShotClick(object sender, MouseEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title          = "Сохранить как";
            dialog.AddExtension   = true;
            dialog.DefaultExt     = "png";
            dialog.Filter         = "Рисунок PNG (*.png)|*.png|" +
                                    "Точечный рисунок (*.bmp)|*.bmp|" +
                                    "Изображение в формате JPEG (*.jpeg)|*.jpeg|" +
                                    "Файл GIF (*.gif)|*.gif";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ImageFormat format;
                switch (dialog.FilterIndex)
                {
                    case 2:  format = ImageFormat.Bmp;  break;
                    case 3:  format = ImageFormat.Jpeg; break;
                    case 4:  format = ImageFormat.Gif;  break;
                    default: format = ImageFormat.Png;  break;
                }

                if (e.Button == MouseButtons.Left)
                {
                    Chart.Save(dialog.FileName, format);
                }
                else if(e.Button == MouseButtons.Right)
                {
                    FormBorderStyle = FormBorderStyle.None;

                    using (Bitmap saved = new Bitmap(ClientSize.Width, ClientSize.Height))
                    {
                        DrawToBitmap(saved, new Rectangle(0, 0, ClientSize.Width, ClientSize.Height));
                        saved.Save(dialog.FileName, format);
                    }

                    FormBorderStyle = FormBorderStyle.Sizable;
                }
            }
        }

        private void CallHelpClick(object sender, EventArgs e) => _HelpForm.ShowDialog();

        private void SettingsClick(object sender, EventArgs e)
        {
            _SettingsForm.LinesWidth = Chart.LinesWidth;
            _SettingsForm.ScaleStep  = Chart.ScaleStep;
            _SettingsForm.InfoEnable = Chart.InfoEnable;

            _SettingsForm.BackColor  = Chart.BackColor;
            _SettingsForm.ForeColor  = Chart.ForeColor;
            _SettingsForm.RhoColor   = Chart.RhoColor;
            _SettingsForm.RColor     = Chart.RColor;
            _SettingsForm.XColor     = Chart.XColor;
            _SettingsForm.KColor     = Chart.KColor;
            _SettingsForm.DxlColor   = Chart.DxlColor;

            if (_SettingsForm.ShowDialog() == DialogResult.OK)
            {
                Chart.LinesWidth = _SettingsForm.LinesWidth;
                Chart.ScaleStep  = _SettingsForm.ScaleStep;
                Chart.InfoEnable = _SettingsForm.InfoEnable;

                Chart.BackColor  = _SettingsForm.BackColor;
                Chart.ForeColor  = _SettingsForm.ForeColor;
                Chart.RhoColor   = _SettingsForm.RhoColor;
                Chart.RColor     = _SettingsForm.RColor;
                Chart.XColor     = _SettingsForm.XColor;
                Chart.KColor     = _SettingsForm.KColor;
                Chart.DxlColor   = _SettingsForm.DxlColor;

                RValue.ForeColor   = Chart.RColor;
                GValue.ForeColor   = Chart.RColor;
                XValue.ForeColor   = Chart.XColor;
                BValue.ForeColor   = Chart.XColor;
                ZValue.ForeColor   = Color.FromArgb(0xFF, Chart.RColor.R | Chart.XColor.R, Chart.RColor.G | Chart.XColor.G, Chart.RColor.B | Chart.XColor.B);
                YValue.ForeColor   = ZValue.ForeColor;
                RRValue.ForeColor  = Chart.RhoColor;
                IRValue.ForeColor  = Chart.RhoColor;
                RhoValue.ForeColor = Chart.RhoColor;
                PhiValue.ForeColor = Chart.RhoColor;
                KBValue.ForeColor  = Chart.KColor;
                KSValue.ForeColor  = Chart.KColor;
                DLValue.ForeColor  = Chart.DxlColor;
                DL2Value.ForeColor = Chart.DxlColor;
            }
        }
        #endregion
    }
}