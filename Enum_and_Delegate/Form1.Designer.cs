namespace Enum_and_Delegate
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Label();
            this.equal = new System.Windows.Forms.Label();
            this.messenger = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Label();
            this.equate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num1.Location = new System.Drawing.Point(12, 12);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(75, 31);
            this.num1.TabIndex = 0;
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num2.Location = new System.Drawing.Point(165, 12);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(75, 31);
            this.num2.TabIndex = 1;
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.Location = new System.Drawing.Point(115, 18);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(24, 25);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equal.Location = new System.Drawing.Point(269, 15);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(0, 25);
            this.equal.TabIndex = 4;
            // 
            // messenger
            // 
            this.messenger.AutoSize = true;
            this.messenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messenger.Location = new System.Drawing.Point(12, 76);
            this.messenger.Name = "messenger";
            this.messenger.Size = new System.Drawing.Size(155, 25);
            this.messenger.TabIndex = 5;
            this.messenger.Text = "Enter Numbers";
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum.Location = new System.Drawing.Point(327, 15);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(24, 25);
            this.sum.TabIndex = 6;
            this.sum.Text = "?";
            // 
            // equate
            // 
            this.equate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equate.Location = new System.Drawing.Point(263, 12);
            this.equate.Name = "equate";
            this.equate.Size = new System.Drawing.Size(33, 31);
            this.equate.TabIndex = 7;
            this.equate.Text = "=";
            this.equate.UseVisualStyleBackColor = true;
            this.equate.Click += new System.EventHandler(this.equate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(424, 137);
            this.Controls.Add(this.equate);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.messenger);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.Label messenger;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.Button equate;
    }
}

