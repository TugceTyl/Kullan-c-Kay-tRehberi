namespace KullanıcıKayıtRehberi
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(30, 107);
            button1.Name = "button1";
            button1.Size = new Size(158, 54);
            button1.TabIndex = 0;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(251, 117);
            label1.Name = "label1";
            label1.Size = new Size(119, 35);
            label1.TabIndex = 1;
            label1.Text = "merhaba";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(30, 204);
            button2.Name = "button2";
            button2.Size = new Size(158, 60);
            button2.TabIndex = 2;
            button2.Text = "Kayıt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(233, 229);
            label2.Name = "label2";
            label2.Size = new Size(121, 35);
            label2.TabIndex = 3;
            label2.Text = "merhaba";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(216, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 41);
            textBox1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(30, 34);
            button3.Name = "button3";
            button3.Size = new Size(158, 51);
            button3.TabIndex = 5;
            button3.Text = "Texbox Kayıt";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(30, 303);
            button4.Name = "button4";
            button4.Size = new Size(158, 47);
            button4.TabIndex = 6;
            button4.Text = "Veri Kaydet";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(251, 316);
            label3.Name = "label3";
            label3.Size = new Size(84, 35);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Label label2;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private Label label3;
    }
}