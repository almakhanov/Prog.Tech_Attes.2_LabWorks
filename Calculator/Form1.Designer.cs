namespace Calculator
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
            this.diplay = new System.Windows.Forms.TextBox();
            this.m_clear = new System.Windows.Forms.Button();
            this.m_plus = new System.Windows.Forms.Button();
            this.m_min = new System.Windows.Forms.Button();
            this.ms = new System.Windows.Forms.Button();
            this.divide_x = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.oper_divide = new System.Windows.Forms.Button();
            this.oper_div = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.Clear_all = new System.Windows.Forms.Button();
            this.oper_mult = new System.Windows.Forms.Button();
            this.digit9 = new System.Windows.Forms.Button();
            this.digit8 = new System.Windows.Forms.Button();
            this.digit7 = new System.Windows.Forms.Button();
            this.oper_minus = new System.Windows.Forms.Button();
            this.digit6 = new System.Windows.Forms.Button();
            this.digit5 = new System.Windows.Forms.Button();
            this.digit4 = new System.Windows.Forms.Button();
            this.oper_plus = new System.Windows.Forms.Button();
            this.digit3 = new System.Windows.Forms.Button();
            this.digit2 = new System.Windows.Forms.Button();
            this.digit1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.digit0 = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Button();
            this.MR = new System.Windows.Forms.Button();
            this.standart = new System.Windows.Forms.Label();
            this.equation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // diplay
            // 
            this.diplay.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diplay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.diplay.Location = new System.Drawing.Point(1, 65);
            this.diplay.Name = "diplay";
            this.diplay.Size = new System.Drawing.Size(266, 65);
            this.diplay.TabIndex = 0;
            this.diplay.Text = "0";
            this.diplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_clear
            // 
            this.m_clear.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m_clear.Location = new System.Drawing.Point(10, 134);
            this.m_clear.Name = "m_clear";
            this.m_clear.Size = new System.Drawing.Size(45, 22);
            this.m_clear.TabIndex = 1;
            this.m_clear.Text = "MC";
            this.m_clear.UseVisualStyleBackColor = true;
            this.m_clear.Click += new System.EventHandler(this.m_clear_Click);
            // 
            // m_plus
            // 
            this.m_plus.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m_plus.Location = new System.Drawing.Point(112, 134);
            this.m_plus.Name = "m_plus";
            this.m_plus.Size = new System.Drawing.Size(45, 22);
            this.m_plus.TabIndex = 2;
            this.m_plus.Text = "M+";
            this.m_plus.UseVisualStyleBackColor = true;
            this.m_plus.Click += new System.EventHandler(this.m_plus_Click);
            // 
            // m_min
            // 
            this.m_min.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m_min.Location = new System.Drawing.Point(163, 134);
            this.m_min.Name = "m_min";
            this.m_min.Size = new System.Drawing.Size(45, 22);
            this.m_min.TabIndex = 3;
            this.m_min.Text = "M-";
            this.m_min.UseVisualStyleBackColor = true;
            this.m_min.Click += new System.EventHandler(this.m_min_Click);
            // 
            // ms
            // 
            this.ms.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ms.Location = new System.Drawing.Point(214, 134);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(45, 22);
            this.ms.TabIndex = 4;
            this.ms.Text = "MS";
            this.ms.UseVisualStyleBackColor = true;
            this.ms.Click += new System.EventHandler(this.ms_Click);
            // 
            // divide_x
            // 
            this.divide_x.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divide_x.Location = new System.Drawing.Point(202, 158);
            this.divide_x.Name = "divide_x";
            this.divide_x.Size = new System.Drawing.Size(65, 52);
            this.divide_x.TabIndex = 8;
            this.divide_x.Text = "1/x";
            this.divide_x.UseVisualStyleBackColor = true;
            this.divide_x.Click += new System.EventHandler(this.divide_x_Click);
            this.divide_x.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.divide_x.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // square
            // 
            this.square.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.square.Location = new System.Drawing.Point(137, 158);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(69, 52);
            this.square.TabIndex = 7;
            this.square.Text = "x^2";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.square_Click);
            this.square.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.square.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // root
            // 
            this.root.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.root.Location = new System.Drawing.Point(69, 158);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(71, 52);
            this.root.TabIndex = 6;
            this.root.Text = "^1/2";
            this.root.UseVisualStyleBackColor = true;
            this.root.Click += new System.EventHandler(this.root_Click);
            this.root.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.root.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // mod
            // 
            this.mod.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mod.Location = new System.Drawing.Point(1, 158);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(72, 52);
            this.mod.TabIndex = 5;
            this.mod.Text = "%";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.Persentage);
            this.mod.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.mod.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // oper_divide
            // 
            this.oper_divide.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oper_divide.Location = new System.Drawing.Point(202, 209);
            this.oper_divide.Name = "oper_divide";
            this.oper_divide.Size = new System.Drawing.Size(65, 54);
            this.oper_divide.TabIndex = 12;
            this.oper_divide.Text = "/";
            this.oper_divide.UseVisualStyleBackColor = true;
            this.oper_divide.Click += new System.EventHandler(this.operands);
            this.oper_divide.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.oper_divide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // oper_div
            // 
            this.oper_div.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oper_div.Location = new System.Drawing.Point(137, 209);
            this.oper_div.Name = "oper_div";
            this.oper_div.Size = new System.Drawing.Size(69, 54);
            this.oper_div.TabIndex = 11;
            this.oper_div.Text = "div";
            this.oper_div.UseVisualStyleBackColor = true;
            this.oper_div.Click += new System.EventHandler(this.operands);
            this.oper_div.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.oper_div.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_clear.Location = new System.Drawing.Point(1, 209);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(72, 54);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "CE";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            this.btn_clear.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.btn_clear.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Clear_all
            // 
            this.Clear_all.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_all.Location = new System.Drawing.Point(69, 209);
            this.Clear_all.Name = "Clear_all";
            this.Clear_all.Size = new System.Drawing.Size(71, 54);
            this.Clear_all.TabIndex = 9;
            this.Clear_all.Text = "C";
            this.Clear_all.UseVisualStyleBackColor = true;
            this.Clear_all.Click += new System.EventHandler(this.Clear_all_Click);
            this.Clear_all.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.Clear_all.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // oper_mult
            // 
            this.oper_mult.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oper_mult.Location = new System.Drawing.Point(202, 260);
            this.oper_mult.Name = "oper_mult";
            this.oper_mult.Size = new System.Drawing.Size(65, 54);
            this.oper_mult.TabIndex = 16;
            this.oper_mult.Text = "x";
            this.oper_mult.UseVisualStyleBackColor = true;
            this.oper_mult.Click += new System.EventHandler(this.operands);
            this.oper_mult.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.oper_mult.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // digit9
            // 
            this.digit9.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit9.Location = new System.Drawing.Point(137, 260);
            this.digit9.Name = "digit9";
            this.digit9.Size = new System.Drawing.Size(69, 54);
            this.digit9.TabIndex = 15;
            this.digit9.Text = "9";
            this.digit9.UseVisualStyleBackColor = true;
            this.digit9.Click += new System.EventHandler(this.btn_Click);
            this.digit9.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.digit9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // digit8
            // 
            this.digit8.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit8.Location = new System.Drawing.Point(69, 260);
            this.digit8.Name = "digit8";
            this.digit8.Size = new System.Drawing.Size(71, 54);
            this.digit8.TabIndex = 14;
            this.digit8.Text = "8";
            this.digit8.UseVisualStyleBackColor = true;
            this.digit8.Click += new System.EventHandler(this.btn_Click);
            this.digit8.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.digit8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // digit7
            // 
            this.digit7.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit7.Location = new System.Drawing.Point(1, 260);
            this.digit7.Name = "digit7";
            this.digit7.Size = new System.Drawing.Size(72, 54);
            this.digit7.TabIndex = 13;
            this.digit7.Text = "7";
            this.digit7.UseVisualStyleBackColor = true;
            this.digit7.Click += new System.EventHandler(this.btn_Click);
            this.digit7.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.digit7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // oper_minus
            // 
            this.oper_minus.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oper_minus.Location = new System.Drawing.Point(202, 311);
            this.oper_minus.Name = "oper_minus";
            this.oper_minus.Size = new System.Drawing.Size(65, 54);
            this.oper_minus.TabIndex = 20;
            this.oper_minus.Text = "-";
            this.oper_minus.UseVisualStyleBackColor = true;
            this.oper_minus.Click += new System.EventHandler(this.operands);
            this.oper_minus.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.oper_minus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // digit6
            // 
            this.digit6.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit6.Location = new System.Drawing.Point(137, 311);
            this.digit6.Name = "digit6";
            this.digit6.Size = new System.Drawing.Size(69, 54);
            this.digit6.TabIndex = 19;
            this.digit6.Text = "6";
            this.digit6.UseVisualStyleBackColor = true;
            this.digit6.Click += new System.EventHandler(this.btn_Click);
            this.digit6.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.digit6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // digit5
            // 
            this.digit5.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit5.Location = new System.Drawing.Point(69, 311);
            this.digit5.Name = "digit5";
            this.digit5.Size = new System.Drawing.Size(71, 54);
            this.digit5.TabIndex = 18;
            this.digit5.Text = "5";
            this.digit5.UseVisualStyleBackColor = true;
            this.digit5.Click += new System.EventHandler(this.btn_Click);
            this.digit5.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.digit5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // digit4
            // 
            this.digit4.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit4.Location = new System.Drawing.Point(1, 311);
            this.digit4.Name = "digit4";
            this.digit4.Size = new System.Drawing.Size(72, 54);
            this.digit4.TabIndex = 17;
            this.digit4.Text = "4";
            this.digit4.UseVisualStyleBackColor = true;
            this.digit4.Click += new System.EventHandler(this.btn_Click);
            this.digit4.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.digit4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // oper_plus
            // 
            this.oper_plus.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oper_plus.Location = new System.Drawing.Point(202, 362);
            this.oper_plus.Name = "oper_plus";
            this.oper_plus.Size = new System.Drawing.Size(65, 54);
            this.oper_plus.TabIndex = 24;
            this.oper_plus.Text = "+";
            this.oper_plus.UseVisualStyleBackColor = true;
            this.oper_plus.Click += new System.EventHandler(this.operands);
            this.oper_plus.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.oper_plus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // digit3
            // 
            this.digit3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit3.Location = new System.Drawing.Point(137, 362);
            this.digit3.Name = "digit3";
            this.digit3.Size = new System.Drawing.Size(69, 54);
            this.digit3.TabIndex = 23;
            this.digit3.Text = "3";
            this.digit3.UseVisualStyleBackColor = true;
            this.digit3.Click += new System.EventHandler(this.btn_Click);
            this.digit3.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.digit3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // digit2
            // 
            this.digit2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit2.Location = new System.Drawing.Point(69, 362);
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(71, 54);
            this.digit2.TabIndex = 22;
            this.digit2.Text = "2";
            this.digit2.UseVisualStyleBackColor = true;
            this.digit2.Click += new System.EventHandler(this.btn_Click);
            this.digit2.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.digit2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // digit1
            // 
            this.digit1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit1.Location = new System.Drawing.Point(1, 362);
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(72, 54);
            this.digit1.TabIndex = 21;
            this.digit1.Text = "1";
            this.digit1.UseVisualStyleBackColor = true;
            this.digit1.Click += new System.EventHandler(this.btn_Click);
            this.digit1.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.digit1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(202, 413);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(65, 54);
            this.result.TabIndex = 28;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            this.result.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.result.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dot.Location = new System.Drawing.Point(137, 413);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(69, 54);
            this.dot.TabIndex = 27;
            this.dot.Text = ",";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            this.dot.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.dot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // digit0
            // 
            this.digit0.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit0.Location = new System.Drawing.Point(69, 413);
            this.digit0.Name = "digit0";
            this.digit0.Size = new System.Drawing.Size(71, 54);
            this.digit0.TabIndex = 26;
            this.digit0.Text = "0";
            this.digit0.UseVisualStyleBackColor = true;
            this.digit0.Click += new System.EventHandler(this.btn_Click);
            this.digit0.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.digit0.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // sign
            // 
            this.sign.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sign.Location = new System.Drawing.Point(1, 413);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(72, 54);
            this.sign.TabIndex = 25;
            this.sign.Text = "+/-";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            this.sign.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.sign.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // MR
            // 
            this.MR.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MR.Location = new System.Drawing.Point(61, 134);
            this.MR.Name = "MR";
            this.MR.Size = new System.Drawing.Size(45, 22);
            this.MR.TabIndex = 29;
            this.MR.Text = "MR";
            this.MR.UseVisualStyleBackColor = true;
            this.MR.Click += new System.EventHandler(this.MR_Click);
            // 
            // standart
            // 
            this.standart.AutoSize = true;
            this.standart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standart.Location = new System.Drawing.Point(41, 22);
            this.standart.Name = "standart";
            this.standart.Size = new System.Drawing.Size(99, 18);
            this.standart.TabIndex = 30;
            this.standart.Text = "STANDART";
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.equation.Location = new System.Drawing.Point(211, 44);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(0, 18);
            this.equation.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(266, 468);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.standart);
            this.Controls.Add(this.MR);
            this.Controls.Add(this.result);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.digit0);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.oper_plus);
            this.Controls.Add(this.digit3);
            this.Controls.Add(this.digit2);
            this.Controls.Add(this.digit1);
            this.Controls.Add(this.oper_minus);
            this.Controls.Add(this.digit6);
            this.Controls.Add(this.digit5);
            this.Controls.Add(this.digit4);
            this.Controls.Add(this.oper_mult);
            this.Controls.Add(this.digit9);
            this.Controls.Add(this.digit8);
            this.Controls.Add(this.digit7);
            this.Controls.Add(this.oper_divide);
            this.Controls.Add(this.oper_div);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.Clear_all);
            this.Controls.Add(this.divide_x);
            this.Controls.Add(this.square);
            this.Controls.Add(this.root);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.m_min);
            this.Controls.Add(this.m_plus);
            this.Controls.Add(this.m_clear);
            this.Controls.Add(this.diplay);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.operands);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox diplay;
        private System.Windows.Forms.Button m_clear;
        private System.Windows.Forms.Button m_plus;
        private System.Windows.Forms.Button m_min;
        private System.Windows.Forms.Button ms;
        private System.Windows.Forms.Button divide_x;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button oper_divide;
        private System.Windows.Forms.Button oper_div;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button Clear_all;
        private System.Windows.Forms.Button oper_mult;
        private System.Windows.Forms.Button digit9;
        private System.Windows.Forms.Button digit8;
        private System.Windows.Forms.Button digit7;
        private System.Windows.Forms.Button oper_minus;
        private System.Windows.Forms.Button digit6;
        private System.Windows.Forms.Button digit5;
        private System.Windows.Forms.Button digit4;
        private System.Windows.Forms.Button oper_plus;
        private System.Windows.Forms.Button digit3;
        private System.Windows.Forms.Button digit2;
        private System.Windows.Forms.Button digit1;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button digit0;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Button MR;
        private System.Windows.Forms.Label standart;
        private System.Windows.Forms.Label equation;
    }
}

