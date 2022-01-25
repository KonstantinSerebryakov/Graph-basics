using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibraryDotNet
{
    public class GraphDrawer
    {
        public const int MIN_VERTEX_RADIUS = 40;

        public const int MIN_IMAGE_SIZE = 1000;
        public const int MAX_IMAGE_SIZE = 5000;

        Graph graph = null;

        int imageSize = -1;
        int mainRadius = -1;
        int vertexRadius = -1;

        int penSize;

        VertexDrawable[] vertices = null;

        Pen DEFAULT_PEN = new Pen(Color.Black, 1);
        Pen penMain = null;
        Pen penArrow = null;

        StringFormat stringFormat = null;

        Bitmap image = null;
        Graphics canvas = null;

        public GraphDrawer()
        {
            vertices = null;
            penSize = 1;

            penMain = new Pen(this.DEFAULT_PEN.Color, this.DEFAULT_PEN.Width);
            penArrow = new Pen(this.DEFAULT_PEN.Color, this.DEFAULT_PEN.Width);
            setPenCustomArrowCap(penArrow);

            stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
        }

        void setPenCustomArrowCap(Pen pen)
        {
            GraphicsPath hPath = new GraphicsPath();
            hPath.AddLine(new Point(0, 0), new Point(2, -2));
            hPath.AddLine(new Point(2, -2), new Point(-2, -2));
            hPath.AddLine(new Point(-2, -2), new Point(0, 0));
            CustomLineCap arrowCap = new CustomLineCap(null, hPath);
            arrowCap.SetStrokeCaps(LineCap.Round, LineCap.Round);
            pen.CustomEndCap = arrowCap;
        }

        double? calculateDeltaAngle(int verticesCount = 0)
        {
            if (verticesCount == 0)
            {
                return null;
            }
            else
            {
                return 2.0 * Math.PI / (double)verticesCount;
            }
        }

        int calculateImageSize(double deltaAngle)
        {
            int scale = MIN_IMAGE_SIZE;
            double R = (double)MIN_IMAGE_SIZE * 0.4; // (1 * 40%)
            double L = Convert.ToInt32(2.0 * (double)R * Math.Sin(deltaAngle / 2.0));
            if (L < 3.0 * (double)MIN_VERTEX_RADIUS)
            {
                L = 3.0 * (double)MIN_VERTEX_RADIUS;
                R = (double)L / 2.0 / Math.Sin(deltaAngle / 2.0);
                scale = Convert.ToInt32((double)R * 2.5); // (1 / 40%)
            }

            return Math.Min(scale, MAX_IMAGE_SIZE);
        }

        int calculateMainRadius(int imageSize)
        {
            int mainRadius = Convert.ToInt32((double)imageSize * 0.4); // (1 * 40%)
            return mainRadius;
        }

        int calculateVertexRadius(int imageSize, int mainRadius, double deltaAngle, int verticesCount)
        {
            int rad1 = Convert.ToInt32((double)(imageSize - mainRadius - mainRadius) / 4.0);
            int rad2 = Convert.ToInt32((double)mainRadius * Math.Sin(deltaAngle / 2.0) * 2.0 / 3.0);
            if (verticesCount == 1)
            {
                rad2 = rad1;
            }
            else if (verticesCount < 1)
            {
                // TODO: handle this dangerous place;
                rad1 = -1;
                rad2 = -1;
            }
            return Math.Min(rad1, rad2);
        }

        int calculatePenSize(int vertexRadius)
        {
            int size = Convert.ToInt32(vertexRadius * 0.075); // (1 * 7.5%)
            return Math.Max(size, 1);
        }

        bool calculateVertices(double deltaAngle)
        {
            if (deltaAngle == 0)
            {
                return false;
            }

            int verticesCount = this.graph.getVerticesCount();
            List<Vertex> graphVertices = this.graph.getVertices();
            if (verticesCount != graphVertices.Count())
            {
                return false;
            }

            int centerPoint = Convert.ToInt32(this.imageSize / 2.0);

            this.vertices = new VertexDrawable[verticesCount];
            double tempAngle = 0.0 - Math.PI / 2.0;
            for (int i = 0; i < graphVertices.Count(); i++)
            {
                var vertex = new VertexDrawable(graphVertices[i].id,
                    (centerPoint + (int)(mainRadius * Math.Cos(tempAngle))),
                    (centerPoint + (int)(mainRadius * Math.Sin(tempAngle))),
                    tempAngle);
                this.vertices[i] = vertex;
                tempAngle += deltaAngle;
            }
            Array.Sort(this.vertices, new VertexDrawableComparer());

            return true;
        }

        public bool calculateImageFromGraph(Graph graph)
        {
            if (!graph.isNotEmpty())
            {
                return false;
            }

            int verticesCount = graph.getVerticesCount();

            double? deltaAngle = calculateDeltaAngle(verticesCount);
            if (!deltaAngle.HasValue)
            {
                return false;
            }

            this.graph = graph;

            int imageSize = calculateImageSize(deltaAngle.Value);
            this.imageSize = imageSize;

            int mainRadius = calculateMainRadius(this.imageSize);
            this.mainRadius = mainRadius;

            int vertexRadius = calculateVertexRadius(this.imageSize, this.mainRadius, deltaAngle.Value, verticesCount);
            this.vertexRadius = vertexRadius;

            int penSize = calculatePenSize(this.vertexRadius);
            this.penSize = penSize;

            this.penMain.Width = this.penSize;
            this.penArrow.Width = this.penSize;

            bool isCorrect = true;
            isCorrect = calculateVertices(deltaAngle.Value);

            return isCorrect;
        }

        bool clearImage()
        {
            if (this.imageSize < MIN_IMAGE_SIZE || this.imageSize > MAX_IMAGE_SIZE)
            {
                return false;
            }
            this.image = new Bitmap(this.imageSize, this.imageSize);
            this.canvas = Graphics.FromImage(this.image);
            canvas.Clear(Color.White);
            //canvas.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            canvas.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            canvas.SmoothingMode = SmoothingMode.None;

            return true;
        }

        public bool drawVertices(Pen pen, Brush brushBackground, VertexDrawable[] vertices)
        {
            if (vertices == null)
            {
                return false;
            }

            for (int i = 0; i < vertices.Length; i++)
            {
                VertexDrawable vertex = vertices[i];
                var rect = new Rectangle(
                    (vertex.center.X - (int)(this.vertexRadius)),
                    (vertex.center.Y - (int)(this.vertexRadius)),
                    (Convert.ToInt32(this.vertexRadius * 2)),
                    (Convert.ToInt32(this.vertexRadius * 2)));
                canvas.FillEllipse(brushBackground, rect);
                canvas.DrawEllipse(pen, rect);
            }

            return true;
        }
        
        public bool drawColorizedVertices(Pen pen, SolidBrush brushBackground, VertexDrawable[] vertices, ColorizableVertex[] colorizedVertices)
        {
            if (vertices == null)
            {
                return false;
            }

            for (int i = 0; i < vertices.Length; i++)
            {
                VertexDrawable vertex = vertices[i];
                var rect = new Rectangle(
                    (vertex.center.X - (int)(this.vertexRadius)),
                    (vertex.center.Y - (int)(this.vertexRadius)),
                    (Convert.ToInt32(this.vertexRadius * 2)),
                    (Convert.ToInt32(this.vertexRadius * 2)));

                var index = Array.FindIndex(colorizedVertices, x=>x.id == vertex.id);
                if (index < 0)
                    return false;
                var colorizedVertex = colorizedVertices[index];
                brushBackground.Color = colorizedVertex.color;

                canvas.FillEllipse(brushBackground, rect);
                canvas.DrawEllipse(pen, rect);
            }

            return true;
        }

        bool drawSingleVertexLabels(VertexDrawable vertex, LabelDrawable[] labels, Pen penForDivisionLine = null)
        {
            if (labels == null)
            {
                return false;
            }

            if (labels.Length == 2)
            {
                canvas.DrawLine(penForDivisionLine,
                    (vertex.center.X - this.vertexRadius),
                    (vertex.center.Y),
                    (vertex.center.X + this.vertexRadius),
                    (vertex.center.Y));
            }
            SolidBrush brush = new SolidBrush(Color.Black);
            for (int i = 0; i < labels.Length; i++)
            {
                var label = labels[i];
                if (!label.rect.HasValue)
                {
                    return false;
                }

                Font font = new Font(FontFamily.GenericSansSerif, (float)(label.rect.Value.Height / 3.0), FontStyle.Bold);
                brush.Color = label.color;
                this.canvas.DrawString(label.text, font, brush, label.rect.Value, this.stringFormat);
            }

            return true;
        }

        bool calculateLabelsRects(ref LabelDrawable[] labels, VertexDrawable vertex)
        {
            if (labels == null)
            {
                return false;
            }

            switch (labels.Length)
            {
                case 1:
                    {
                        Rectangle labelRect;
                        labelRect = new Rectangle(
                            (vertex.center.X - (int)(this.vertexRadius)),
                            (vertex.center.Y - (int)(this.vertexRadius)),
                            (Convert.ToInt32(this.vertexRadius * 2)),
                            (Convert.ToInt32(this.vertexRadius * 2)));
                        labels[0].rect = labelRect;
                        break;
                    }
                case 2:
                    {
                        Rectangle labelRect;
                        labelRect = new Rectangle(
                            (vertex.center.X - (int)(this.vertexRadius)),
                            (vertex.center.Y - (int)(this.vertexRadius)),
                            (Convert.ToInt32(this.vertexRadius * 2)),
                            (Convert.ToInt32(this.vertexRadius)));
                        labels[0].rect = labelRect;
                        labelRect = new Rectangle(
                            (vertex.center.X - (int)(this.vertexRadius)),
                            (vertex.center.Y),
                            (Convert.ToInt32(this.vertexRadius * 2)),
                            (Convert.ToInt32(this.vertexRadius)));
                        labels[1].rect = labelRect;
                        break;
                    }
                case 3:
                    {
                        Rectangle labelRect;
                        labelRect = new Rectangle(
                            (vertex.center.X - (int)(this.vertexRadius)),
                            (vertex.center.Y - (int)(this.vertexRadius)),
                            (Convert.ToInt32(this.vertexRadius * 2)),
                            (Convert.ToInt32(this.vertexRadius)));
                        labels[0].rect = labelRect;
                        labelRect = new Rectangle(
                            (vertex.center.X - (int)(this.vertexRadius)),
                            (vertex.center.Y),
                            (Convert.ToInt32(this.vertexRadius)),
                            (Convert.ToInt32(this.vertexRadius)));
                        labels[1].rect = labelRect;
                        labelRect = new Rectangle(
                            (vertex.center.X),
                            (vertex.center.Y),
                            (Convert.ToInt32(this.vertexRadius)),
                            (Convert.ToInt32(this.vertexRadius)));
                        labels[2].rect = labelRect;
                        break;
                    }
                case 4:
                    {
                        Rectangle labelRect;
                        labelRect = new Rectangle(
                            (vertex.center.X - (int)(this.vertexRadius)),
                            (vertex.center.Y - (int)(this.vertexRadius)),
                            (Convert.ToInt32(this.vertexRadius)),
                            (Convert.ToInt32(this.vertexRadius)));
                        labels[0].rect = labelRect;
                        labelRect = new Rectangle(
                            (vertex.center.X),
                            (vertex.center.Y - (int)(this.vertexRadius)),
                            (Convert.ToInt32(this.vertexRadius)),
                            (Convert.ToInt32(this.vertexRadius)));
                        labels[1].rect = labelRect;
                        labelRect = new Rectangle(
                            (vertex.center.X - (int)(this.vertexRadius)),
                            (vertex.center.Y),
                            (Convert.ToInt32(this.vertexRadius)),
                            (Convert.ToInt32(this.vertexRadius)));
                        labels[2].rect = labelRect;
                        labelRect = new Rectangle(
                            (vertex.center.X),
                            (vertex.center.Y),
                            (Convert.ToInt32(this.vertexRadius)),
                            (Convert.ToInt32(this.vertexRadius)));
                        labels[3].rect = labelRect;
                        break;
                    }
                default:
                    return false;
            }

            return true;
        }

        bool drawGraphVerticesLabels(VertexDrawable[] vertices, Pen penForDivisionLine = null)
        {
            if (vertices == null)
            {
                return false;
            }

            bool isCorrect = true;
            for (int i = 0; i < vertices.Length; i++)
            {
                VertexDrawable vertexDrawable = vertices[i];
                Vertex? vertex = this.graph.getVertex(vertexDrawable.id);
                if (!vertex.HasValue)
                {
                    return false;
                }

                LabelDrawable[] labels = new LabelDrawable[2];
                labels[0] = new LabelDrawable("№" + vertex.Value.id.ToString(), Color.Black);
                labels[1] = new LabelDrawable(vertex.Value.weight.ToString("+0;-#"), Color.Black);
                isCorrect = this.calculateLabelsRects(ref labels, vertexDrawable);
                if (!isCorrect)
                {
                    return isCorrect;
                }

                isCorrect = this.drawSingleVertexLabels(vertexDrawable, labels, penForDivisionLine);
                if (!isCorrect)
                {
                    return isCorrect;
                }
            }
            return isCorrect;
        }

        bool drawColorizedGraphVerticesLabels(VertexDrawable[] vertices, Pen penForDivisionLine = null)
        {
            if (vertices == null)
            {
                return false;
            }

            bool isCorrect = true;
            for (int i = 0; i < vertices.Length; i++)
            {
                VertexDrawable vertexDrawable = vertices[i];
                Vertex? vertex = this.graph.getVertex(vertexDrawable.id);
                if (!vertex.HasValue)
                {
                    return false;
                }

                LabelDrawable[] labels = new LabelDrawable[1];
                labels[0] = new LabelDrawable(vertex.Value.id.ToString(), Color.Black);
                isCorrect = this.calculateLabelsRects(ref labels, vertexDrawable);
                if (!isCorrect)
                    return isCorrect;

                isCorrect = this.drawSingleVertexLabels(vertexDrawable, labels, penForDivisionLine);
                if (!isCorrect)
                    return isCorrect;
            }
            return isCorrect;
        }

        bool calculateEdgesPoints(out Point fromPoint, out Point toPoint, VertexDrawable fromVertex, VertexDrawable toVertex)
        {
            int xFrom = fromVertex.center.X;
            int yFrom = fromVertex.center.Y;
            int xTo = toVertex.center.X;
            int yTo = toVertex.center.Y;

            double fullLength = Math.Sqrt(Math.Pow(xTo - xFrom, 2.0) + Math.Pow(yTo - yFrom, 2.0));
            double k1 = (this.vertexRadius) / fullLength;
            double k2 = (fullLength - this.vertexRadius) / fullLength;

            toPoint = new Point((xTo - Convert.ToInt32((double)(xTo - xFrom) * k1)),
                (yTo - Convert.ToInt32((double)(yTo - yFrom) * k1)));
            fromPoint = new Point((xTo - Convert.ToInt32((double)(xTo - xFrom) * k2)),
                (yTo - Convert.ToInt32((double)(yTo - yFrom) * k2)));

            return true;
        }

        bool drawEdges(Pen pen, Edge[] edges, bool isRandomColor = false)
        {
            if (this.vertices == null)
            {
                return false;
            }

            Random random = new Random();
            for (int i = 0; i < edges.Length; i++)
            {
                Edge edge = edges[i];
                int index;

                index = Array.FindIndex(this.vertices, obj => obj.id == edge.from);
                if (index == -1)
                {
                    return false;
                }
                VertexDrawable fromVertex = this.vertices[index];

                index = Array.FindIndex(this.vertices, obj => obj.id == edge.to);
                if (index == -1)
                {
                    return false;
                }
                VertexDrawable toVertex = this.vertices[index];

                Point fromPoint;
                Point toPoint;
                bool isCorrect = calculateEdgesPoints(out fromPoint, out toPoint, fromVertex, toVertex);
                if (!isCorrect || fromPoint == null || toPoint == null)
                {
                    return false;
                }

                if (isRandomColor)
                {
                    pen.Color = Color.FromArgb(random.Next(25, 225), random.Next(25, 225), random.Next(25, 225));
                }
                canvas.DrawLine(pen, fromPoint, toPoint);
            }

            return true;
        }
        
        bool drawColorizedEdges(Pen pen, ColorizableEdge[] edges)
        {
            if (this.vertices == null)
            {
                return false;
            }

            for (int i = 0; i < edges.Length; i++)
            {
                var edge = edges[i];
                int index;

                index = Array.FindIndex(this.vertices, obj => obj.id == edge.from);
                if (index == -1)
                    return false;
                VertexDrawable fromVertex = this.vertices[index];

                index = Array.FindIndex(this.vertices, obj => obj.id == edge.to);
                if (index == -1)
                    return false;
                VertexDrawable toVertex = this.vertices[index];

                Point fromPoint;
                Point toPoint;
                bool isCorrect = calculateEdgesPoints(out fromPoint, out toPoint, fromVertex, toVertex);
                if (!isCorrect || fromPoint == null || toPoint == null)
                {
                    return false;
                }

                pen.Color = edge.color;
                canvas.DrawLine(pen, fromPoint, toPoint);
            }

            return true;
        }

        bool calculateEdgeCenterPoint(out Point centerPoint, Edge edge)
        {
            int index;

            index = Array.FindIndex(this.vertices, obj => obj.id == edge.from);
            if (index == -1)
            {
                centerPoint = new Point(-1, -1);
                return false;
            }
            VertexDrawable fromVertex = this.vertices[index];

            index = Array.FindIndex(this.vertices, obj => obj.id == edge.to);
            if (index == -1)
            {
                centerPoint = new Point(-1, -1);
                return false;
            }
            VertexDrawable toVertex = this.vertices[index];

            centerPoint = new Point(
                Convert.ToInt32((double)(toVertex.center.X + fromVertex.center.X) / 2.0),
                Convert.ToInt32((double)(toVertex.center.Y + fromVertex.center.Y) / 2.0));

            return true;
        }

        bool drawEdgesLabels(Color textColor, Pen penForBorder, Edge[] edges, Brush brushBackground)
        {
            bool isCorrect = true;
            SolidBrush brush = new SolidBrush(Color.Black);
            for (int i = 0; i < edges.Length; i++)
            {
                Edge edge = edges[i];

                Point edgeCenterPoint;
                isCorrect = calculateEdgeCenterPoint(out edgeCenterPoint, edge);
                if (!isCorrect || edgeCenterPoint == null)
                {
                    return false;
                }

                // generate label
                LabelDrawable label = new LabelDrawable(edge.weight.ToString("+0;-#"), textColor);
                Rectangle rect = new Rectangle(
                    (edgeCenterPoint.X - (int)(this.vertexRadius / 2.0)),
                    (edgeCenterPoint.Y - (int)(this.vertexRadius / 2.0)),
                    (Convert.ToInt32(this.vertexRadius)),
                    (Convert.ToInt32(this.vertexRadius)));
                label.rect = rect;

                // draw label background
                canvas.FillRectangle(brushBackground, label.rect.Value);
                canvas.DrawRectangle(penForBorder, label.rect.Value);

                // draw label text
                Font font = new Font(FontFamily.GenericSansSerif, (float)(label.rect.Value.Height / 4.0), FontStyle.Bold);
                brush.Color = label.color;
                canvas.DrawString(label.text, font, brush, label.rect.Value, this.stringFormat);
            }

            return true;
        }

        public bool generateGraphImage(bool isColorized = false)
        {
            bool isCorrcet = true;

            isCorrcet = clearImage();
            if (!isCorrcet)
            {
                return false;
            }

            Pen pen1;
            pen1 = this.penMain;
            pen1.Width = this.calculatePenSize(this.vertexRadius);
            Pen pen2;
            pen2 = this.penArrow;
            pen2.Width = this.calculatePenSize(this.vertexRadius);
            SolidBrush solidBrush;
            solidBrush = new SolidBrush(Color.LightGray);


            var edges = this.graph.getEdges();
            if (this.graph.isOriented)
            {
                pen2.Color = Color.DarkBlue;
                isCorrcet = drawEdges(pen2, edges.ToArray(), isColorized);
            }
            else
            {
                pen1.Color = Color.DarkBlue;
                isCorrcet = drawEdges(pen1, edges.ToArray(), isColorized);
            }
            if (!isCorrcet)
            {
                return false;
            }

            if (this.graph.isWeighted)
            {
                pen1.Color = Color.Gray;
                solidBrush.Color = Color.LightGray;
                isCorrcet = drawEdgesLabels(Color.Black, pen1, edges.ToArray(), solidBrush);
                if (!isCorrcet)
                {
                    return false;
                }
            }

            pen1.Color = Color.Gray;
            solidBrush.Color = Color.LightGray;
            isCorrcet = drawVertices(pen1, solidBrush, this.vertices);
            if (!isCorrcet)
            {
                return false;
            }


            isCorrcet = drawGraphVerticesLabels(this.vertices, pen1);
            if (!isCorrcet)
            {
                return false;
            }

            return isCorrcet;
        }

        bool drawDijkstraVerticesLabels(VertexDrawable[] vertices, DijkstraVertex[] dijkstraVertices, Pen penForDivisionLine = null)
        {
            if (vertices == null || dijkstraVertices == null)
            {
                return false;
            }

            bool isCorrect = true;
            for (int i = 0; i < vertices.Length; i++)
            {
                VertexDrawable vertexDrawable = vertices[i];
                int index;
                index = Array.FindIndex(dijkstraVertices, x=>x.id == vertexDrawable.id);
                if (index == -1)
                {
                    return false;
                }
                var vertex = dijkstraVertices[index];

                LabelDrawable[] labels = new LabelDrawable[2];
                labels[0] = new LabelDrawable("№" + vertex.id.ToString(), Color.Black);
                labels[1] = new LabelDrawable(vertex.weight.ToString("+0;-#"), Color.Red);
                isCorrect = this.calculateLabelsRects(ref labels, vertexDrawable);
                if (!isCorrect)
                {
                    return isCorrect;
                }

                isCorrect = this.drawSingleVertexLabels(vertexDrawable, labels, penForDivisionLine);
                if (!isCorrect)
                {
                    return isCorrect;
                }
            }
            return isCorrect;
        }

        public bool generateDijkstraGraphImage(DijkstraGraph dijkstraGraph, int targetId)
        {
            if (dijkstraGraph == null)
            {
                return false;
            }

            Pen pen1;
            pen1 = this.penMain;
            pen1.Width = this.calculatePenSize(this.vertexRadius);
            Pen pen2;
            pen2 = this.penArrow;
            pen2.Width = this.calculatePenSize(this.vertexRadius);
            SolidBrush solidBrush;
            solidBrush = new SolidBrush(Color.Red);

            var dijkstraPath = dijkstraGraph.getDijkstraPathVerticesTo(targetId);
            if (dijkstraPath == null)
            {
                return false;
            }

            // generate edges
            List<Edge> edges = new List<Edge>();
            var pathVertex = dijkstraPath[0];
            while (pathVertex.previousId != -1)
            {
                var edge = this.graph.getEdge(pathVertex.previousId, pathVertex.id);
                if (!edge.HasValue)
                {
                    return false;
                }
                edges.Add(edge.Value);
                int index = Array.FindIndex(dijkstraPath, x=>x.id==pathVertex.previousId);
                if (index == -1)
                {
                    return false;
                }
                pathVertex = dijkstraPath[index];
            }

            bool isCorrect = true;
            pen2.Color = Color.Red;
            isCorrect = drawEdges(pen2, edges.ToArray(), false);
            if (!isCorrect)
            {
                return false;
            }

            // select dijkstra vertices from drawable
            var drawableDijkstraPath = new VertexDrawable[dijkstraPath.Length];
            for (int i = 0; i < dijkstraPath.Length; i++)
            {
                int index;
                index = Array.FindIndex(this.vertices, x=>x.id == dijkstraPath[i].id);
                if (index == -1)
                {
                    return false;
                }
                drawableDijkstraPath[i] = this.vertices[index];
            }

            pen1.Color = Color.Red;
            solidBrush.Color = Color.FromArgb(255, Color.LightGray);
            isCorrect = drawVertices(pen1, solidBrush, drawableDijkstraPath);
            if (!isCorrect)
            {
                return false;
            }

            isCorrect = drawDijkstraVerticesLabels(drawableDijkstraPath, dijkstraPath, pen1);
            if (!isCorrect)
            {
                return false;
            }

            return isCorrect;
        }
        
        public bool generateColorizedGraphImage(ColorizableGraph colorizedGraph)
        {
            bool isCorrcet = true;

            isCorrcet = colorizedGraph.generateColors();
            if (!isCorrcet)
                return false;

            isCorrcet = clearImage();
            if (!isCorrcet)
                return false;

            Pen pen1;
            pen1 = this.penMain;
            pen1.Width = this.calculatePenSize(this.vertexRadius);
            Pen pen2;
            pen2 = this.penArrow;
            pen2.Width = this.calculatePenSize(this.vertexRadius);
            SolidBrush solidBrush;
            solidBrush = new SolidBrush(Color.LightGray);

            var edges = colorizedGraph.getEdges();
            if (this.graph.isOriented)
            {
                pen2.Color = Color.DarkBlue;
                isCorrcet = drawColorizedEdges(pen2, edges.ToArray());
            }
            else
            {
                pen1.Color = Color.DarkBlue;
                isCorrcet = drawColorizedEdges(pen1, edges.ToArray());
            }
            if (!isCorrcet)
            {
                return false;
            }

            pen1.Color = Color.Gray;
            solidBrush.Color = Color.LightGray;
            var vertices = colorizedGraph.getVertices();
            isCorrcet = drawColorizedVertices(pen1, solidBrush, this.vertices, vertices);
            if (!isCorrcet)
                return false;

            isCorrcet = drawColorizedGraphVerticesLabels(this.vertices, pen1);
            if (!isCorrcet)
                return false;

            return isCorrcet;
        }
        
        public Image getImage()
        {
            return this.image;
        }
    }
}
