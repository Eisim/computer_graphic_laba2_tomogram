using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_2
{
    public partial class Form1 : Form
    {
        Bin bin;
        bool loaded;
        View view;
        int currentLayer;

        int FrameCount;
        DateTime NextFPSUpdate = DateTime.Now.AddSeconds(1);
        public Form1()
        {
            InitializeComponent();
            texture_mode = true;
            bin = new Bin();
            loaded = false;
            view = new View();
            currentLayer = 0;
            needReload = true;
        }
        void displayFPS()
        {
            if(DateTime.Now >= NextFPSUpdate)
            {
                this.Text = String.Format("CT Visualizer (fps = {0}", FrameCount);
                NextFPSUpdate = DateTime.Now.AddSeconds(1);
                FrameCount = 0;
            }
            FrameCount++;
        }
        void Application_Idle(object sender, EventArgs e)
        {
            while (glControl1.IsIdle)
            {
                displayFPS();
                glControl1.Invalidate(); 
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Application.Idle += Application_Idle;
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (DialogResult.OK == ofd.ShowDialog())
            {
                string str = ofd.FileName;
                bin.readBIN(str);
                view.SetupView(glControl1.Width, glControl1.Height);
                loaded = true;
                glControl1.Invalidate();
                trackBar1.Maximum = Bin.Z-1;
            }
        }

        private void glControl1_Load(object sender, EventArgs e)
        {

        }

        bool needReload = false;
        bool texture_mode = true;
        bool quadrangle_mode = false;
        bool quadStrip_mode = false;

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (loaded)
            {
                if(quadrangle_mode)
                    view.DrawQuads(currentLayer);
                if(quadStrip_mode)
                    view.DrawQuadStrip(currentLayer);
                if (needReload && texture_mode)
                {
                    view.generateTextureImage(currentLayer);
                    view.Load2DTexture();
                    needReload = false;
                }
                if (texture_mode)
                    view.DrawTexture();
                
                glControl1.SwapBuffers();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentLayer = trackBar1.Value;
            needReload = true;
            glControl1.Invalidate();
            label3.Text = $"Слой: {currentLayer}";
        }

        private void текущийРежимToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void режимОтображенияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void текстураToolStripMenuItem_Click(object sender, EventArgs e)
        {
            texture_mode = true;
            quadrangle_mode = false;
            quadStrip_mode = false;


            текущийРежимToolStripMenuItem.Text = "тек. реж.: текстура";
        }
        private void quadStripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            texture_mode = false;
            quadrangle_mode = false;
            quadStrip_mode = true;
            текущийРежимToolStripMenuItem.Text = "тек. реж.: QuadStrip";
        }
        private void четырехугольникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            texture_mode = false;
            quadrangle_mode = true;
            quadStrip_mode = false;

            текущийРежимToolStripMenuItem.Text = "тек. реж.: 4-х уг-ки";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TF_min_Scroll(object sender, EventArgs e)
        {
            TF_width.Maximum = 255 - TF_min.Value;
            view.TF_min = TF_min.Value;
            needReload = true;
            label1.Text = $"TF_min: {TF_min.Value}";
            label2.Text = $"TF_width: {TF_width.Value}";

        }

        private void TF_width_Scroll(object sender, EventArgs e)
        {
            view.TF_width = TF_width.Value;
            needReload = true;
            label2.Text = $"TF_width: {TF_width.Value}";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
