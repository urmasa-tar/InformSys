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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            textBox5 = new TextBox();
            referBtn = new Button();
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
            drawBtn.Location = new Point(620, 93);
            drawBtn.Name = "drawBtn";
            drawBtn.Size = new Size(143, 53);
            drawBtn.TabIndex = 1;
            drawBtn.Text = "Draw graph";
            drawBtn.UseVisualStyleBackColor = true;
            drawBtn.Click += drawBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(832, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "1";
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
            // textBox2
            // 
            textBox2.Location = new Point(831, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 27);
            textBox2.TabIndex = 4;
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
            // textBox3
            // 
            textBox3.Location = new Point(831, 173);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(201, 27);
            textBox3.TabIndex = 6;
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
            // textBox4
            // 
            textBox4.Location = new Point(830, 247);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(201, 27);
            textBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(620, 206);
            button1.Name = "button1";
            button1.Size = new Size(143, 53);
            button1.TabIndex = 10;
            button1.Text = "Update parameters";
            button1.UseVisualStyleBackColor = true;
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
            // textBox5
            // 
            textBox5.Location = new Point(830, 309);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(201, 27);
            textBox5.TabIndex = 12;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1047, 559);
            Controls.Add(referBtn);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox textBox5;
        private Button referBtn;
    }
}