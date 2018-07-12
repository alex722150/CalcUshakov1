namespace CalcUshakov
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonAmount = new System.Windows.Forms.Button();
            this.buttonDifference = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Cube = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Atan = new System.Windows.Forms.Button();
            this.Fraction = new System.Windows.Forms.Button();
            this.TenExp = new System.Windows.Forms.Button();
            this.doubleDifSquare = new System.Windows.Forms.Button();
            this.DoublAmount = new System.Windows.Forms.Button();
            this.Ctan = new System.Windows.Forms.Button();
            this.Arcsin = new System.Windows.Forms.Button();
            this.Arccos = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.difDivision = new System.Windows.Forms.Button();
            this.amountCube = new System.Windows.Forms.Button();
            this.difCube = new System.Windows.Forms.Button();
            this.squareOfAmount = new System.Windows.Forms.Button();
            this.doubleDifference = new System.Windows.Forms.Button();
            this.doubleMultiply = new System.Windows.Forms.Button();
            this.doubleDivision = new System.Windows.Forms.Button();
            this.amountSquare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 20);
            this.textBox3.TabIndex = 2;
            // 
            // buttonAmount
            // 
            this.buttonAmount.Location = new System.Drawing.Point(29, 88);
            this.buttonAmount.Name = "buttonAmount";
            this.buttonAmount.Size = new System.Drawing.Size(61, 50);
            this.buttonAmount.TabIndex = 3;
            this.buttonAmount.Text = "+";
            this.buttonAmount.UseVisualStyleBackColor = true;
            this.buttonAmount.Click += new System.EventHandler(this.Click);
            // 
            // buttonDifference
            // 
            this.buttonDifference.Location = new System.Drawing.Point(96, 88);
            this.buttonDifference.Name = "buttonDifference";
            this.buttonDifference.Size = new System.Drawing.Size(61, 50);
            this.buttonDifference.TabIndex = 4;
            this.buttonDifference.Text = "-";
            this.buttonDifference.UseVisualStyleBackColor = true;
            this.buttonDifference.Click += new System.EventHandler(this.Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(172, 88);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(61, 50);
            this.buttonMultiply.TabIndex = 5;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(239, 88);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(61, 50);
            this.buttonDivision.TabIndex = 6;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(28, 450);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(61, 50);
            this.Square.TabIndex = 7;
            this.Square.Text = "x^2";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.ClickUnary);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(96, 179);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(61, 50);
            this.Sin.TabIndex = 8;
            this.Sin.Text = "sin(x)";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.ClickUnary);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(29, 179);
            this.Cos.Margin = new System.Windows.Forms.Padding(2);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(61, 50);
            this.Cos.TabIndex = 9;
            this.Cos.Text = "cos(x)";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.ClickUnary);
            // 
            // Cube
            // 
            this.Cube.Location = new System.Drawing.Point(96, 450);
            this.Cube.Margin = new System.Windows.Forms.Padding(2);
            this.Cube.Name = "Cube";
            this.Cube.Size = new System.Drawing.Size(61, 50);
            this.Cube.TabIndex = 10;
            this.Cube.Text = "x^3";
            this.Cube.UseVisualStyleBackColor = true;
            this.Cube.Click += new System.EventHandler(this.ClickUnary);
            // 
            // Tan
            // 
            this.Tan.Location = new System.Drawing.Point(29, 341);
            this.Tan.Margin = new System.Windows.Forms.Padding(2);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(61, 50);
            this.Tan.TabIndex = 11;
            this.Tan.Text = "tg(x)";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.ClickUnary);
            // 
            // Atan
            // 
            this.Atan.Location = new System.Drawing.Point(96, 234);
            this.Atan.Margin = new System.Windows.Forms.Padding(2);
            this.Atan.Name = "Atan";
            this.Atan.Size = new System.Drawing.Size(61, 50);
            this.Atan.TabIndex = 12;
            this.Atan.Text = "arctg(x)";
            this.Atan.UseVisualStyleBackColor = true;
            this.Atan.Click += new System.EventHandler(this.ClickUnary);
            // 
            // Fraction
            // 
            this.Fraction.Location = new System.Drawing.Point(28, 395);
            this.Fraction.Margin = new System.Windows.Forms.Padding(2);
            this.Fraction.Name = "Fraction";
            this.Fraction.Size = new System.Drawing.Size(61, 50);
            this.Fraction.TabIndex = 13;
            this.Fraction.Text = "1/x";
            this.Fraction.UseVisualStyleBackColor = true;
            this.Fraction.Click += new System.EventHandler(this.ClickUnary);
            // 
            // TenExp
            // 
            this.TenExp.Location = new System.Drawing.Point(96, 396);
            this.TenExp.Margin = new System.Windows.Forms.Padding(2);
            this.TenExp.Name = "TenExp";
            this.TenExp.Size = new System.Drawing.Size(61, 50);
            this.TenExp.TabIndex = 14;
            this.TenExp.Text = "10^x";
            this.TenExp.UseVisualStyleBackColor = true;
            this.TenExp.Click += new System.EventHandler(this.ClickUnary);
            // 
            // doubleDifSquare
            // 
            this.doubleDifSquare.Location = new System.Drawing.Point(165, 341);
            this.doubleDifSquare.Margin = new System.Windows.Forms.Padding(2);
            this.doubleDifSquare.Name = "doubleDifSquare";
            this.doubleDifSquare.Size = new System.Drawing.Size(135, 24);
            this.doubleDifSquare.TabIndex = 15;
            this.doubleDifSquare.Text = "Квадрат разности";
            this.doubleDifSquare.UseVisualStyleBackColor = true;
            this.doubleDifSquare.Click += new System.EventHandler(this.Click);
            // 
            // DoublAmount
            // 
            this.DoublAmount.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoublAmount.Location = new System.Drawing.Point(165, 179);
            this.DoublAmount.Margin = new System.Windows.Forms.Padding(2);
            this.DoublAmount.Name = "DoublAmount";
            this.DoublAmount.Size = new System.Drawing.Size(135, 24);
            this.DoublAmount.TabIndex = 16;
            this.DoublAmount.Text = "Двойная сумма";
            this.DoublAmount.UseVisualStyleBackColor = true;
            this.DoublAmount.Click += new System.EventHandler(this.Click);
            // 
            // Ctan
            // 
            this.Ctan.Location = new System.Drawing.Point(29, 233);
            this.Ctan.Margin = new System.Windows.Forms.Padding(2);
            this.Ctan.Name = "Ctan";
            this.Ctan.Size = new System.Drawing.Size(61, 50);
            this.Ctan.TabIndex = 17;
            this.Ctan.Text = "ctg(x)";
            this.Ctan.UseVisualStyleBackColor = true;
            this.Ctan.Click += new System.EventHandler(this.ClickUnary);
            // 
            // Arcsin
            // 
            this.Arcsin.Location = new System.Drawing.Point(96, 287);
            this.Arcsin.Margin = new System.Windows.Forms.Padding(2);
            this.Arcsin.Name = "Arcsin";
            this.Arcsin.Size = new System.Drawing.Size(61, 50);
            this.Arcsin.TabIndex = 18;
            this.Arcsin.Text = "arcsin";
            this.Arcsin.UseVisualStyleBackColor = true;
            this.Arcsin.Click += new System.EventHandler(this.ClickUnary);
            // 
            // Arccos
            // 
            this.Arccos.Location = new System.Drawing.Point(29, 287);
            this.Arccos.Margin = new System.Windows.Forms.Padding(2);
            this.Arccos.Name = "Arccos";
            this.Arccos.Size = new System.Drawing.Size(61, 50);
            this.Arccos.TabIndex = 19;
            this.Arccos.Text = "arccos";
            this.Arccos.UseVisualStyleBackColor = true;
            this.Arccos.Click += new System.EventHandler(this.ClickUnary);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(96, 341);
            this.Log.Margin = new System.Windows.Forms.Padding(2);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(61, 50);
            this.Log.TabIndex = 20;
            this.Log.Text = "lg(x)";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.ClickUnary);
            // 
            // difDivision
            // 
            this.difDivision.Location = new System.Drawing.Point(165, 478);
            this.difDivision.Margin = new System.Windows.Forms.Padding(2);
            this.difDivision.Name = "difDivision";
            this.difDivision.Size = new System.Drawing.Size(135, 24);
            this.difDivision.TabIndex = 21;
            this.difDivision.Text = "(x/y)-(y/x)";
            this.difDivision.UseVisualStyleBackColor = true;
            this.difDivision.Click += new System.EventHandler(this.Click);
            // 
            // amountCube
            // 
            this.amountCube.Location = new System.Drawing.Point(165, 379);
            this.amountCube.Margin = new System.Windows.Forms.Padding(2);
            this.amountCube.Name = "amountCube";
            this.amountCube.Size = new System.Drawing.Size(135, 24);
            this.amountCube.TabIndex = 22;
            this.amountCube.Text = "Сложение куба";
            this.amountCube.UseVisualStyleBackColor = true;
            this.amountCube.Click += new System.EventHandler(this.Click);
            // 
            // difCube
            // 
            this.difCube.Location = new System.Drawing.Point(165, 409);
            this.difCube.Margin = new System.Windows.Forms.Padding(2);
            this.difCube.Name = "difCube";
            this.difCube.Size = new System.Drawing.Size(135, 24);
            this.difCube.TabIndex = 23;
            this.difCube.Text = "Разность куба";
            this.difCube.UseVisualStyleBackColor = true;
            this.difCube.Click += new System.EventHandler(this.Click);
            // 
            // squareOfAmount
            // 
            this.squareOfAmount.Location = new System.Drawing.Point(165, 313);
            this.squareOfAmount.Margin = new System.Windows.Forms.Padding(2);
            this.squareOfAmount.Name = "squareOfAmount";
            this.squareOfAmount.Size = new System.Drawing.Size(135, 24);
            this.squareOfAmount.TabIndex = 24;
            this.squareOfAmount.Text = "Квадрат суммы";
            this.squareOfAmount.UseVisualStyleBackColor = true;
            this.squareOfAmount.Click += new System.EventHandler(this.Click);
            // 
            // doubleDifference
            // 
            this.doubleDifference.Location = new System.Drawing.Point(165, 207);
            this.doubleDifference.Margin = new System.Windows.Forms.Padding(2);
            this.doubleDifference.Name = "doubleDifference";
            this.doubleDifference.Size = new System.Drawing.Size(135, 24);
            this.doubleDifference.TabIndex = 25;
            this.doubleDifference.Text = "Двойное вычитание";
            this.doubleDifference.UseVisualStyleBackColor = true;
            this.doubleDifference.Click += new System.EventHandler(this.Click);
            // 
            // doubleMultiply
            // 
            this.doubleMultiply.Location = new System.Drawing.Point(165, 246);
            this.doubleMultiply.Margin = new System.Windows.Forms.Padding(2);
            this.doubleMultiply.Name = "doubleMultiply";
            this.doubleMultiply.Size = new System.Drawing.Size(135, 24);
            this.doubleMultiply.TabIndex = 26;
            this.doubleMultiply.Text = "Двойное произведение";
            this.doubleMultiply.UseVisualStyleBackColor = true;
            this.doubleMultiply.Click += new System.EventHandler(this.Click);
            // 
            // doubleDivision
            // 
            this.doubleDivision.Location = new System.Drawing.Point(165, 274);
            this.doubleDivision.Margin = new System.Windows.Forms.Padding(2);
            this.doubleDivision.Name = "doubleDivision";
            this.doubleDivision.Size = new System.Drawing.Size(135, 24);
            this.doubleDivision.TabIndex = 27;
            this.doubleDivision.Text = "Двойное частное";
            this.doubleDivision.UseVisualStyleBackColor = true;
            this.doubleDivision.Click += new System.EventHandler(this.Click);
            // 
            // amountSquare
            // 
            this.amountSquare.Location = new System.Drawing.Point(165, 450);
            this.amountSquare.Margin = new System.Windows.Forms.Padding(2);
            this.amountSquare.Name = "amountSquare";
            this.amountSquare.Size = new System.Drawing.Size(135, 24);
            this.amountSquare.TabIndex = 28;
            this.amountSquare.Text = "Площадь";
            this.amountSquare.UseVisualStyleBackColor = true;
            this.amountSquare.Click += new System.EventHandler(this.Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Число А";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Число В";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Результат";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "One Argument operations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Two Argument operations";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amountSquare);
            this.Controls.Add(this.doubleDivision);
            this.Controls.Add(this.doubleMultiply);
            this.Controls.Add(this.doubleDifference);
            this.Controls.Add(this.squareOfAmount);
            this.Controls.Add(this.difCube);
            this.Controls.Add(this.amountCube);
            this.Controls.Add(this.difDivision);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Arccos);
            this.Controls.Add(this.Arcsin);
            this.Controls.Add(this.Ctan);
            this.Controls.Add(this.DoublAmount);
            this.Controls.Add(this.doubleDifSquare);
            this.Controls.Add(this.TenExp);
            this.Controls.Add(this.Fraction);
            this.Controls.Add(this.Atan);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.Cube);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDifference);
            this.Controls.Add(this.buttonAmount);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Калькулятор ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonAmount;
        private System.Windows.Forms.Button buttonDifference;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Cube;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button Atan;
        private System.Windows.Forms.Button Fraction;
        private System.Windows.Forms.Button TenExp;
        private System.Windows.Forms.Button doubleDifSquare;
        private System.Windows.Forms.Button Ctan;
        private System.Windows.Forms.Button Arcsin;
        private System.Windows.Forms.Button Arccos;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Button difDivision;
        private System.Windows.Forms.Button amountCube;
        private System.Windows.Forms.Button difCube;
        private System.Windows.Forms.Button squareOfAmount;
        private System.Windows.Forms.Button doubleDifference;
        private System.Windows.Forms.Button doubleMultiply;
        private System.Windows.Forms.Button doubleDivision;
        private System.Windows.Forms.Button amountSquare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DoublAmount;
    }
}

