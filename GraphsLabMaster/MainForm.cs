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
    public partial class MainForm : Form
    {
        public Graph graph;
        public Image image;
        public int defaultScale = 600;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonReadGraphFromFile_Click(object sender, EventArgs e)
        {
            if (this.openFileDialogGraph.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filename = this.openFileDialogGraph.FileName;

            if (this.graph == null)
            {
                this.graph = new Graph();
            }
            bool isCorrect = this.graph.generateGraphFromFile(filename);

            if (isCorrect)
            {
                this.checkBoxIsGraphOriented.Checked = this.graph.isOriented;
                this.checkBoxIsGraphWeighted.Checked = this.graph.isWeighted;
                int graphVeticesCount = this.graph.getVerticesCount();
                if (this.numericUpDownGraphVertexCount.Maximum < graphVeticesCount)
                    this.numericUpDownGraphVertexCount.Value = this.numericUpDownGraphVertexCount.Maximum;
                else if (this.numericUpDownGraphVertexCount.Minimum > graphVeticesCount)
                    this.numericUpDownGraphVertexCount.Value = this.numericUpDownGraphVertexCount.Minimum;
                else
                    this.numericUpDownGraphVertexCount.Value = graphVeticesCount;

                MessageBox.Show("Граф успешно загружен.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.buttonDisplayGraph_Click(null, EventArgs.Empty);
            }
            else
            {
                this.graph = null;
                MessageBox.Show("Произошла ошибка при загрузке графа.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonWriteGraphToFile_Click(object sender, EventArgs e)
        {
            if (this.graph == null)
            {
                MessageBox.Show("Граф не создан.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this.saveFileDialogGraph.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string filename = this.saveFileDialogGraph.FileName;


            bool isCorrect = this.graph.saveGraphToFile(filename);

            if (isCorrect)
            {
                MessageBox.Show("Граф успешно сохранен.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Произошла ошибка при записи графа.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGenerateGraph_Click(object sender, EventArgs e)
        {
            bool isOriented = this.checkBoxIsGraphOriented.Checked;
            bool isWeighted = this.checkBoxIsGraphWeighted.Checked;
            int size = Decimal.ToInt32(this.numericUpDownGraphVertexCount.Value);

            this.graph = new Graph();
            this.graph.generateRandomGraph(isOriented, isWeighted, size);

            this.buttonDisplayGraph_Click(null, EventArgs.Empty);
        }

        private void buttonDisplayGraph_Click(object sender, EventArgs e)
        {
            if (this.graph == null)
            {
                MessageBox.Show("Необходимо загрузить граф.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var graphDrawer = new GraphDrawer();
            graphDrawer.calculateImageFromGraph(this.graph);
            graphDrawer.generateGraphImage(true);
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

        private void buttonDijkstraGraph_Click(object sender, EventArgs e)
        {
            if (this.graph == null)
            {
                MessageBox.Show("Сначала нужно создать граф.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form form = new DijkstraForm(this.graph);
            form.Owner = this;
            form.ShowDialog();
        }

        private void buttonColorizableGraph_Click(object sender, EventArgs e)
        {
            if (this.graph == null)
            {
                MessageBox.Show("Сначала нужно создать граф.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form form = new ColorizedForm(this.graph);
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
