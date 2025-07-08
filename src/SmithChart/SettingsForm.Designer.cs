namespace SmithChart
{
    partial class SettingsForm
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
            this.Colors = new System.Windows.Forms.GroupBox();
            this.ColorK = new System.Windows.Forms.LinkLabel();
            this.ColorFore = new System.Windows.Forms.LinkLabel();
            this.ColorBack = new System.Windows.Forms.LinkLabel();
            this.ColorDxl = new System.Windows.Forms.LinkLabel();
            this.ColorRho = new System.Windows.Forms.LinkLabel();
            this.ColorX = new System.Windows.Forms.LinkLabel();
            this.ColorR = new System.Windows.Forms.LinkLabel();
            this.LinesWidthDescription = new System.Windows.Forms.Label();
            this.WidthLines = new System.Windows.Forms.NumericUpDown();
            this.StepScale = new System.Windows.Forms.NumericUpDown();
            this.ScaleStepDescription = new System.Windows.Forms.Label();
            this.AllSettings = new System.Windows.Forms.GroupBox();
            this.InfoEnabled = new System.Windows.Forms.CheckBox();
            this.Accept = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Colors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepScale)).BeginInit();
            this.AllSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // Colors
            // 
            this.Colors.Controls.Add(this.ColorK);
            this.Colors.Controls.Add(this.ColorFore);
            this.Colors.Controls.Add(this.ColorBack);
            this.Colors.Controls.Add(this.ColorDxl);
            this.Colors.Controls.Add(this.ColorRho);
            this.Colors.Controls.Add(this.ColorX);
            this.Colors.Controls.Add(this.ColorR);
            this.Colors.Location = new System.Drawing.Point(12, 12);
            this.Colors.Name = "Colors";
            this.Colors.Size = new System.Drawing.Size(224, 76);
            this.Colors.TabIndex = 0;
            this.Colors.TabStop = false;
            this.Colors.Text = "Цвета";
            // 
            // ColorK
            // 
            this.ColorK.AutoSize = true;
            this.ColorK.LinkColor = System.Drawing.Color.Orange;
            this.ColorK.Location = new System.Drawing.Point(140, 25);
            this.ColorK.Name = "ColorK";
            this.ColorK.Size = new System.Drawing.Size(41, 13);
            this.ColorK.TabIndex = 6;
            this.ColorK.TabStop = true;
            this.ColorK.Text = "K Color";
            this.ColorK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ColorsClick);
            // 
            // ColorFore
            // 
            this.ColorFore.AutoSize = true;
            this.ColorFore.LinkColor = System.Drawing.Color.White;
            this.ColorFore.Location = new System.Drawing.Point(79, 25);
            this.ColorFore.Name = "ColorFore";
            this.ColorFore.Size = new System.Drawing.Size(55, 13);
            this.ColorFore.TabIndex = 5;
            this.ColorFore.TabStop = true;
            this.ColorFore.Text = "Fore Color";
            this.ColorFore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ColorsClick);
            // 
            // ColorBack
            // 
            this.ColorBack.AutoSize = true;
            this.ColorBack.LinkColor = System.Drawing.Color.Black;
            this.ColorBack.Location = new System.Drawing.Point(14, 25);
            this.ColorBack.Name = "ColorBack";
            this.ColorBack.Size = new System.Drawing.Size(59, 13);
            this.ColorBack.TabIndex = 4;
            this.ColorBack.TabStop = true;
            this.ColorBack.Text = "Back Color";
            this.ColorBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ColorsClick);
            // 
            // ColorDxl
            // 
            this.ColorDxl.AutoSize = true;
            this.ColorDxl.LinkColor = System.Drawing.Color.Purple;
            this.ColorDxl.Location = new System.Drawing.Point(155, 48);
            this.ColorDxl.Name = "ColorDxl";
            this.ColorDxl.Size = new System.Drawing.Size(56, 13);
            this.ColorDxl.TabIndex = 3;
            this.ColorDxl.TabStop = true;
            this.ColorDxl.Text = "Δx/λ Color";
            this.ColorDxl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ColorsClick);
            // 
            // ColorRho
            // 
            this.ColorRho.AutoSize = true;
            this.ColorRho.Location = new System.Drawing.Point(109, 48);
            this.ColorRho.Name = "ColorRho";
            this.ColorRho.Size = new System.Drawing.Size(40, 13);
            this.ColorRho.TabIndex = 2;
            this.ColorRho.TabStop = true;
            this.ColorRho.Text = "ρ Color";
            this.ColorRho.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ColorsClick);
            // 
            // ColorX
            // 
            this.ColorX.AutoSize = true;
            this.ColorX.LinkColor = System.Drawing.Color.Green;
            this.ColorX.Location = new System.Drawing.Point(62, 48);
            this.ColorX.Name = "ColorX";
            this.ColorX.Size = new System.Drawing.Size(41, 13);
            this.ColorX.TabIndex = 1;
            this.ColorX.TabStop = true;
            this.ColorX.Text = "X Color";
            this.ColorX.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ColorsClick);
            // 
            // ColorR
            // 
            this.ColorR.AutoSize = true;
            this.ColorR.LinkColor = System.Drawing.Color.Red;
            this.ColorR.Location = new System.Drawing.Point(14, 48);
            this.ColorR.Name = "ColorR";
            this.ColorR.Size = new System.Drawing.Size(42, 13);
            this.ColorR.TabIndex = 0;
            this.ColorR.TabStop = true;
            this.ColorR.Text = "R Color";
            this.ColorR.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ColorsClick);
            // 
            // LinesWidthDescription
            // 
            this.LinesWidthDescription.AutoSize = true;
            this.LinesWidthDescription.Location = new System.Drawing.Point(25, 19);
            this.LinesWidthDescription.Name = "LinesWidthDescription";
            this.LinesWidthDescription.Size = new System.Drawing.Size(89, 13);
            this.LinesWidthDescription.TabIndex = 1;
            this.LinesWidthDescription.Text = "Толщина линий:";
            // 
            // WidthLines
            // 
            this.WidthLines.Location = new System.Drawing.Point(154, 17);
            this.WidthLines.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.WidthLines.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthLines.Name = "WidthLines";
            this.WidthLines.Size = new System.Drawing.Size(39, 20);
            this.WidthLines.TabIndex = 2;
            this.WidthLines.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // StepScale
            // 
            this.StepScale.Location = new System.Drawing.Point(154, 43);
            this.StepScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StepScale.Name = "StepScale";
            this.StepScale.Size = new System.Drawing.Size(39, 20);
            this.StepScale.TabIndex = 3;
            this.StepScale.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // ScaleStepDescription
            // 
            this.ScaleStepDescription.AutoSize = true;
            this.ScaleStepDescription.Location = new System.Drawing.Point(25, 45);
            this.ScaleStepDescription.Name = "ScaleStepDescription";
            this.ScaleStepDescription.Size = new System.Drawing.Size(126, 13);
            this.ScaleStepDescription.TabIndex = 4;
            this.ScaleStepDescription.Text = "Шаг масштабирования:";
            // 
            // AllSettings
            // 
            this.AllSettings.Controls.Add(this.InfoEnabled);
            this.AllSettings.Controls.Add(this.StepScale);
            this.AllSettings.Controls.Add(this.ScaleStepDescription);
            this.AllSettings.Controls.Add(this.LinesWidthDescription);
            this.AllSettings.Controls.Add(this.WidthLines);
            this.AllSettings.Location = new System.Drawing.Point(12, 94);
            this.AllSettings.Name = "AllSettings";
            this.AllSettings.Size = new System.Drawing.Size(224, 109);
            this.AllSettings.TabIndex = 5;
            this.AllSettings.TabStop = false;
            // 
            // InfoEnabled
            // 
            this.InfoEnabled.Location = new System.Drawing.Point(28, 68);
            this.InfoEnabled.Name = "InfoEnabled";
            this.InfoEnabled.Size = new System.Drawing.Size(165, 30);
            this.InfoEnabled.TabIndex = 5;
            this.InfoEnabled.Text = "Отображать масштаб и смещение";
            this.InfoEnabled.UseVisualStyleBackColor = true;
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(161, 209);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 6;
            this.Accept.Text = "Применить";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.AcceptClick);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(80, 209);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.CancelClick);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 242);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.AllSettings);
            this.Controls.Add(this.Colors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.Colors.ResumeLayout(false);
            this.Colors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepScale)).EndInit();
            this.AllSettings.ResumeLayout(false);
            this.AllSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Colors;
        private System.Windows.Forms.LinkLabel ColorX;
        private System.Windows.Forms.LinkLabel ColorR;
        private System.Windows.Forms.LinkLabel ColorFore;
        private System.Windows.Forms.LinkLabel ColorBack;
        private System.Windows.Forms.LinkLabel ColorDxl;
        private System.Windows.Forms.LinkLabel ColorRho;
        private System.Windows.Forms.LinkLabel ColorK;
        private System.Windows.Forms.Label LinesWidthDescription;
        private System.Windows.Forms.NumericUpDown WidthLines;
        private System.Windows.Forms.NumericUpDown StepScale;
        private System.Windows.Forms.Label ScaleStepDescription;
        private System.Windows.Forms.GroupBox AllSettings;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.CheckBox InfoEnabled;
    }
}