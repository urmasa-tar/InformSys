﻿namespace GraphAplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            grapPicter = new PictureBox();
            drawBtn = new Button();
            AtextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            NtextBox = new TextBox();
            label3 = new Label();
            ktextBox = new TextBox();
            label4 = new Label();
            kdtextBox = new TextBox();
            updateBtn = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            dxtextBox = new TextBox();
            referBtn = new Button();
            downloadBtn = new Button();
            uploadBtn = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)grapPicter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            drawBtn.Location = new Point(620, 45);
            drawBtn.Name = "drawBtn";
            drawBtn.Size = new Size(143, 53);
            drawBtn.TabIndex = 1;
            drawBtn.Text = "Draw graph";
            drawBtn.UseVisualStyleBackColor = true;
            drawBtn.Click += drawBtn_Click;
            // 
            // AtextBox
            // 
            AtextBox.Location = new Point(832, 45);
            AtextBox.Name = "AtextBox";
            AtextBox.Size = new Size(201, 27);
            AtextBox.TabIndex = 2;
            AtextBox.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(832, 12);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 3;
            label1.Text = "A - parametr";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(832, 79);
            label2.Name = "label2";
            label2.Size = new Size(20, 20);
            label2.TabIndex = 5;
            label2.Text = "N";
            // 
            // NtextBox
            // 
            NtextBox.Location = new Point(831, 110);
            NtextBox.Name = "NtextBox";
            NtextBox.Size = new Size(201, 27);
            NtextBox.TabIndex = 4;
            NtextBox.Text = "1000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(832, 142);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 7;
            label3.Text = "K1";
            // 
            // ktextBox
            // 
            ktextBox.Location = new Point(831, 173);
            ktextBox.Name = "ktextBox";
            ktextBox.Size = new Size(201, 27);
            ktextBox.TabIndex = 6;
            ktextBox.Text = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(831, 216);
            label4.Name = "label4";
            label4.Size = new Size(27, 20);
            label4.TabIndex = 9;
            label4.Text = "Kd";
            // 
            // kdtextBox
            // 
            kdtextBox.Location = new Point(830, 247);
            kdtextBox.Name = "kdtextBox";
            kdtextBox.Size = new Size(201, 27);
            kdtextBox.TabIndex = 8;
            kdtextBox.Text = "1";
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(620, 126);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(143, 53);
            updateBtn.TabIndex = 10;
            updateBtn.Text = "Update parameters";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 454);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(602, 93);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(831, 278);
            label5.Name = "label5";
            label5.Size = new Size(27, 20);
            label5.TabIndex = 13;
            label5.Text = "Dx";
            // 
            // dxtextBox
            // 
            dxtextBox.Location = new Point(830, 309);
            dxtextBox.Name = "dxtextBox";
            dxtextBox.Size = new Size(201, 27);
            dxtextBox.TabIndex = 12;
            dxtextBox.Text = "1";
            // 
            // referBtn
            // 
            referBtn.Location = new Point(937, 351);
            referBtn.Name = "referBtn";
            referBtn.Size = new Size(94, 29);
            referBtn.TabIndex = 14;
            referBtn.Text = "Reference";
            referBtn.UseVisualStyleBackColor = true;
            referBtn.Click += referBtn_Click;
            // 
            // downloadBtn
            // 
            downloadBtn.Location = new Point(620, 200);
            downloadBtn.Name = "downloadBtn";
            downloadBtn.Size = new Size(143, 53);
            downloadBtn.TabIndex = 15;
            downloadBtn.Text = "Download parameters";
            downloadBtn.UseVisualStyleBackColor = true;
            downloadBtn.Click += downloadBtn_Click;
            // 
            // uploadBtn
            // 
            uploadBtn.Location = new Point(624, 282);
            uploadBtn.Name = "uploadBtn";
            uploadBtn.Size = new Size(139, 54);
            uploadBtn.TabIndex = 16;
            uploadBtn.Text = "Upload parameters";
            uploadBtn.UseVisualStyleBackColor = true;
            uploadBtn.Click += uploadBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(657, 413);
            label6.Name = "label6";
            label6.Size = new Size(19, 20);
            label6.TabIndex = 17;
            label6.Text = "A";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(723, 413);
            label7.Name = "label7";
            label7.Size = new Size(20, 20);
            label7.TabIndex = 18;
            label7.Text = "N";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(853, 413);
            label8.Name = "label8";
            label8.Size = new Size(27, 20);
            label8.TabIndex = 20;
            label8.Text = "Kd";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(787, 413);
            label9.Name = "label9";
            label9.Size = new Size(26, 20);
            label9.TabIndex = 19;
            label9.Text = "K1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(921, 413);
            label10.Name = "label10";
            label10.Size = new Size(27, 20);
            label10.TabIndex = 21;
            label10.Text = "Dx";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(657, 454);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(317, 27);
            textBox6.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1047, 559);
            Controls.Add(textBox6);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(uploadBtn);
            Controls.Add(downloadBtn);
            Controls.Add(referBtn);
            Controls.Add(label5);
            Controls.Add(dxtextBox);
            Controls.Add(pictureBox1);
            Controls.Add(updateBtn);
            Controls.Add(label4);
            Controls.Add(kdtextBox);
            Controls.Add(label3);
            Controls.Add(ktextBox);
            Controls.Add(label2);
            Controls.Add(NtextBox);
            Controls.Add(label1);
            Controls.Add(AtextBox);
            Controls.Add(drawBtn);
            Controls.Add(grapPicter);
            Name = "Form1";
            Text = "1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grapPicter).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox grapPicter;
        private Button drawBtn;
        private TextBox AtextBox;
        private Label label1;
        private Label label2;
        private TextBox NtextBox;
        private Label label3;
        private TextBox ktextBox;
        private Label label4;
        private TextBox kdtextBox;
        private Button updateBtn;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox dxtextBox;
        private Button referBtn;
        private Button downloadBtn;
        private Button uploadBtn;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox6;
    }
}
