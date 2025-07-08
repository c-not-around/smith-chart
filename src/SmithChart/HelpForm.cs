using System;
using System.Drawing;
using System.Windows.Forms;


namespace SmithChart
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();

            ScrollBox.AutoScroll               = false;
            ScrollBox.HorizontalScroll.Enabled = false;
            ScrollBox.HorizontalScroll.Visible = false;
            ScrollBox.HorizontalScroll.Maximum = 0;
            ScrollBox.VerticalScroll.Enabled   = true;
            ScrollBox.VerticalScroll.Visible   = true;
            ScrollBox.AutoScroll               = true;

            Size size  = HelpText.Image.Size;
            int  width = size.Width + (ClientSize.Width - HelpText.Size.Width);
            
            HelpText.Size   = size;
            ScrollBox.Width = width;
            ClientSize      = new Size(width, ClientSize.Height);
            MinimumSize     = new Size(Size.Width, Size.Height);
            MaximumSize     = new Size(Size.Width, 9999);
        }

        private void OkButtonClick(object sender, EventArgs e) => Hide();
    }
}