namespace Paint
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
            this.paper = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MouseLocation = new System.Windows.Forms.ToolStripLabel();
            this.BrushBtn = new System.Windows.Forms.Button();
            this.ColorBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineBtn = new System.Windows.Forms.Button();
            this.RectBtn = new System.Windows.Forms.Button();
            this.PenSizeBtn = new System.Windows.Forms.TrackBar();
            this.TrianBtn = new System.Windows.Forms.Button();
            this.EllipseBtn = new System.Windows.Forms.Button();
            this.FloodBtn = new System.Windows.Forms.Button();
            this.ColorShow = new System.Windows.Forms.PictureBox();
            this.EraseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PenSizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorShow)).BeginInit();
            this.SuspendLayout();
            // 
            // paper
            // 
            this.paper.BackColor = System.Drawing.Color.White;
            this.paper.Location = new System.Drawing.Point(100, 31);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(434, 342);
            this.paper.TabIndex = 0;
            this.paper.TabStop = false;
            this.paper.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.paper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paper_MouseDown);
            this.paper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paper_MouseMove);
            this.paper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paper_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MouseLocation});
            this.toolStrip1.Location = new System.Drawing.Point(0, 375);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(534, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MouseLocation
            // 
            this.MouseLocation.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MouseLocation.Name = "MouseLocation";
            this.MouseLocation.Size = new System.Drawing.Size(100, 22);
            this.MouseLocation.Text = "MouseLocation";
            // 
            // BrushBtn
            // 
            this.BrushBtn.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrushBtn.Location = new System.Drawing.Point(0, 30);
            this.BrushBtn.Name = "BrushBtn";
            this.BrushBtn.Size = new System.Drawing.Size(99, 31);
            this.BrushBtn.TabIndex = 2;
            this.BrushBtn.Text = "Brush";
            this.BrushBtn.UseVisualStyleBackColor = true;
            this.BrushBtn.Click += new System.EventHandler(this.BrushBtn_Click);
            // 
            // ColorBtn
            // 
            this.ColorBtn.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorBtn.Location = new System.Drawing.Point(0, 56);
            this.ColorBtn.Name = "ColorBtn";
            this.ColorBtn.Size = new System.Drawing.Size(99, 31);
            this.ColorBtn.TabIndex = 3;
            this.ColorBtn.Text = "Colors";
            this.ColorBtn.UseVisualStyleBackColor = true;
            this.ColorBtn.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 29);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 25);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // LineBtn
            // 
            this.LineBtn.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineBtn.Location = new System.Drawing.Point(0, 84);
            this.LineBtn.Name = "LineBtn";
            this.LineBtn.Size = new System.Drawing.Size(99, 31);
            this.LineBtn.TabIndex = 5;
            this.LineBtn.Text = "Line";
            this.LineBtn.UseVisualStyleBackColor = true;
            this.LineBtn.Click += new System.EventHandler(this.LineBtn_Click);
            // 
            // RectBtn
            // 
            this.RectBtn.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RectBtn.Location = new System.Drawing.Point(0, 112);
            this.RectBtn.Name = "RectBtn";
            this.RectBtn.Size = new System.Drawing.Size(99, 31);
            this.RectBtn.TabIndex = 6;
            this.RectBtn.Text = "Rectangle";
            this.RectBtn.UseVisualStyleBackColor = true;
            this.RectBtn.Click += new System.EventHandler(this.RectBtn_Click);
            // 
            // PenSizeBtn
            // 
            this.PenSizeBtn.Location = new System.Drawing.Point(0, 285);
            this.PenSizeBtn.Minimum = 1;
            this.PenSizeBtn.Name = "PenSizeBtn";
            this.PenSizeBtn.Size = new System.Drawing.Size(99, 45);
            this.PenSizeBtn.TabIndex = 7;
            this.PenSizeBtn.Value = 1;
            this.PenSizeBtn.Scroll += new System.EventHandler(this.PenSizeBtn_Scroll);
            // 
            // TrianBtn
            // 
            this.TrianBtn.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrianBtn.Location = new System.Drawing.Point(0, 141);
            this.TrianBtn.Name = "TrianBtn";
            this.TrianBtn.Size = new System.Drawing.Size(99, 31);
            this.TrianBtn.TabIndex = 8;
            this.TrianBtn.Text = "Triangle";
            this.TrianBtn.UseVisualStyleBackColor = true;
            this.TrianBtn.Click += new System.EventHandler(this.TrianBtn_Click);
            // 
            // EllipseBtn
            // 
            this.EllipseBtn.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EllipseBtn.Location = new System.Drawing.Point(0, 170);
            this.EllipseBtn.Name = "EllipseBtn";
            this.EllipseBtn.Size = new System.Drawing.Size(99, 31);
            this.EllipseBtn.TabIndex = 9;
            this.EllipseBtn.Text = "Ellipse";
            this.EllipseBtn.UseVisualStyleBackColor = true;
            this.EllipseBtn.Click += new System.EventHandler(this.EllipseBtn_Click);
            // 
            // FloodBtn
            // 
            this.FloodBtn.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FloodBtn.Location = new System.Drawing.Point(0, 199);
            this.FloodBtn.Name = "FloodBtn";
            this.FloodBtn.Size = new System.Drawing.Size(99, 31);
            this.FloodBtn.TabIndex = 10;
            this.FloodBtn.Text = "FloodFill";
            this.FloodBtn.UseVisualStyleBackColor = true;
            this.FloodBtn.Click += new System.EventHandler(this.FloodBtn_Click);
            // 
            // ColorShow
            // 
            this.ColorShow.BackColor = System.Drawing.Color.Black;
            this.ColorShow.Location = new System.Drawing.Point(8, 335);
            this.ColorShow.Name = "ColorShow";
            this.ColorShow.Size = new System.Drawing.Size(82, 31);
            this.ColorShow.TabIndex = 11;
            this.ColorShow.TabStop = false;
            // 
            // EraseBtn
            // 
            this.EraseBtn.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EraseBtn.Location = new System.Drawing.Point(0, 229);
            this.EraseBtn.Name = "EraseBtn";
            this.EraseBtn.Size = new System.Drawing.Size(99, 31);
            this.EraseBtn.TabIndex = 12;
            this.EraseBtn.Text = "Eraser";
            this.EraseBtn.UseVisualStyleBackColor = true;
            this.EraseBtn.Click += new System.EventHandler(this.EraseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "PenSize: 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Color";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(534, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EraseBtn);
            this.Controls.Add(this.ColorShow);
            this.Controls.Add(this.FloodBtn);
            this.Controls.Add(this.EllipseBtn);
            this.Controls.Add(this.TrianBtn);
            this.Controls.Add(this.PenSizeBtn);
            this.Controls.Add(this.RectBtn);
            this.Controls.Add(this.LineBtn);
            this.Controls.Add(this.ColorBtn);
            this.Controls.Add(this.BrushBtn);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.paper);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paper)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PenSizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox paper;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel MouseLocation;
        private System.Windows.Forms.Button BrushBtn;
        private System.Windows.Forms.Button ColorBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button LineBtn;
        private System.Windows.Forms.Button RectBtn;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TrackBar PenSizeBtn;
        private System.Windows.Forms.Button TrianBtn;
        private System.Windows.Forms.Button EllipseBtn;
        private System.Windows.Forms.Button FloodBtn;
        private System.Windows.Forms.PictureBox ColorShow;
        private System.Windows.Forms.Button EraseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}

