namespace funckjadelta
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dodatnieujemne = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.miejsce1box = new System.Windows.Forms.TextBox();
            this.miejce2box = new System.Windows.Forms.TextBox();
            this.deltawynik = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(51, 23);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(21, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(55, 23);
            this.textBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "x^2+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "x+";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "DODATNIA/UJEMNA";
            // 
            // dodatnieujemne
            // 
            this.dodatnieujemne.Location = new System.Drawing.Point(528, 49);
            this.dodatnieujemne.Name = "dodatnieujemne";
            this.dodatnieujemne.Size = new System.Drawing.Size(130, 23);
            this.dodatnieujemne.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 68);
            this.button1.TabIndex = 8;
            this.button1.Text = "Oblicz Delte i miejsca zerowe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "b";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "c";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "miejsce zerowe 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(543, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "miejsce zerowe 2";
            // 
            // miejsce1box
            // 
            this.miejsce1box.Location = new System.Drawing.Point(390, 298);
            this.miejsce1box.Name = "miejsce1box";
            this.miejsce1box.Size = new System.Drawing.Size(84, 23);
            this.miejsce1box.TabIndex = 14;
            // 
            // miejce2box
            // 
            this.miejce2box.Location = new System.Drawing.Point(548, 296);
            this.miejce2box.Name = "miejce2box";
            this.miejce2box.Size = new System.Drawing.Size(85, 23);
            this.miejce2box.TabIndex = 15;
            // 
            // deltawynik
            // 
            this.deltawynik.Location = new System.Drawing.Point(300, 54);
            this.deltawynik.Name = "deltawynik";
            this.deltawynik.Size = new System.Drawing.Size(117, 23);
            this.deltawynik.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deltawynik);
            this.Controls.Add(this.miejce2box);
            this.Controls.Add(this.miejsce1box);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dodatnieujemne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox dodatnieujemne;
        private Button button1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox miejsce1box;
        private TextBox miejce2box;
        private TextBox deltawynik;
    }
}