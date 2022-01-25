using GraphLibraryDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphsWorker
{
    public partial class ColorizedForm : Form
    {
        public Graph graph;
        public Image image;
        public int defaultScale = 600;
        public ColorizableGraph colorizableGraph = null;

        public ColorizedForm(Graph graph)
        {
            this.graph = graph;
            InitializeComponent();
        }

        private void buttonColorizeVertices_Click(object sender, EventArgs e)
        {
            this.colorizableGraph = new ColorizableGraph(this.graph);
            bool isCorrect = this.colorizableGraph.colorizeVertices();
            if (isCorrect)
            {
                this.buttonDisplayGraph_Click(null, EventArgs.Empty);
            } else
            {
                MessageBox.Show("Произошла ошибка при раскраске графа.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonColorizeEdges_Click(object sender, EventArgs e)
        {
            this.colorizableGraph = new ColorizableGraph(this.graph);
            bool isCorrect = this.colorizableGraph.colorizeEdges();
            if (isCorrect)
            {
                this.buttonDisplayGraph_Click(null, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Произошла ошибка при раскраске графа.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonColorizeTotal_Click(object sender, EventArgs e)
        {
            this.colorizableGraph = new ColorizableGraph(this.graph);
            bool isCorrect = this.colorizableGraph.colorizeTotal();
            if (isCorrect)
            {
                this.buttonDisplayGraph_Click(null, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Произошла ошибка при раскраске графа.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDisplayGraph_Click(object sender, EventArgs e)
        {
            if (this.graph == null)
            {
                MessageBox.Show("Необходимо загрузить граф.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //do graphics
            var graphDrawer = new GraphDrawer();
            graphDrawer.calculateImageFromGraph(this.graph);
            graphDrawer.generateColorizedGraphImage(this.colorizableGraph);
            this.image = graphDrawer.getImage();

            this.pictureBoxGraph.SizeMode = PictureBoxSizeMode.Zoom;
            this.trackBarGraphImageZoom.Value = 0;
            this.pictureBoxGraph.Image = this.image;
            this.pictureBoxGraph.Dock = DockStyle.Fill;
        }

        private void trackBarGraphImageZoom_ValueChanged(object sender, EventArgs e)
        {
            if (this.image == null)
            {
                return;
            }

            TrackBar bar = (TrackBar)sender;
            int value = bar.Value;
            if (value == 0)
            {
                this.pictureBoxGraph.SizeMode = PictureBoxSizeMode.Zoom;
                this.trackBarGraphImageZoom.Value = 0;
                this.pictureBoxGraph.Image = this.image;
                this.pictureBoxGraph.Dock = DockStyle.Fill;
            }
            else
            {
                this.pictureBoxGraph.Dock = DockStyle.None;
                this.pictureBoxGraph.SizeMode = PictureBoxSizeMode.AutoSize;
                Bitmap img = new Bitmap(image,
                    Convert.ToInt32((double)1000.0 * 6.0 * (double)value / 100.0),
                    Convert.ToInt32((double)1000.0 * 6.0 * (double)value / 100.0));
                Graphics.FromImage(img).InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                this.pictureBoxGraph.Image = img;
            }
        }
    }
}
