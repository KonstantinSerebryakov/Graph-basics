
namespace GraphsWorker
{
    partial class DijkstraForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonHandleTargetVertex = new System.Windows.Forms.Button();
            this.buttonHandleSourceVertex = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownGraphTargetVertexID = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownGraphSourceVertexID = new System.Windows.Forms.NumericUpDown();
            this.buttonDisplayGraph = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBarGraphImageZoom = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxGraph = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraphTargetVertexID)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraphSourceVertexID)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGraphImageZoom)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonDisplayGraph);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel4);
            this.splitContainer1.Size = new System.Drawing.Size(1079, 553);
            this.splitContainer1.SplitterDistance = 341;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonHandleTargetVertex
            // 
            this.buttonHandleTargetVertex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHandleTargetVertex.Location = new System.Drawing.Point(4, 198);
            this.buttonHandleTargetVertex.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHandleTargetVertex.MinimumSize = new System.Drawing.Size(0, 40);
            this.buttonHandleTargetVertex.Name = "buttonHandleTargetVertex";
            this.buttonHandleTargetVertex.Size = new System.Drawing.Size(333, 40);
            this.buttonHandleTargetVertex.TabIndex = 6;
            this.buttonHandleTargetVertex.Text = "отобразить";
            this.buttonHandleTargetVertex.UseVisualStyleBackColor = true;
            this.buttonHandleTargetVertex.Click += new System.EventHandler(this.buttonHandleTargetVertex_Click);
            // 
            // buttonHandleSourceVertex
            // 
            this.buttonHandleSourceVertex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHandleSourceVertex.Location = new System.Drawing.Point(4, 77);
            this.buttonHandleSourceVertex.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHandleSourceVertex.MinimumSize = new System.Drawing.Size(0, 40);
            this.buttonHandleSourceVertex.Name = "buttonHandleSourceVertex";
            this.buttonHandleSourceVertex.Size = new System.Drawing.Size(333, 40);
            this.buttonHandleSourceVertex.TabIndex = 5;
            this.buttonHandleSourceVertex.Text = "расчитать";
            this.buttonHandleSourceVertex.UseVisualStyleBackColor = true;
            this.buttonHandleSourceVertex.Click += new System.EventHandler(this.buttonHandleSourceVertex_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.numericUpDownGraphTargetVertexID);
            this.groupBox1.Location = new System.Drawing.Point(4, 127);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox1.Size = new System.Drawing.Size(333, 61);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "конечная вершина";
            // 
            // numericUpDownGraphTargetVertexID
            // 
            this.numericUpDownGraphTargetVertexID.AutoSize = true;
            this.numericUpDownGraphTargetVertexID.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericUpDownGraphTargetVertexID.Location = new System.Drawing.Point(4, 27);
            this.numericUpDownGraphTargetVertexID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.numericUpDownGraphTargetVertexID.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownGraphTargetVertexID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGraphTargetVertexID.Name = "numericUpDownGraphTargetVertexID";
            this.numericUpDownGraphTargetVertexID.Size = new System.Drawing.Size(325, 28);
            this.numericUpDownGraphTargetVertexID.TabIndex = 1;
            this.numericUpDownGraphTargetVertexID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.numericUpDownGraphSourceVertexID);
            this.groupBox3.Location = new System.Drawing.Point(4, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox3.Size = new System.Drawing.Size(333, 61);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "исходная вершина";
            // 
            // numericUpDownGraphSourceVertexID
            // 
            this.numericUpDownGraphSourceVertexID.AutoSize = true;
            this.numericUpDownGraphSourceVertexID.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericUpDownGraphSourceVertexID.Location = new System.Drawing.Point(4, 27);
            this.numericUpDownGraphSourceVertexID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.numericUpDownGraphSourceVertexID.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownGraphSourceVertexID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGraphSourceVertexID.Name = "numericUpDownGraphSourceVertexID";
            this.numericUpDownGraphSourceVertexID.Size = new System.Drawing.Size(325, 28);
            this.numericUpDownGraphSourceVertexID.TabIndex = 1;
            this.numericUpDownGraphSourceVertexID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonDisplayGraph
            // 
            this.buttonDisplayGraph.Enabled = false;
            this.buttonDisplayGraph.Location = new System.Drawing.Point(19, 712);
            this.buttonDisplayGraph.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDisplayGraph.Name = "buttonDisplayGraph";
            this.buttonDisplayGraph.Size = new System.Drawing.Size(215, 82);
            this.buttonDisplayGraph.TabIndex = 0;
            this.buttonDisplayGraph.Text = "обновить граф";
            this.buttonDisplayGraph.UseVisualStyleBackColor = true;
            this.buttonDisplayGraph.Click += new System.EventHandler(this.buttonDisplayGraph_Click);
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
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(733, 553);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // trackBarGraphImageZoom
            // 
            this.trackBarGraphImageZoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarGraphImageZoom.LargeChange = 10;
            this.trackBarGraphImageZoom.Location = new System.Drawing.Point(4, 4);
            this.trackBarGraphImageZoom.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarGraphImageZoom.Maximum = 100;
            this.trackBarGraphImageZoom.Name = "trackBarGraphImageZoom";
            this.trackBarGraphImageZoom.Size = new System.Drawing.Size(725, 56);
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
            this.panel1.Location = new System.Drawing.Point(4, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 481);
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
            this.pictureBoxGraph.Size = new System.Drawing.Size(723, 479);
            this.pictureBoxGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxGraph.TabIndex = 0;
            this.pictureBoxGraph.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonHandleTargetVertex, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonHandleSourceVertex, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(341, 242);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // DijkstraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 553);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "DijkstraForm";
            this.Text = "DijkstraForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraphTargetVertexID)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraphSourceVertexID)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGraphImageZoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TrackBar trackBarGraphImageZoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxGraph;
        private System.Windows.Forms.Button buttonDisplayGraph;
        private System.Windows.Forms.Button buttonHandleTargetVertex;
        private System.Windows.Forms.Button buttonHandleSourceVertex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownGraphTargetVertexID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDownGraphSourceVertexID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}