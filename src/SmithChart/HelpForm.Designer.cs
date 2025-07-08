namespace SmithChart
{
    partial class HelpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.OkButton = new System.Windows.Forms.Button();
            this.HelpText = new System.Windows.Forms.PictureBox();
            this.ScrollBox = new System.Windows.Forms.Panel();
            this.Footer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.HelpText)).BeginInit();
            this.ScrollBox.SuspendLayout();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.OkButton.Location = new System.Drawing.Point(184, 15);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "ОК";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButtonClick);
            // 
            // HelpText
            // 
            this.HelpText.Image = global::SmithChart.Properties.Resources.desc;
            this.HelpText.Location = new System.Drawing.Point(0, 0);
            this.HelpText.Name = "HelpText";
            this.HelpText.Size = new System.Drawing.Size(428, 4128);
            this.HelpText.TabIndex = 0;
            this.HelpText.TabStop = false;
            // 
            // ScrollBox
            // 
            this.ScrollBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ScrollBox.BackColor = System.Drawing.Color.White;
            this.ScrollBox.Controls.Add(this.HelpText);
            this.ScrollBox.Location = new System.Drawing.Point(1, 1);
            this.ScrollBox.Name = "ScrollBox";
            this.ScrollBox.Size = new System.Drawing.Size(447, 240);
            this.ScrollBox.TabIndex = 0;
            // 
            // Footer
            // 
            this.Footer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Footer.BackColor = System.Drawing.Color.White;
            this.Footer.Controls.Add(this.OkButton);
            this.Footer.Location = new System.Drawing.Point(1, 241);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(447, 48);
            this.Footer.TabIndex = 2;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(449, 290);
            this.ControlBox = false;
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.ScrollBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Описание";
            ((System.ComponentModel.ISupportInitialize)(this.HelpText)).EndInit();
            this.ScrollBox.ResumeLayout(false);
            this.Footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.PictureBox HelpText;
        private System.Windows.Forms.Panel ScrollBox;
        private System.Windows.Forms.Panel Footer;
    }
}