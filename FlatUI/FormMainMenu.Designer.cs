namespace FlatUI
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chartForFormula = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelDown = new System.Windows.Forms.Panel();
            this.pBoxStandartValue = new System.Windows.Forms.PictureBox();
            this.pBoxFormula = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartForFormula)).BeginInit();
            this.panelDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxStandartValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.uploadBtn);
            this.panelMenu.Controls.Add(this.btnSave);
            this.panelMenu.Controls.Add(this.btnUpdate);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnDraw);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(269, 753);
            this.panelMenu.TabIndex = 0;
            // 
            // uploadBtn
            // 
            this.uploadBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.uploadBtn.FlatAppearance.BorderSize = 0;
            this.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.uploadBtn.Location = new System.Drawing.Point(0, 415);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Padding = new System.Windows.Forms.Padding(11, 10, 0, 0);
            this.uploadBtn.Size = new System.Drawing.Size(269, 83);
            this.uploadBtn.TabIndex = 5;
            this.uploadBtn.Text = "Uplaod";
            this.uploadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSave.Location = new System.Drawing.Point(0, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(11, 10, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(269, 83);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUpdate.Location = new System.Drawing.Point(0, 249);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(11, 10, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(269, 83);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSettings.Location = new System.Drawing.Point(0, 166);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(11, 10, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(269, 83);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDraw.FlatAppearance.BorderSize = 0;
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraw.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDraw.Location = new System.Drawing.Point(0, 83);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Padding = new System.Windows.Forms.Padding(11, 10, 0, 0);
            this.btnDraw.Size = new System.Drawing.Size(269, 83);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "DrawImageGraph";
            this.btnDraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(269, 83);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 71);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // chartForFormula
            // 
            chartArea2.Name = "ChartArea1";
            this.chartForFormula.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartForFormula.Legends.Add(legend2);
            this.chartForFormula.Location = new System.Drawing.Point(415, 28);
            this.chartForFormula.Name = "chartForFormula";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartForFormula.Series.Add(series2);
            this.chartForFormula.Size = new System.Drawing.Size(679, 331);
            this.chartForFormula.TabIndex = 1;
            this.chartForFormula.Text = "mainFormula";
            // 
            // panelDown
            // 
            this.panelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(64)))), ((int)(((byte)(162)))));
            this.panelDown.Controls.Add(this.pBoxStandartValue);
            this.panelDown.Controls.Add(this.pBoxFormula);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDown.Location = new System.Drawing.Point(269, 402);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(972, 351);
            this.panelDown.TabIndex = 2;
            // 
            // pBoxStandartValue
            // 
            this.pBoxStandartValue.Image = ((System.Drawing.Image)(resources.GetObject("pBoxStandartValue.Image")));
            this.pBoxStandartValue.Location = new System.Drawing.Point(40, 106);
            this.pBoxStandartValue.Name = "pBoxStandartValue";
            this.pBoxStandartValue.Size = new System.Drawing.Size(875, 219);
            this.pBoxStandartValue.TabIndex = 1;
            this.pBoxStandartValue.TabStop = false;
            // 
            // pBoxFormula
            // 
            this.pBoxFormula.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pBoxFormula.ErrorImage")));
            this.pBoxFormula.Image = ((System.Drawing.Image)(resources.GetObject("pBoxFormula.Image")));
            this.pBoxFormula.Location = new System.Drawing.Point(256, 3);
            this.pBoxFormula.Name = "pBoxFormula";
            this.pBoxFormula.Size = new System.Drawing.Size(492, 97);
            this.pBoxFormula.TabIndex = 0;
            this.pBoxFormula.TabStop = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 753);
            this.Controls.Add(this.panelDown);
            this.Controls.Add(this.chartForFormula);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainMenu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartForFormula)).EndInit();
            this.panelDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxStandartValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFormula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartForFormula;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.PictureBox pBoxFormula;
        private System.Windows.Forms.PictureBox pBoxStandartValue;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

