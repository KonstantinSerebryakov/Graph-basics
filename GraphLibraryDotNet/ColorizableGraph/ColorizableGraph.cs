using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibraryDotNet
{
    public class ColorizableGraph
    {
        Graph graph;
        bool isOriented;
        ColorizableVertex[] vertices;
        ColorizableEdge[] edges;

        public ColorizableGraph(Graph graph)
        {
            this.graph = graph;
            this.isOriented = graph.isOriented;

            this.vertices = new ColorizableVertex[graph.getVerticesCount()];
            for (int i = 0; i < this.vertices.Length; i++)
            {
                this.vertices[i] = new ColorizableVertex(i + 1);
            }

            var graphEdges = graph.getEdges();
            if (graphEdges != null)
            {
                this.edges = new ColorizableEdge[graph.getEdgesCount()];
                for (int i = 0; i < this.edges.Length; i++)
                {
                    this.edges[i] = new ColorizableEdge(graphEdges[i].from, graphEdges[i].to);
                }
            }
            else
            {
                this.edges = null;
            }
        }

        public ColorizableVertex? getVertex(int id)
        {
            if (this.vertices == null)
            {
                return null;
            }
            var vertexIndex = Array.FindIndex(this.vertices, x => x.id == id);
            if (vertexIndex > -1)
            {
                return this.vertices[vertexIndex];
            }
            return null;
        }
        
        private bool setVertex(ColorizableVertex vertex)
        {
            int index = Array.FindIndex(this.vertices, x => x.id == vertex.id);
            if (index < 0)
                return false;
            this.vertices[index] = vertex;
            return true;
        }

        public ColorizableVertex[] getVertices()
        {
            return this.vertices;
        }

        public ColorizableEdge? getEdge(int from, int to)
        {
            if (this.edges == null)
            {
                return null;
            }
            var edgeIndex = Array.FindIndex(this.edges, x => x.from == from && x.to == to);
            if (edgeIndex > -1)
            {
                return this.edges[edgeIndex];
            }
            return null;
        }

        private bool setEdge(ColorizableEdge edge)
        {
            int index = Array.FindIndex(this.edges, x => x.from == edge.from && x.to == edge.to);
            if (index < 0)
                return false;
            this.edges[index] = edge;
            return true;
        }

        public ColorizableEdge[] getEdges()
        {
            return this.edges;
        }


        public ColorizableVertex[] getAdjacentVerticesToVertex(int id)
        {
            var edges = this.getAdjacentEdgesToVertex(id);
            if (edges == null)
                return null;

            SortedSet<int> idsSet = new SortedSet<int>();
            for (int i = 0; i < edges.Length; i++)
            {
                var edge = edges[i];
                int temp = edge.from == id ? edge.to : edge.from;
                idsSet.Add(temp);
            }
            int[] ids = idsSet.ToArray();

            ColorizableVertex[] vertices = new ColorizableVertex[ids.Length];
            for (int i = 0; i < ids.Length; i++)
            {
                var vertex = this.getVertex(ids[i]);
                if (!vertex.HasValue)
                    return null;
                vertices[i] = vertex.Value;
            }

            return vertices;
        }

        public ColorizableVertex[] getAdjacentVerticesToEdge(int from, int to)
        {
            ColorizableVertex[] vertices = new ColorizableVertex[2];

            var temp = this.getVertex(from);
            if (!temp.HasValue)
                return null;
            vertices[0] = temp.Value;

            temp = this.getVertex(to);
            if (!temp.HasValue)
                return null;
            vertices[1] = temp.Value;

            return vertices;
        }

        public ColorizableEdge[] getAdjacentEdgesToVertex(int id)
        {
            if (this.edges == null)
            {
                return null;
            }
            var edges = Array.FindAll(this.edges, x => x.from == id || x.to == id);
            return edges;
        }

        public ColorizableEdge[] getAdjacentEdgesToEdge(int from, int to)
        {
            var edgesLeft = this.getAdjacentEdgesToVertex(from);
            if (edgesLeft == null)
                return null;
            var edgesRight = this.getAdjacentEdgesToVertex(to);
            if (edgesRight == null)
                return null;

            List<ColorizableEdge> edges = new List<ColorizableEdge>();
            edges.AddRange(edgesLeft);
            edges.AddRange(edgesRight);

            int index = edges.FindIndex(x => x.from == from && x.to == to);
            if (index > -1)
                edges.RemoveAt(index);
            index = edges.FindIndex(x => x.from == to && x.to == from);
            if (index > -1)
                edges.RemoveAt(index);

            return edges.ToArray();
        }

        private int colorizeTotalVertice(ColorizableVertex currentVertex, int colorIndexOld)
        {
            int colorIndex = colorIndexOld;
            int color = this.getTotalVertexColor(colorIndex, currentVertex);
            if (color == -1)
                return -1;
            if (color == 0)
            {
                colorIndex += 1;
                color = colorIndex;
            }

            currentVertex.colorId = color;
            bool isCorrect = this.setVertex(currentVertex);
            if (!isCorrect)
                return -1;

            return colorIndex;
        }

        private int colorizeTotalEdge(ColorizableEdge currentEdge, int colorIndexOld)
        {
            int colorIndex = colorIndexOld;
            int color = this.getTotalEdgeColor(colorIndex, currentEdge);
            if (color == -1)
                return -1;
            if (color == 0)
            {
                colorIndex += 1;
                color = colorIndex;
            }

            currentEdge.colorId = color;
            bool isCorrect = this.setEdge(currentEdge);
            if (!isCorrect)
                return -1;

            return colorIndex;
        }

        public bool colorizeTotal()
        {
            for (int i = 0; i < this.edges.Length; i++)
                this.edges[i].colorId = -1;
            for (int i = 0; i < this.vertices.Length; i++)
                this.vertices[i].colorId = -1;

            Queue<ColorizableEdge> uncoloredEdges = new Queue<ColorizableEdge>();
            for (int i = 0; i < this.edges.Length; i++)
                uncoloredEdges.Enqueue(this.edges[i]);
            Queue<ColorizableVertex> uncoloredVertices = new Queue<ColorizableVertex>();
            for (int i = 0; i < this.vertices.Length; i++)
                uncoloredVertices.Enqueue(this.vertices[i]);

            int colorIndex = 0;
            while (uncoloredEdges.Count > 0 || uncoloredVertices.Count > 0)
            {
                if (uncoloredEdges.Count > uncoloredVertices.Count)
                {
                    colorIndex = this.colorizeTotalEdge(uncoloredEdges.Dequeue(), colorIndex);
                } else
                {
                    colorIndex = this.colorizeTotalVertice(uncoloredVertices.Dequeue(), colorIndex);
                }
                if (colorIndex == -1)
                    return false;
            }

            return true;
        }

        public bool colorizeEdges()
        {
            for (int i = 0; i < this.edges.Length; i++)
                this.edges[i].colorId = -1;
            for (int i = 0; i < this.vertices.Length; i++)
                this.vertices[i].colorId = -1;

            Queue<ColorizableEdge> uncoloredEdges = new Queue<ColorizableEdge>();
            for (int i = 0; i < this.edges.Length; i++)
                uncoloredEdges.Enqueue(this.edges[i]);

            int colorIndex = 0;

            while (uncoloredEdges.Count > 0)
            {
                ColorizableEdge currentEdge = uncoloredEdges.Dequeue();

                int color = this.getEdgeColor(colorIndex, currentEdge);
                if (color == -1)
                    return false;
                if (color == 0)
                {
                    colorIndex += 1;
                    color = colorIndex;
                }

                currentEdge.colorId = color;
                bool isCorrect = this.setEdge(currentEdge);
                if (!isCorrect)
                    return false;
            }

            return true;
        }

        public bool colorizeVertices()
        {
            for (int i = 0; i < this.edges.Length; i++)
                this.edges[i].colorId = -1;
            for (int i = 0; i < this.vertices.Length; i++)
                this.vertices[i].colorId = -1;

            Queue<ColorizableVertex> uncoloredVertices = new Queue<ColorizableVertex>();
            for (int i = 0; i < this.vertices.Length; i++)
                uncoloredVertices.Enqueue(this.vertices[i]);

            int colorIndex = 0;

            while (uncoloredVertices.Count > 0)
            {
                ColorizableVertex currentVertex = uncoloredVertices.Dequeue();

                int color = this.getVertexColor(colorIndex, currentVertex);
                if (color == -1)
                    return false;
                if (color == 0)
                {
                    colorIndex += 1;
                    color = colorIndex;
                }

                currentVertex.colorId = color;
                bool isCorrect = this.setVertex(currentVertex);
                if (!isCorrect)
                    return false;
            }

            return true;
        }

        private int getTotalEdgeColor(int colorIndex, ColorizableEdge currentEdge)
        {
            var adjacentVertices = this.getAdjacentVerticesToEdge(currentEdge.from, currentEdge.to);
            if (adjacentVertices == null)
                return -1;
            var vertices = Array.FindAll(adjacentVertices, x => x.colorId != -1);

            var adjacentEdges = this.getAdjacentEdgesToEdge(currentEdge.from, currentEdge.to);
            if (adjacentEdges == null)
                return -1;
            var edges = Array.FindAll(adjacentEdges, x => x.colorId != -1);

            bool[] allowedColors = new bool[colorIndex];
            for (int i = 0; i < allowedColors.Length; i++)
                allowedColors[i] = true;
            for (int i = 0; i < vertices.Length; i++)
            {
                allowedColors[vertices[i].colorId - 1] = false;
            }
            for (int i = 0; i < edges.Length; i++)
            {
                allowedColors[edges[i].colorId - 1] = false;
            }

            List<int> colors = new List<int>();
            for (int i = 0; i < allowedColors.Length; i++)
            {
                if (allowedColors[i])
                {
                    colors.Add(i + 1);
                }
            }
            if (colors.Count == 0)
                return 0;
            return colors.Min();
        }
        
        private int getTotalVertexColor(int colorIndex, ColorizableVertex currentVertex)
        {
            var adjacentVertices = this.getAdjacentVerticesToVertex(currentVertex.id);
            if (adjacentVertices == null)
                return -1;
            var vertices = Array.FindAll(adjacentVertices, x => x.colorId != -1);

            var adjacentEdges = this.getAdjacentEdgesToVertex(currentVertex.id);
            if (adjacentEdges == null)
                return -1;
            var edges = Array.FindAll(adjacentEdges, x => x.colorId != -1);

            bool[] allowedColors = new bool[colorIndex];
            for (int i = 0; i < allowedColors.Length; i++)
                allowedColors[i] = true;
            for (int i = 0; i < vertices.Length; i++)
            {
                allowedColors[vertices[i].colorId - 1] = false;
            }
            for (int i = 0; i < edges.Length; i++)
            {
                allowedColors[edges[i].colorId - 1] = false;
            }

            List<int> colors = new List<int>();
            for (int i = 0; i < allowedColors.Length; i++)
            {
                if (allowedColors[i])
                {
                    colors.Add(i + 1);
                }
            }
            if (colors.Count == 0)
                return 0;
            return colors.Min();
        }
        
        private int getVertexColor(int colorIndex, ColorizableVertex currentVertex)
        {
            var adjacentVertices = this.getAdjacentVerticesToVertex(currentVertex.id);
            if (adjacentVertices == null)
                return -1;

            var vertices = Array.FindAll(adjacentVertices, x => x.colorId != -1);

            bool[] allowedColors = new bool[colorIndex];
            for (int i = 0; i < allowedColors.Length; i++)
                allowedColors[i] = true;
            for (int i = 0; i < vertices.Length; i++)
            {
                allowedColors[vertices[i].colorId - 1] = false;
            }

            List<int> colors = new List<int>();
            for (int i = 0; i < allowedColors.Length; i++)
            {
                if (allowedColors[i])
                {
                    colors.Add(i + 1);
                }
            }
            if (colors.Count == 0)
                return 0;
            return colors.Min();
        }

        private int getEdgeColor(int colorIndex, ColorizableEdge currentEdge)
        {
            var adjacentEdges = this.getAdjacentEdgesToEdge(currentEdge.from, currentEdge.to);
            if (adjacentEdges == null)
                return -1;

            var edges = Array.FindAll(adjacentEdges, x => x.colorId != -1);

            bool[] allowedColors = new bool[colorIndex];
            for (int i = 0; i < allowedColors.Length; i++)
                allowedColors[i] = true;
            for (int i = 0; i < edges.Length; i++)
            {
                allowedColors[edges[i].colorId - 1] = false;
            }

            List<int> colors = new List<int>();
            for (int i = 0; i < allowedColors.Length; i++)
            {
                if (allowedColors[i])
                {
                    colors.Add(i + 1);
                }
            }
            if (colors.Count == 0)
                return 0;
            return colors.Min();
        }

        private bool generateVerticesColors(Color[] colors, int colorIndex)
        {
            for (int i = 0; i < this.vertices.Length; i++)
            {
                int colorId = Math.Max(0, this.vertices[i].colorId - 1);
                this.vertices[i].color = colors[colorId];
            }

            return true;
        }

        private bool generateEdgesColors(Color[] colors, int colorIndex)
        {
            for (int i = 0; i < this.edges.Length; i++)
            {
                int colorId = Math.Max(0, this.edges[i].colorId - 1);
                this.edges[i].color = colors[colorId];
            }

            return true;
        }

        public bool generateColors()
        {
            int colorsCount = 0;

            int edgeColorIndex = 0;
            for (int i = 0; i < this.edges.Length; i++)
            {
                int temp = this.edges[i].colorId;
                if (temp > edgeColorIndex)
                    edgeColorIndex = temp;
            }
            edgeColorIndex = edgeColorIndex > 0 ? edgeColorIndex : 1;
            colorsCount += edgeColorIndex;

            int vertexColorIndex = 0;
            for (int i = 0; i < this.vertices.Length; i++)
            {
                int temp = this.vertices[i].colorId;
                if (temp > vertexColorIndex)
                    vertexColorIndex = temp;
            }
            vertexColorIndex = vertexColorIndex > 0 ? vertexColorIndex : 1;
            colorsCount += vertexColorIndex;

            GradientController gradient = new GradientController();
            Color[] colors = gradient.calculateColors(colorsCount);

            Color[] verticesColors = new Color[vertexColorIndex];
            Array.Copy(colors, 0, verticesColors, 0, vertexColorIndex);
            this.generateVerticesColors(verticesColors, vertexColorIndex);

            Color[] edgesColors = new Color[edgeColorIndex];
            Array.Copy(colors, vertexColorIndex, edgesColors, 0, edgeColorIndex);
            this.generateEdgesColors(edgesColors, edgeColorIndex);

            return true;
        }
    }
}
