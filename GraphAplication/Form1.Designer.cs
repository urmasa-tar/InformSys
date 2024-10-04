namespace GraphAplication
{
    partial class Form1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grapPicter = new PictureBox();
            drawBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)grapPicter).BeginInit();
            SuspendLayout();
            // 
            // grapPicter
            // 
            grapPicter.BackColor = SystemColors.ButtonShadow;
            grapPicter.Location = new Point(12, 12);
            grapPicter.Name = "grapPicter";
            grapPicter.Size = new Size(602, 436);
            grapPicter.TabIndex = 0;
            grapPicter.TabStop = false;
            // 
            // drawBtn
            // 
            drawBtn.Location = new Point(620, 186);
            drawBtn.Name = "drawBtn";
            drawBtn.Size = new Size(143, 53);
            drawBtn.TabIndex = 1;
            drawBtn.Text = "Draw graph";
            drawBtn.UseVisualStyleBackColor = true;
            drawBtn.Click += drawBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1162, 653);
            Controls.Add(drawBtn);
            Controls.Add(grapPicter);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grapPicter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox grapPicter;
        private Button drawBtn;
    }
}
