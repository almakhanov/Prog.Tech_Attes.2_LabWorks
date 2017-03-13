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
            this.SuspendLayout();
            // 
            // diplay
            // 
            this.diplay.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diplay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.diplay.Location = new System.Drawing.Point(13, 13);
            this.diplay.Name = "diplay";
            this.diplay.Size = new System.Drawing.Size(222, 39);
            this.diplay.TabIndex = 0;
            this.diplay.Text = "0";
            this.diplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_clear
            // 
            this.m_clear.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m_clear.Location = new System.Drawing.Point(13, 58);
            this.m_clear.Name = "m_clear";
            this.m_clear.Size = new System.Drawing.Size(51, 26);
            this.m_clear.TabIndex = 1;
            this.m_clear.Text = "MC";
            this.m_clear.UseVisualStyleBackColor = true;
            this.m_clear.Click += new System.EventHandler(this.m_clear_Click);
            // 
            // m_plus
            // 
            this.m_plus.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m_plus.Location = new System.Drawing.Point(70, 58);
            this.m_plus.Name = "m_plus";
            this.m_plus.Size = new System.Drawing.Size(51, 26);
            this.m_plus.TabIndex = 2;
            this.m_plus.Text = "M+";
            this.m_plus.UseVisualStyleBackColor = true;
            this.m_plus.Click += new System.EventHandler(this.m_plus_Click);
            // 
            // m_min
            // 
            this.m_min.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m_min.Location = new System.Drawing.Point(127, 58);
            this.m_min.Name = "m_min";
            this.m_min.Size = new System.Drawing.Size(51, 26);
            this.m_min.TabIndex = 3;
            this.m_min.Text = "M-";
            this.m_min.UseVisualStyleBackColor = true;
            this.m_min.Click += new System.EventHandler(this.m_min_Click);
            // 
            // ms
            // 
            this.ms.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ms.Location = new System.Drawing.Point(184, 58);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(51, 26);
            this.ms.TabIndex = 4;
            this.ms.Text = "MS";
            this.ms.UseVisualStyleBackColor = true;
            this.ms.Click += new System.EventHandler(this.ms_Click);
            // 
            // divide_x
            // 
            this.divide_x.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide_x.Location = new System.Drawing.Point(184, 87);
            this.divide_x.Name = "divide_x";
            this.divide_x.Size = new System.Drawing.Size(51, 45);
            this.divide_x.TabIndex = 8;
            this.divide_x.Text = "1/x";
            this.divide_x.UseVisualStyleBackColor = true;
            this.divide_x.Click += new System.EventHandler(this.divide_x_Click);
            // 
            // square
            // 
            this.square.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.square.Location = new System.Drawing.Point(127, 87);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(51, 45);
            this.square.TabIndex = 7;
            this.square.Text = "x^2";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // root
            // 
            this.root.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.root.Location = new System.Drawing.Point(70, 89);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(51, 45);
            this.root.TabIndex = 6;
            this.root.Text = "^1/2";
            this.root.UseVisualStyleBackColor = true;
            this.root.Click += new System.EventHandler(this.root_Click);
            // 
            // mod
            // 
            this.mod.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mod.Location = new System.Drawing.Point(13, 87);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(51, 45);
            this.mod.TabIndex = 5;
            this.mod.Text = "%";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.operands);
            // 
            // oper_divide
            // 
            this.oper_divide.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oper_divide.Location = new System.Drawing.Point(184, 140);
            this.oper_divide.Name = "oper_divide";
            this.oper_divide.Size = new System.Drawing.Size(51, 45);
            this.oper_divide.TabIndex = 12;
            this.oper_divide.Text = "/";
            this.oper_divide.UseVisualStyleBackColor = true;
            this.oper_divide.Click += new System.EventHandler(this.operands);
            // 
            // oper_div
            // 
            this.oper_div.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oper_div.Location = new System.Drawing.Point(127, 140);
            this.oper_div.Name = "oper_div";
            this.oper_div.Size = new System.Drawing.Size(51, 45);
            this.oper_div.TabIndex = 11;
            this.oper_div.Text = "div";
            this.oper_div.UseVisualStyleBackColor = true;
            this.oper_div.Click += new System.EventHandler(this.operands);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(70, 140);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(51, 45);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Clear_all
            // 
            this.Clear_all.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_all.Location = new System.Drawing.Point(13, 140);
            this.Clear_all.Name = "Clear_all";
            this.Clear_all.Size = new System.Drawing.Size(51, 45);
            this.Clear_all.TabIndex = 9;
            this.Clear_all.Text = "CE";
            this.Clear_all.UseVisualStyleBackColor = true;
            this.Clear_all.Click += new System.EventHandler(this.Clear_all_Click);
            // 
            // oper_mult
            // 
            this.oper_mult.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oper_mult.Location = new System.Drawing.Point(184, 191);
            this.oper_mult.Name = "oper_mult";
            this.oper_mult.Size = new System.Drawing.Size(51, 45);
            this.oper_mult.TabIndex = 16;
            this.oper_mult.Text = "x";
            this.oper_mult.UseVisualStyleBackColor = true;
            this.oper_mult.Click += new System.EventHandler(this.operands);
            // 
            // digit9
            // 
            this.digit9.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit9.Location = new System.Drawing.Point(127, 191);
            this.digit9.Name = "digit9";
            this.digit9.Size = new System.Drawing.Size(51, 45);
            this.digit9.TabIndex = 15;
            this.digit9.Text = "9";
            this.digit9.UseVisualStyleBackColor = true;
            this.digit9.Click += new System.EventHandler(this.btn_Click);
            // 
            // digit8
            // 
            this.digit8.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit8.Location = new System.Drawing.Point(70, 191);
            this.digit8.Name = "digit8";
            this.digit8.Size = new System.Drawing.Size(51, 45);
            this.digit8.TabIndex = 14;
            this.digit8.Text = "8";
            this.digit8.UseVisualStyleBackColor = true;
            this.digit8.Click += new System.EventHandler(this.btn_Click);
            // 
            // digit7
            // 
            this.digit7.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit7.Location = new System.Drawing.Point(13, 191);
            this.digit7.Name = "digit7";
            this.digit7.Size = new System.Drawing.Size(51, 45);
            this.digit7.TabIndex = 13;
            this.digit7.Text = "7";
            this.digit7.UseVisualStyleBackColor = true;
            this.digit7.Click += new System.EventHandler(this.btn_Click);
            // 
            // oper_minus
            // 
            this.oper_minus.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oper_minus.Location = new System.Drawing.Point(184, 242);
            this.oper_minus.Name = "oper_minus";
            this.oper_minus.Size = new System.Drawing.Size(51, 45);
            this.oper_minus.TabIndex = 20;
            this.oper_minus.Text = "-";
            this.oper_minus.UseVisualStyleBackColor = true;
            this.oper_minus.Click += new System.EventHandler(this.operands);
            // 
            // digit6
            // 
            this.digit6.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit6.Location = new System.Drawing.Point(127, 242);
            this.digit6.Name = "digit6";
            this.digit6.Size = new System.Drawing.Size(51, 45);
            this.digit6.TabIndex = 19;
            this.digit6.Text = "6";
            this.digit6.UseVisualStyleBackColor = true;
            this.digit6.Click += new System.EventHandler(this.btn_Click);
            // 
            // digit5
            // 
            this.digit5.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit5.Location = new System.Drawing.Point(70, 242);
            this.digit5.Name = "digit5";
            this.digit5.Size = new System.Drawing.Size(51, 45);
            this.digit5.TabIndex = 18;
            this.digit5.Text = "5";
            this.digit5.UseVisualStyleBackColor = true;
            this.digit5.Click += new System.EventHandler(this.btn_Click);
            // 
            // digit4
            // 
            this.digit4.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit4.Location = new System.Drawing.Point(13, 242);
            this.digit4.Name = "digit4";
            this.digit4.Size = new System.Drawing.Size(51, 45);
            this.digit4.TabIndex = 17;
            this.digit4.Text = "4";
            this.digit4.UseVisualStyleBackColor = true;
            this.digit4.Click += new System.EventHandler(this.btn_Click);
            // 
            // oper_plus
            // 
            this.oper_plus.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oper_plus.Location = new System.Drawing.Point(184, 293);
            this.oper_plus.Name = "oper_plus";
            this.oper_plus.Size = new System.Drawing.Size(51, 45);
            this.oper_plus.TabIndex = 24;
            this.oper_plus.Text = "+";
            this.oper_plus.UseVisualStyleBackColor = true;
            this.oper_plus.Click += new System.EventHandler(this.operands);
            // 
            // digit3
            // 
            this.digit3.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit3.Location = new System.Drawing.Point(127, 293);
            this.digit3.Name = "digit3";
            this.digit3.Size = new System.Drawing.Size(51, 45);
            this.digit3.TabIndex = 23;
            this.digit3.Text = "3";
            this.digit3.UseVisualStyleBackColor = true;
            this.digit3.Click += new System.EventHandler(this.btn_Click);
            // 
            // digit2
            // 
            this.digit2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit2.Location = new System.Drawing.Point(70, 293);
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(51, 45);
            this.digit2.TabIndex = 22;
            this.digit2.Text = "2";
            this.digit2.UseVisualStyleBackColor = true;
            this.digit2.Click += new System.EventHandler(this.btn_Click);
            // 
            // digit1
            // 
            this.digit1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit1.Location = new System.Drawing.Point(13, 293);
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(51, 45);
            this.digit1.TabIndex = 21;
            this.digit1.Text = "1";
            this.digit1.UseVisualStyleBackColor = true;
            this.digit1.Click += new System.EventHandler(this.btn_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(184, 344);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(51, 45);
            this.result.TabIndex = 28;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.Location = new System.Drawing.Point(127, 344);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(51, 45);
            this.dot.TabIndex = 27;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // digit0
            // 
            this.digit0.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit0.Location = new System.Drawing.Point(70, 344);
            this.digit0.Name = "digit0";
            this.digit0.Size = new System.Drawing.Size(51, 45);
            this.digit0.TabIndex = 26;
            this.digit0.Text = "0";
            this.digit0.UseVisualStyleBackColor = true;
            this.digit0.Click += new System.EventHandler(this.btn_Click);
            // 
            // sign
            // 
            this.sign.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign.Location = new System.Drawing.Point(13, 344);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(51, 45);
            this.sign.TabIndex = 25;
            this.sign.Text = "+/-";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 393);
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
    }
}

