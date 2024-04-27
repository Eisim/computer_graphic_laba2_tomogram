namespace laba_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.glControl1 = new OpenTK.GLControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимОтображенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текущийРежимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.четырехугольникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quadStripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TF_min = new System.Windows.Forms.TrackBar();
            this.TF_width = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TF_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TF_width)).BeginInit();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(13, 28);
            this.glControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(787, 438);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.режимОтображенияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // режимОтображенияToolStripMenuItem
            // 
            this.режимОтображенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.текущийРежимToolStripMenuItem});
            this.режимОтображенияToolStripMenuItem.Name = "режимОтображенияToolStripMenuItem";
            this.режимОтображенияToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.режимОтображенияToolStripMenuItem.Text = "Режим отображения";
            this.режимОтображенияToolStripMenuItem.Click += new System.EventHandler(this.режимОтображенияToolStripMenuItem_Click);
            // 
            // текущийРежимToolStripMenuItem
            // 
            this.текущийРежимToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.четырехугольникиToolStripMenuItem,
            this.текстураToolStripMenuItem,
            this.quadStripToolStripMenuItem});
            this.текущийРежимToolStripMenuItem.Name = "текущийРежимToolStripMenuItem";
            this.текущийРежимToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.текущийРежимToolStripMenuItem.Text = "текущий режим";
            this.текущийРежимToolStripMenuItem.Click += new System.EventHandler(this.текущийРежимToolStripMenuItem_Click);
            // 
            // четырехугольникиToolStripMenuItem
            // 
            this.четырехугольникиToolStripMenuItem.Name = "четырехугольникиToolStripMenuItem";
            this.четырехугольникиToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.четырехугольникиToolStripMenuItem.Text = "четырехугольники";
            this.четырехугольникиToolStripMenuItem.Click += new System.EventHandler(this.четырехугольникиToolStripMenuItem_Click);
            // 
            // текстураToolStripMenuItem
            // 
            this.текстураToolStripMenuItem.Name = "текстураToolStripMenuItem";
            this.текстураToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.текстураToolStripMenuItem.Text = "текстура";
            this.текстураToolStripMenuItem.Click += new System.EventHandler(this.текстураToolStripMenuItem_Click);
            // 
            // quadStripToolStripMenuItem
            // 
            this.quadStripToolStripMenuItem.Name = "quadStripToolStripMenuItem";
            this.quadStripToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.quadStripToolStripMenuItem.Text = "QuadStrip";
            this.quadStripToolStripMenuItem.Click += new System.EventHandler(this.quadStripToolStripMenuItem_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(105, 473);
            this.trackBar1.Maximum = 0;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(695, 56);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "TF min:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "TF width:";
            // 
            // TF_min
            // 
            this.TF_min.Location = new System.Drawing.Point(105, 513);
            this.TF_min.Maximum = 254;
            this.TF_min.Name = "TF_min";
            this.TF_min.Size = new System.Drawing.Size(682, 56);
            this.TF_min.TabIndex = 5;
            this.TF_min.Scroll += new System.EventHandler(this.TF_min_Scroll);
            // 
            // TF_width
            // 
            this.TF_width.Location = new System.Drawing.Point(105, 564);
            this.TF_width.Maximum = 255;
            this.TF_width.Minimum = 1;
            this.TF_width.Name = "TF_width";
            this.TF_width.Size = new System.Drawing.Size(682, 56);
            this.TF_width.TabIndex = 6;
            this.TF_width.Value = 1;
            this.TF_width.Scroll += new System.EventHandler(this.TF_width_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Слой:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TF_width);
            this.Controls.Add(this.TF_min);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TF_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TF_width)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripMenuItem режимОтображенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текущийРежимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem четырехугольникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текстураToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar TF_min;
        private System.Windows.Forms.TrackBar TF_width;
        private System.Windows.Forms.ToolStripMenuItem quadStripToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

