namespace Ink
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(74, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 229);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(74, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "0";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(125, 175);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(74, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "0";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(125, 340);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(74, 23);
            textBox4.TabIndex = 3;
            textBox4.Text = "0";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(125, 285);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(74, 23);
            textBox5.TabIndex = 4;
            textBox5.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 27);
            label1.Name = "label1";
            label1.Size = new Size(342, 30);
            label1.TabIndex = 5;
            label1.Text = "Printer Cartridge recycle Program";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 128);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 6;
            label2.Text = "C1";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 178);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(21, 15);
            label3.TabIndex = 7;
            label3.Text = "C2";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 232);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 8;
            label4.Text = "C3";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 288);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 9;
            label5.Text = "C4";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 343);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 10;
            label6.Text = "C5";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(405, 232);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 11;
            button1.Text = "Result";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(405, 276);
            label7.Name = "label7";
            label7.Size = new Size(191, 15);
            label7.TabIndex = 12;
            label7.Text = "The most cartridges collected was :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(405, 319);
            label8.Name = "label8";
            label8.Size = new Size(188, 15);
            label8.TabIndex = 13;
            label8.Text = "The least cartridges collected was :";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(602, 273);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(38, 23);
            textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(602, 319);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(38, 23);
            textBox7.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(399, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label label7;
        private Label label8;
        private TextBox textBox6;
        private TextBox textBox7;
        private PictureBox pictureBox1;
    }
}
