using GraphLibraryDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphsWorker
{
    public partial class DijkstraForm : Form
    {
        public Graph graph;
        public Image image;
        public int defaultScale = 600;
        public DijkstraGraph dijkstraGraph = null;
        public int targetId = -1;

        public DijkstraForm(Graph graph)
        {
            this.graph = graph;
            InitializeComponent();
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

        private void buttonDisplayGraph_Click(object sender, EventArgs e)
        {
            if (this.graph == null)
            {
                MessageBox.Show("Необходимо загрузить граф.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //do graphics
            if (this.targetId < 0 || this.targetId > this.graph.getVertices().Count()) 
            {
                MessageBox.Show("Произошла ошибка.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var graphDrawer = new GraphDrawer();
            graphDrawer.calculateImageFromGraph(this.graph);
            graphDrawer.generateGraphImage(false);
            graphDrawer.generateDijkstraGraphImage(this.dijkstraGraph, this.targetId);
            this.image = graphDrawer.getImage();

            this.pictureBoxGraph.SizeMode = PictureBoxSizeMode.Zoom;
            this.trackBarGraphImageZoom.Value = 0;
            this.pictureBoxGraph.Image = this.image;
            this.pictureBoxGraph.Dock = DockStyle.Fill;
        }

        private void buttonHandleSourceVertex_Click(object sender, EventArgs e)
        {
            this.dijkstraGraph = new DijkstraGraph(this.graph);
            int sourceId = Decimal.ToInt32(this.numericUpDownGraphSourceVertexID.Value);

            bool isCorrect = dijkstraGraph.calculateDijkstraFrom(sourceId);
            if (!isCorrect)
            {
                MessageBox.Show("Произошла ошибка.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHandleTargetVertex_Click(object sender, EventArgs e)
        {
            this.targetId = Decimal.ToInt32(this.numericUpDownGraphTargetVertexID.Value);
            this.buttonDisplayGraph_Click(null, EventArgs.Empty);
        }
    }
}
