
namespace GraphsWorker
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDisplayGraph = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonGenerateGraph = new System.Windows.Forms.Button();
            this.checkBoxIsGraphWeighted = new System.Windows.Forms.CheckBox();
            this.checkBoxIsGraphOriented = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownGraphVertexCount = new System.Windows.Forms.NumericUpDown();
            this.buttonWriteGraphToFile = new System.Windows.Forms.Button();
            this.buttonReadGraphFromFile = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonColorizableGraph = new System.Windows.Forms.Button();
            this.buttonDijkstraGraph = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewAdjacencyMatrix = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewAdjacencyStructure = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridViewWeigthMatrix = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBarGraphImageZoom = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxGraph = new System.Windows.Forms.PictureBox();
            this.openFileDialogGraph = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogGraph = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraphVertexCount)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdjacencyMatrix)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdjacencyStructure)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeigthMatrix)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGraphImageZoom)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1079, 553);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(294, 527);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "управление графом";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.buttonDisplayGraph, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonWriteGraphToFile, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonReadGraphFromFile, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(288, 498);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonDisplayGraph
            // 
            this.buttonDisplayGraph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDisplayGraph.AutoSize = true;
            this.buttonDisplayGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDisplayGraph.Location = new System.Drawing.Point(3, 434);
            this.buttonDisplayGraph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDisplayGraph.Name = "buttonDisplayGraph";
            this.buttonDisplayGraph.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.buttonDisplayGraph.Size = new System.Drawing.Size(282, 60);
            this.buttonDisplayGraph.TabIndex = 3;
            this.buttonDisplayGraph.Text = "отобразить граф";
            this.buttonDisplayGraph.UseVisualStyleBackColor = true;
            this.buttonDisplayGraph.Click += new System.EventHandler(this.buttonDisplayGraph_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 140);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(282, 286);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "генерация графа";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.buttonGenerateGraph, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxIsGraphWeighted, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.checkBoxIsGraphOriented, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(276, 257);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // buttonGenerateGraph
            // 
            this.buttonGenerateGraph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerateGraph.AutoSize = true;
            this.buttonGenerateGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonGenerateGraph.Location = new System.Drawing.Point(3, 193);
            this.buttonGenerateGraph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGenerateGraph.Name = "buttonGenerateGraph";
            this.buttonGenerateGraph.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.buttonGenerateGraph.Size = new System.Drawing.Size(270, 60);
            this.buttonGenerateGraph.TabIndex = 3;
            this.buttonGenerateGraph.Text = "генерировать граф";
            this.buttonGenerateGraph.UseVisualStyleBackColor = true;
            this.buttonGenerateGraph.Click += new System.EventHandler(this.buttonGenerateGraph_Click);
            // 
            // checkBoxIsGraphWeighted
            // 
            this.checkBoxIsGraphWeighted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxIsGraphWeighted.AutoSize = true;
            this.checkBoxIsGraphWeighted.Location = new System.Drawing.Point(3, 66);
            this.checkBoxIsGraphWeighted.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxIsGraphWeighted.Name = "checkBoxIsGraphWeighted";
            this.checkBoxIsGraphWeighted.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.checkBoxIsGraphWeighted.Size = new System.Drawing.Size(270, 54);
            this.checkBoxIsGraphWeighted.TabIndex = 1;
            this.checkBoxIsGraphWeighted.Text = "взвешенный граф";
            this.checkBoxIsGraphWeighted.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsGraphOriented
            // 
            this.checkBoxIsGraphOriented.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxIsGraphOriented.AutoSize = true;
            this.checkBoxIsGraphOriented.Location = new System.Drawing.Point(3, 4);
            this.checkBoxIsGraphOriented.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxIsGraphOriented.Name = "checkBoxIsGraphOriented";
            this.checkBoxIsGraphOriented.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.checkBoxIsGraphOriented.Size = new System.Drawing.Size(270, 54);
            this.checkBoxIsGraphOriented.TabIndex = 0;
            this.checkBoxIsGraphOriented.Text = "ориентированный граф";
            this.checkBoxIsGraphOriented.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.numericUpDownGraphVertexCount);
            this.groupBox3.Location = new System.Drawing.Point(3, 128);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(270, 57);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "количество вершин";
            // 
            // numericUpDownGraphVertexCount
            // 
            this.numericUpDownGraphVertexCount.AutoSize = true;
            this.numericUpDownGraphVertexCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericUpDownGraphVertexCount.Location = new System.Drawing.Point(3, 25);
            this.numericUpDownGraphVertexCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownGraphVertexCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownGraphVertexCount.Name = "numericUpDownGraphVertexCount";
            this.numericUpDownGraphVertexCount.Size = new System.Drawing.Size(264, 28);
            this.numericUpDownGraphVertexCount.TabIndex = 1;
            this.numericUpDownGraphVertexCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // buttonWriteGraphToFile
            // 
            this.buttonWriteGraphToFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWriteGraphToFile.AutoSize = true;
            this.buttonWriteGraphToFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonWriteGraphToFile.Location = new System.Drawing.Point(3, 72);
            this.buttonWriteGraphToFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonWriteGraphToFile.Name = "buttonWriteGraphToFile";
            this.buttonWriteGraphToFile.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.buttonWriteGraphToFile.Size = new System.Drawing.Size(282, 60);
            this.buttonWriteGraphToFile.TabIndex = 0;
            this.buttonWriteGraphToFile.Text = "записать граф в файл";
            this.buttonWriteGraphToFile.UseVisualStyleBackColor = true;
            this.buttonWriteGraphToFile.Click += new System.EventHandler(this.buttonWriteGraphToFile_Click);
            // 
            // buttonReadGraphFromFile
            // 
            this.buttonReadGraphFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReadGraphFromFile.AutoSize = true;
            this.buttonReadGraphFromFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReadGraphFromFile.Location = new System.Drawing.Point(3, 4);
            this.buttonReadGraphFromFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReadGraphFromFile.Name = "buttonReadGraphFromFile";
            this.buttonReadGraphFromFile.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.buttonReadGraphFromFile.Size = new System.Drawing.Size(282, 60);
            this.buttonReadGraphFromFile.TabIndex = 1;
            this.buttonReadGraphFromFile.Text = "считать граф из файла";
            this.buttonReadGraphFromFile.UseVisualStyleBackColor = true;
            this.buttonReadGraphFromFile.Click += new System.EventHandler(this.buttonReadGraphFromFile_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(303, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(773, 545);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonColorizableGraph);
            this.tabPage1.Controls.Add(this.buttonDijkstraGraph);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(765, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "управление";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonColorizableGraph
            // 
            this.buttonColorizableGraph.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonColorizableGraph.Location = new System.Drawing.Point(3, 217);
            this.buttonColorizableGraph.Name = "buttonColorizableGraph";
            this.buttonColorizableGraph.Size = new System.Drawing.Size(759, 245);
            this.buttonColorizableGraph.TabIndex = 1;
            this.buttonColorizableGraph.Text = "раскраска";
            this.buttonColorizableGraph.UseVisualStyleBackColor = true;
            this.buttonColorizableGraph.Click += new System.EventHandler(this.buttonColorizableGraph_Click);
            // 
            // buttonDijkstraGraph
            // 
            this.buttonDijkstraGraph.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDijkstraGraph.Location = new System.Drawing.Point(3, 4);
            this.buttonDijkstraGraph.Name = "buttonDijkstraGraph";
            this.buttonDijkstraGraph.Size = new System.Drawing.Size(759, 213);
            this.buttonDijkstraGraph.TabIndex = 0;
            this.buttonDijkstraGraph.Text = "дейкстра";
            this.buttonDijkstraGraph.UseVisualStyleBackColor = true;
            this.buttonDijkstraGraph.Click += new System.EventHandler(this.buttonDijkstraGraph_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewAdjacencyMatrix);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(825, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "матрица смежности";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAdjacencyMatrix
            // 
            this.dataGridViewAdjacencyMatrix.AllowUserToAddRows = false;
            this.dataGridViewAdjacencyMatrix.AllowUserToDeleteRows = false;
            this.dataGridViewAdjacencyMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdjacencyMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAdjacencyMatrix.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAdjacencyMatrix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewAdjacencyMatrix.Name = "dataGridViewAdjacencyMatrix";
            this.dataGridViewAdjacencyMatrix.ReadOnly = true;
            this.dataGridViewAdjacencyMatrix.RowHeadersWidth = 51;
            this.dataGridViewAdjacencyMatrix.RowTemplate.Height = 24;
            this.dataGridViewAdjacencyMatrix.Size = new System.Drawing.Size(825, 510);
            this.dataGridViewAdjacencyMatrix.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewAdjacencyStructure);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(825, 510);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "структура смежности";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAdjacencyStructure
            // 
            this.dataGridViewAdjacencyStructure.AllowUserToAddRows = false;
            this.dataGridViewAdjacencyStructure.AllowUserToDeleteRows = false;
            this.dataGridViewAdjacencyStructure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdjacencyStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAdjacencyStructure.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAdjacencyStructure.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewAdjacencyStructure.Name = "dataGridViewAdjacencyStructure";
            this.dataGridViewAdjacencyStructure.ReadOnly = true;
            this.dataGridViewAdjacencyStructure.RowHeadersWidth = 51;
            this.dataGridViewAdjacencyStructure.RowTemplate.Height = 24;
            this.dataGridViewAdjacencyStructure.Size = new System.Drawing.Size(825, 510);
            this.dataGridViewAdjacencyStructure.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewWeigthMatrix);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(825, 510);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "матрица весов";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWeigthMatrix
            // 
            this.dataGridViewWeigthMatrix.AllowUserToAddRows = false;
            this.dataGridViewWeigthMatrix.AllowUserToDeleteRows = false;
            this.dataGridViewWeigthMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeigthMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWeigthMatrix.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewWeigthMatrix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewWeigthMatrix.Name = "dataGridViewWeigthMatrix";
            this.dataGridViewWeigthMatrix.ReadOnly = true;
            this.dataGridViewWeigthMatrix.RowHeadersWidth = 51;
            this.dataGridViewWeigthMatrix.RowTemplate.Height = 24;
            this.dataGridViewWeigthMatrix.Size = new System.Drawing.Size(825, 510);
            this.dataGridViewWeigthMatrix.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tableLayoutPanel4);
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(825, 510);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "рисунок графа";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.trackBarGraphImageZoom, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(825, 510);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // trackBarGraphImageZoom
            // 
            this.trackBarGraphImageZoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarGraphImageZoom.LargeChange = 10;
            this.trackBarGraphImageZoom.Location = new System.Drawing.Point(3, 3);
            this.trackBarGraphImageZoom.Maximum = 100;
            this.trackBarGraphImageZoom.Name = "trackBarGraphImageZoom";
            this.trackBarGraphImageZoom.Size = new System.Drawing.Size(819, 56);
            this.trackBarGraphImageZoom.TabIndex = 1;
            this.trackBarGraphImageZoom.TickFrequency = 10;
            this.trackBarGraphImageZoom.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarGraphImageZoom.ValueChanged += new System.EventHandler(this.trackBarGraphImageZoom_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBoxGraph);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 442);
            this.panel1.TabIndex = 2;
            // 
            // pictureBoxGraph
            // 
            this.pictureBoxGraph.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxGraph.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxGraph.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxGraph.Name = "pictureBoxGraph";
            this.pictureBoxGraph.Size = new System.Drawing.Size(817, 440);
            this.pictureBoxGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxGraph.TabIndex = 0;
            this.pictureBoxGraph.TabStop = false;
            // 
            // openFileDialogGraph
            // 
            this.openFileDialogGraph.DefaultExt = "txt";
            this.openFileDialogGraph.FileName = "graph.txt";
            this.openFileDialogGraph.Filter = "txt files (*.txt)|*.txt";
            // 
            // saveFileDialogGraph
            // 
            this.saveFileDialogGraph.DefaultExt = "txt";
            this.saveFileDialogGraph.FileName = "graph.txt";
            this.saveFileDialogGraph.Filter = "txt files (*.txt)|*.txt";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraphVertexCount)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdjacencyMatrix)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdjacencyStructure)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeigthMatrix)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGraphImageZoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonWriteGraphToFile;
        private System.Windows.Forms.Button buttonReadGraphFromFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonGenerateGraph;
        private System.Windows.Forms.CheckBox checkBoxIsGraphWeighted;
        private System.Windows.Forms.CheckBox checkBoxIsGraphOriented;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDownGraphVertexCount;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridViewAdjacencyMatrix;
        private System.Windows.Forms.DataGridView dataGridViewAdjacencyStructure;
        private System.Windows.Forms.DataGridView dataGridViewWeigthMatrix;
        private System.Windows.Forms.PictureBox pictureBoxGraph;
        private System.Windows.Forms.OpenFileDialog openFileDialogGraph;
        private System.Windows.Forms.Button buttonDisplayGraph;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TrackBar trackBarGraphImageZoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialogGraph;
        private System.Windows.Forms.Button buttonDijkstraGraph;
        private System.Windows.Forms.Button buttonColorizableGraph;
    }
}

