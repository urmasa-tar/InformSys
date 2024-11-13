namespace FlatUI
{
    partial class settingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.lblFullscreen = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.chkFullScreen = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVol = new System.Windows.Forms.Label();
            this.trcVol = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.lblSens = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trcVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFullscreen
            // 
            this.lblFullscreen.AutoSize = true;
            this.lblFullscreen.Location = new System.Drawing.Point(37, 45);
            this.lblFullscreen.Name = "lblFullscreen";
            this.lblFullscreen.Size = new System.Drawing.Size(71, 16);
            this.lblFullscreen.TabIndex = 0;
            this.lblFullscreen.Text = "FullScreen";
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(100)))), ((int)(((byte)(151)))));
            this.btnAccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAccept.Location = new System.Drawing.Point(341, 302);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(0);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(121, 55);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // chkFullScreen
            // 
            this.chkFullScreen.BackColor = System.Drawing.Color.Gray;
            this.chkFullScreen.FormattingEnabled = true;
            this.chkFullScreen.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.chkFullScreen.Location = new System.Drawing.Point(114, 45);
            this.chkFullScreen.Name = "chkFullScreen";
            this.chkFullScreen.Size = new System.Drawing.Size(120, 38);
            this.chkFullScreen.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Gray;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "1232; 800",
            "1423; 800"});
            this.checkedListBox1.Location = new System.Drawing.Point(114, 119);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 38);
            this.checkedListBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Baze size";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.Color.Gray;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.checkedListBox2.Location = new System.Drawing.Point(114, 189);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(120, 38);
            this.checkedListBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Theme";
            // 
            // lblVol
            // 
            this.lblVol.AutoSize = true;
            this.lblVol.Location = new System.Drawing.Point(310, 45);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(42, 16);
            this.lblVol.TabIndex = 7;
            this.lblVol.Text = "Volue";
            // 
            // trcVol
            // 
            this.trcVol.Location = new System.Drawing.Point(296, 64);
            this.trcVol.Name = "trcVol";
            this.trcVol.Size = new System.Drawing.Size(201, 56);
            this.trcVol.TabIndex = 8;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(296, 149);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(201, 56);
            this.trackBar2.TabIndex = 10;
            // 
            // lblSens
            // 
            this.lblSens.AutoSize = true;
            this.lblSens.Location = new System.Drawing.Point(310, 130);
            this.lblSens.Name = "lblSens";
            this.lblSens.Size = new System.Drawing.Size(74, 16);
            this.lblSens.TabIndex = 9;
            this.lblSens.Text = "Sencitiyvity";
            // 
            // settingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(519, 380);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.lblSens);
            this.Controls.Add(this.trcVol);
            this.Controls.Add(this.lblVol);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkFullScreen);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblFullscreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.trcVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFullscreen;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.CheckedListBox chkFullScreen;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVol;
        private System.Windows.Forms.TrackBar trcVol;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label lblSens;
    }
}