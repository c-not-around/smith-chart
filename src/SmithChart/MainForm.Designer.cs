namespace SmithChart
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Values = new System.Windows.Forms.Panel();
            this.YValue = new System.Windows.Forms.TextBox();
            this.Y0Value = new System.Windows.Forms.TextBox();
            this.BValue = new System.Windows.Forms.TextBox();
            this.GValue = new System.Windows.Forms.TextBox();
            this.DL2Value = new System.Windows.Forms.TextBox();
            this.ZValue = new System.Windows.Forms.TextBox();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ScreenShot = new System.Windows.Forms.Button();
            this.CallHelp = new System.Windows.Forms.Button();
            this.DLValue = new System.Windows.Forms.TextBox();
            this.KSValue = new System.Windows.Forms.TextBox();
            this.KBValue = new System.Windows.Forms.TextBox();
            this.PhiValue = new System.Windows.Forms.TextBox();
            this.RhoValue = new System.Windows.Forms.TextBox();
            this.IRValue = new System.Windows.Forms.TextBox();
            this.RRValue = new System.Windows.Forms.TextBox();
            this.Z0Value = new System.Windows.Forms.TextBox();
            this.XValue = new System.Windows.Forms.TextBox();
            this.RValue = new System.Windows.Forms.TextBox();
            this.Descriptions = new System.Windows.Forms.PictureBox();
            this.Chart = new SmithChart();
            this.Values.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Descriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // Values
            // 
            this.Values.BackColor = System.Drawing.Color.White;
            this.Values.Controls.Add(this.YValue);
            this.Values.Controls.Add(this.Y0Value);
            this.Values.Controls.Add(this.BValue);
            this.Values.Controls.Add(this.GValue);
            this.Values.Controls.Add(this.DL2Value);
            this.Values.Controls.Add(this.ZValue);
            this.Values.Controls.Add(this.SettingsButton);
            this.Values.Controls.Add(this.ScreenShot);
            this.Values.Controls.Add(this.CallHelp);
            this.Values.Controls.Add(this.DLValue);
            this.Values.Controls.Add(this.KSValue);
            this.Values.Controls.Add(this.KBValue);
            this.Values.Controls.Add(this.PhiValue);
            this.Values.Controls.Add(this.RhoValue);
            this.Values.Controls.Add(this.IRValue);
            this.Values.Controls.Add(this.RRValue);
            this.Values.Controls.Add(this.Z0Value);
            this.Values.Controls.Add(this.XValue);
            this.Values.Controls.Add(this.RValue);
            this.Values.Controls.Add(this.Descriptions);
            this.Values.Dock = System.Windows.Forms.DockStyle.Left;
            this.Values.Location = new System.Drawing.Point(0, 0);
            this.Values.Name = "Values";
            this.Values.Size = new System.Drawing.Size(202, 451);
            this.Values.TabIndex = 0;
            // 
            // YValue
            // 
            this.YValue.BackColor = System.Drawing.Color.White;
            this.YValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.YValue.Location = new System.Drawing.Point(127, 77);
            this.YValue.Name = "YValue";
            this.YValue.ReadOnly = true;
            this.YValue.Size = new System.Drawing.Size(60, 23);
            this.YValue.TabIndex = 19;
            // 
            // Y0Value
            // 
            this.Y0Value.BackColor = System.Drawing.Color.White;
            this.Y0Value.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y0Value.ForeColor = System.Drawing.Color.Black;
            this.Y0Value.Location = new System.Drawing.Point(127, 109);
            this.Y0Value.Name = "Y0Value";
            this.Y0Value.Size = new System.Drawing.Size(60, 23);
            this.Y0Value.TabIndex = 18;
            this.Y0Value.Text = "1.0";
            this.Y0Value.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Y0KeyDown);
            this.Y0Value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueBoxKeyPress);
            // 
            // BValue
            // 
            this.BValue.BackColor = System.Drawing.Color.White;
            this.BValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BValue.ForeColor = System.Drawing.Color.Green;
            this.BValue.Location = new System.Drawing.Point(127, 44);
            this.BValue.Name = "BValue";
            this.BValue.Size = new System.Drawing.Size(60, 23);
            this.BValue.TabIndex = 17;
            this.BValue.TextChanged += new System.EventHandler(this.XBTexChanged);
            this.BValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BKeyDown);
            this.BValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueBoxKeyPress);
            // 
            // GValue
            // 
            this.GValue.BackColor = System.Drawing.Color.White;
            this.GValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GValue.ForeColor = System.Drawing.Color.Red;
            this.GValue.Location = new System.Drawing.Point(127, 11);
            this.GValue.Name = "GValue";
            this.GValue.Size = new System.Drawing.Size(60, 23);
            this.GValue.TabIndex = 16;
            this.GValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GKeyDown);
            this.GValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueBoxKeyPress);
            // 
            // DL2Value
            // 
            this.DL2Value.BackColor = System.Drawing.Color.White;
            this.DL2Value.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DL2Value.ForeColor = System.Drawing.Color.Purple;
            this.DL2Value.Location = new System.Drawing.Point(127, 337);
            this.DL2Value.Name = "DL2Value";
            this.DL2Value.ReadOnly = true;
            this.DL2Value.Size = new System.Drawing.Size(60, 23);
            this.DL2Value.TabIndex = 15;
            // 
            // ZValue
            // 
            this.ZValue.BackColor = System.Drawing.Color.White;
            this.ZValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ZValue.Location = new System.Drawing.Point(67, 77);
            this.ZValue.Name = "ZValue";
            this.ZValue.ReadOnly = true;
            this.ZValue.Size = new System.Drawing.Size(60, 23);
            this.ZValue.TabIndex = 14;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Image = global::SmithChart.Properties.Resources.setting;
            this.SettingsButton.Location = new System.Drawing.Point(72, 383);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(24, 24);
            this.SettingsButton.TabIndex = 13;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsClick);
            // 
            // ScreenShot
            // 
            this.ScreenShot.Image = global::SmithChart.Properties.Resources.save;
            this.ScreenShot.Location = new System.Drawing.Point(42, 383);
            this.ScreenShot.Name = "ScreenShot";
            this.ScreenShot.Size = new System.Drawing.Size(24, 24);
            this.ScreenShot.TabIndex = 12;
            this.ScreenShot.UseVisualStyleBackColor = true;
            this.ScreenShot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenShotClick);
            // 
            // CallHelp
            // 
            this.CallHelp.Image = global::SmithChart.Properties.Resources.help;
            this.CallHelp.Location = new System.Drawing.Point(12, 383);
            this.CallHelp.Name = "CallHelp";
            this.CallHelp.Size = new System.Drawing.Size(24, 24);
            this.CallHelp.TabIndex = 11;
            this.CallHelp.UseVisualStyleBackColor = true;
            this.CallHelp.Click += new System.EventHandler(this.CallHelpClick);
            // 
            // DLValue
            // 
            this.DLValue.BackColor = System.Drawing.Color.White;
            this.DLValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DLValue.ForeColor = System.Drawing.Color.Purple;
            this.DLValue.Location = new System.Drawing.Point(67, 337);
            this.DLValue.Name = "DLValue";
            this.DLValue.Size = new System.Drawing.Size(60, 23);
            this.DLValue.TabIndex = 10;
            this.DLValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DLKeyDown);
            this.DLValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueBoxKeyPress);
            // 
            // KSValue
            // 
            this.KSValue.BackColor = System.Drawing.Color.White;
            this.KSValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KSValue.ForeColor = System.Drawing.Color.Orange;
            this.KSValue.Location = new System.Drawing.Point(67, 304);
            this.KSValue.Name = "KSValue";
            this.KSValue.Size = new System.Drawing.Size(120, 23);
            this.KSValue.TabIndex = 9;
            this.KSValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KSKeyDown);
            this.KSValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueBoxKeyPress);
            // 
            // KBValue
            // 
            this.KBValue.BackColor = System.Drawing.Color.White;
            this.KBValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KBValue.ForeColor = System.Drawing.Color.Orange;
            this.KBValue.Location = new System.Drawing.Point(67, 271);
            this.KBValue.Name = "KBValue";
            this.KBValue.Size = new System.Drawing.Size(120, 23);
            this.KBValue.TabIndex = 8;
            this.KBValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KBKeyDown);
            this.KBValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueBoxKeyPress);
            // 
            // PhiValue
            // 
            this.PhiValue.BackColor = System.Drawing.Color.White;
            this.PhiValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhiValue.ForeColor = System.Drawing.Color.Blue;
            this.PhiValue.Location = new System.Drawing.Point(67, 238);
            this.PhiValue.Name = "PhiValue";
            this.PhiValue.ReadOnly = true;
            this.PhiValue.Size = new System.Drawing.Size(120, 23);
            this.PhiValue.TabIndex = 7;
            this.PhiValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PhiKeyDown);
            // 
            // RhoValue
            // 
            this.RhoValue.BackColor = System.Drawing.Color.White;
            this.RhoValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RhoValue.ForeColor = System.Drawing.Color.Blue;
            this.RhoValue.Location = new System.Drawing.Point(67, 205);
            this.RhoValue.Name = "RhoValue";
            this.RhoValue.Size = new System.Drawing.Size(120, 23);
            this.RhoValue.TabIndex = 6;
            this.RhoValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RhoKeyDown);
            this.RhoValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueBoxKeyPress);
            // 
            // IRValue
            // 
            this.IRValue.BackColor = System.Drawing.Color.White;
            this.IRValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IRValue.ForeColor = System.Drawing.Color.Blue;
            this.IRValue.Location = new System.Drawing.Point(67, 173);
            this.IRValue.Name = "IRValue";
            this.IRValue.ReadOnly = true;
            this.IRValue.Size = new System.Drawing.Size(120, 23);
            this.IRValue.TabIndex = 5;
            // 
            // RRValue
            // 
            this.RRValue.BackColor = System.Drawing.Color.White;
            this.RRValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RRValue.ForeColor = System.Drawing.Color.Blue;
            this.RRValue.Location = new System.Drawing.Point(67, 141);
            this.RRValue.Name = "RRValue";
            this.RRValue.ReadOnly = true;
            this.RRValue.Size = new System.Drawing.Size(120, 23);
            this.RRValue.TabIndex = 4;
            // 
            // Z0Value
            // 
            this.Z0Value.BackColor = System.Drawing.Color.White;
            this.Z0Value.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Z0Value.ForeColor = System.Drawing.Color.Black;
            this.Z0Value.Location = new System.Drawing.Point(67, 109);
            this.Z0Value.Name = "Z0Value";
            this.Z0Value.Size = new System.Drawing.Size(60, 23);
            this.Z0Value.TabIndex = 3;
            this.Z0Value.Text = "1.0";
            this.Z0Value.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Z0KeyDown);
            this.Z0Value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueBoxKeyPress);
            // 
            // XValue
            // 
            this.XValue.BackColor = System.Drawing.Color.White;
            this.XValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XValue.ForeColor = System.Drawing.Color.Green;
            this.XValue.Location = new System.Drawing.Point(67, 44);
            this.XValue.Name = "XValue";
            this.XValue.Size = new System.Drawing.Size(60, 23);
            this.XValue.TabIndex = 2;
            this.XValue.TextChanged += new System.EventHandler(this.XBTexChanged);
            this.XValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XKeyDown);
            this.XValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueBoxKeyPress);
            // 
            // RValue
            // 
            this.RValue.BackColor = System.Drawing.Color.White;
            this.RValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RValue.ForeColor = System.Drawing.Color.Red;
            this.RValue.Location = new System.Drawing.Point(67, 11);
            this.RValue.Name = "RValue";
            this.RValue.Size = new System.Drawing.Size(60, 23);
            this.RValue.TabIndex = 1;
            this.RValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RKeyDown);
            this.RValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueBoxKeyPress);
            // 
            // Descriptions
            // 
            this.Descriptions.ErrorImage = null;
            this.Descriptions.Image = global::SmithChart.Properties.Resources.labels;
            this.Descriptions.Location = new System.Drawing.Point(9, 12);
            this.Descriptions.Name = "Descriptions";
            this.Descriptions.Size = new System.Drawing.Size(56, 365);
            this.Descriptions.TabIndex = 1;
            this.Descriptions.TabStop = false;
            // 
            // Chart
            // 
            this.Chart.ArgRho = 1.2396539912091065D;
            this.Chart.B = -0.59255626610778356D;
            this.Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chart.Dxl = 0.15135146978773686D;
            this.Chart.DxlColor = System.Drawing.Color.Purple;
            this.Chart.G = 0.4913586649324353D;
            this.Chart.InfoEnable = true;
            this.Chart.KColor = System.Drawing.Color.Orange;
            this.Chart.Ksw = 2.89580018184824D;
            this.Chart.Ktw = 0.34532769431686117D;
            this.Chart.LinesWidth = 1F;
            this.Chart.Location = new System.Drawing.Point(202, 0);
            this.Chart.Name = "Chart";
            this.Chart.R = 0.82921857895442319D;
            this.Chart.RColor = System.Drawing.Color.Red;
            this.Chart.Rho = 0.48662664750655593D;
            this.Chart.RhoColor = System.Drawing.Color.Blue;
            this.Chart.ScaleStep = 1.25D;
            this.Chart.Size = new System.Drawing.Size(451, 451);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "chart1";
            this.Chart.X = 1D;
            this.Chart.XColor = System.Drawing.Color.Green;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 451);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.Values);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(649, 469);
            this.Name = "MainForm";
            this.Text = "SmithChart";
            this.Values.ResumeLayout(false);
            this.Values.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Descriptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Values;
        private System.Windows.Forms.PictureBox Descriptions;
        private System.Windows.Forms.TextBox RValue;
        private System.Windows.Forms.TextBox XValue;
        private System.Windows.Forms.TextBox Z0Value;
        private System.Windows.Forms.TextBox RRValue;
        private System.Windows.Forms.TextBox IRValue;
        private System.Windows.Forms.TextBox PhiValue;
        private System.Windows.Forms.TextBox RhoValue;
        private System.Windows.Forms.TextBox KSValue;
        private System.Windows.Forms.TextBox KBValue;
        private System.Windows.Forms.TextBox DLValue;
        private SmithChart Chart;
        private System.Windows.Forms.Button CallHelp;
        private System.Windows.Forms.Button ScreenShot;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.TextBox ZValue;
        private System.Windows.Forms.TextBox DL2Value;
        private System.Windows.Forms.TextBox YValue;
        private System.Windows.Forms.TextBox Y0Value;
        private System.Windows.Forms.TextBox BValue;
        private System.Windows.Forms.TextBox GValue;
    }
}