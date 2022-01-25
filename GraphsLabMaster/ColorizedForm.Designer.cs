
namespace GraphsWorker
{
    partial class ColorizedForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonColorizeEdges = new System.Windows.Forms.Button();
            this.buttonColorizeVertices = new System.Windows.Forms.Button();
            this.buttonDisplayGraph = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBarGraphImageZoom = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxGraph = new System.Windows.Forms.PictureBox();
            this.buttonColorizeTotal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGraphImageZoom)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).BeginInit();
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
            this.splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonColorizeEdges, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonColorizeVertices, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonColorizeTotal, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(341, 553);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // buttonColorizeEdges
            // 
            this.buttonColorizeEdges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonColorizeEdges.Location = new System.Drawing.Point(3, 187);
            this.buttonColorizeEdges.MinimumSize = new System.Drawing.Size(0, 40);
            this.buttonColorizeEdges.Name = "buttonColorizeEdges";
            this.buttonColorizeEdges.Size = new System.Drawing.Size(335, 135);
            this.buttonColorizeEdges.TabIndex = 1;
            this.buttonColorizeEdges.Text = "раскраска рёбер";
            this.buttonColorizeEdges.UseVisualStyleBackColor = true;
            this.buttonColorizeEdges.Click += new System.EventHandler(this.buttonColorizeEdges_Click);
            // 
            // buttonColorizeVertices
            // 
            this.buttonColorizeVertices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonColorizeVertices.Location = new System.Drawing.Point(3, 3);
            this.buttonColorizeVertices.MinimumSize = new System.Drawing.Size(0, 40);
            this.buttonColorizeVertices.Name = "buttonColorizeVertices";
            this.buttonColorizeVertices.Size = new System.Drawing.Size(335, 135);
            this.buttonColorizeVertices.TabIndex = 0;
            this.buttonColorizeVertices.Text = "раскраска вершин";
            this.buttonColorizeVertices.UseVisualStyleBackColor = true;
            this.buttonColorizeVertices.Click += new System.EventHandler(this.buttonColorizeVertices_Click);
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
            // buttonColorizeTotal
            // 
            this.buttonColorizeTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonColorizeTotal.Location = new System.Drawing.Point(3, 371);
            this.buttonColorizeTotal.MinimumSize = new System.Drawing.Size(0, 40);
            this.buttonColorizeTotal.Name = "buttonColorizeTotal";
            this.buttonColorizeTotal.Size = new System.Drawing.Size(335, 135);
            this.buttonColorizeTotal.TabIndex = 2;
            this.buttonColorizeTotal.Text = "тотальная раскраска";
            this.buttonColorizeTotal.UseVisualStyleBackColor = true;
            this.buttonColorizeTotal.Click += new System.EventHandler(this.buttonColorizeTotal_Click);
            // 
            // ColorizedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 553);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "ColorizedForm";
            this.Text = "ColorizedForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGraphImageZoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonDisplayGraph;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TrackBar trackBarGraphImageZoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxGraph;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonColorizeVertices;
        private System.Windows.Forms.Button buttonColorizeEdges;
        private System.Windows.Forms.Button buttonColorizeTotal;
    }
}