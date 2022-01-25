using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibraryDotNet
{
    public class Graph
    {
        private List<Vertex> vertices = null;
        private List<Edge> edges = null;

        public bool isOriented = false;
        public bool isWeighted = false;

        public readonly int MAX_VERTICES_COUNT = 1000;

        public Graph()
        {
            this.vertices = null;
            this.edges = null;

            this.isOriented = false;
            this.isWeighted = false;
        }

        public List<Vertex> getVertices()
        {
            List<Vertex> list = new List<Vertex>();
            foreach(Vertex vertex in this.vertices)
            {
                list.Add(new Vertex(vertex.id, vertex.weight));
            }
            return list;
        }

        public int getVerticesCount()
        {
            if (this.vertices != null)
            {
                return this.vertices.Count();
            } else
            {
                return -1;
            }
        }

        public Vertex? getVertex(int id)
        {
            int index = this.vertices.FindIndex(vertex => vertex.id == id);
            if (index == -1)
            {
                return null;
            } else
            {
                return this.vertices[index];
            }
        }

        public List<Edge> getChildEdges(int id)
        {
            List<Edge> list = new List<Edge>();
            foreach (Edge edge in this.edges)
            {
                if (edge.from == id)
                {
                    list.Add(new Edge(edge.from, edge.to, edge.weight));
                }
            }
            return list;
        }

        public List<Edge> getParentEdges(int id)
        {
            List<Edge> list = new List<Edge>();
            foreach (Edge edge in this.edges)
            {
                if (edge.to == id)
                {
                    list.Add(new Edge(edge.from, edge.to, edge.weight));
                }
            }
            return list;
        }

        public List<Edge> getEdges()
        {
            List<Edge> list = new List<Edge>();
            foreach(Edge edge in this.edges)
            {
                list.Add(new Edge(edge.from, edge.to, edge.weight));
            }
            return list;
        }

        public Edge? getEdge(int from, int to)
        {
            int index = this.edges.FindIndex(edge => edge.from == from && edge.to == to);
            if (index == -1)
            {
                return null;
            }
            else
            {
                return this.edges[index];
            }
        }

        public int getEdgesCount()
        {
            return this.edges.Count();
        }

        public bool isNotEmpty()
        {
            return vertices != null && edges != null && vertices.Count > 0 && edges.Count > 0;
        }

        private bool readKeysFromFileReader(StreamReader reader)
        {
            string buff;

            while ((buff = reader.ReadLine()) != null)
            {
                string[] pair = buff.Split(new char[] { ':', ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
                if (pair.Length > 0)
                {
                    switch (pair[0])
                    {
                        case "oriented":
                            {
                                if (pair[1] == "true")
                                {
                                    this.isOriented = true;
                                }
                                else if (pair[1] == "false")
                                {
                                    this.isOriented = false;
                                }
                                break;
                            }
                        case "weighted":
                            {
                                if (pair[1] == "true")
                                {
                                    this.isWeighted = true;
                                }
                                else if (pair[1] == "false")
                                {
                                    this.isWeighted = false;
                                }
                                break;
                            }
                        case "verticesCount":
                            {
                                int size;
                                if (int.TryParse(pair[1], out size) && size < this.MAX_VERTICES_COUNT)
                                {
                                    this.vertices = new List<Vertex>();
                                    for (int i = 0; i < size; i++)
                                    {
                                        this.vertices.Add(new Vertex(i + 1));
                                    }
                                }
                                break;
                            }
                    }
                }
            }

            if (this.vertices == null || this.vertices.Count < 1)
            {
                return false;
            } else
            {
                return true;
            }
        }

        private List<string> writeKeysToBuffer(List<string> buffer)
        {
            string temp = "";

            temp = "=======================";
            buffer.Add(temp);
            temp = "===       keys      ===";
            buffer.Add(temp);
            temp = "=======================";
            buffer.Add(temp);

            temp = "oriented: ";
            temp += isOriented ? "true" : "false";
            buffer.Add(temp);

            temp = "weighted: ";
            temp += isWeighted ? "true" : "false";
            buffer.Add(temp);

            if (this.vertices == null)
            {
                return null;
            }
            temp = "verticesCount: ";
            temp += this.vertices.Count();
            buffer.Add(temp);

            return buffer;
        }

        public bool saveGraphToFile(string filePath)
        {
            try
            {
                List<string> buffer = new List<string>();
                buffer = this.writeKeysToBuffer(buffer);

                if (buffer != null)
                {
                    buffer.Add("");
                    buffer = this.writeMatricesToBuffer(buffer);
                    buffer.Add("");
                }

                if (buffer == null)
                {
                    return false;
                }

                buffer.Add("=======================");
                buffer.Add("=        hints        =");
                buffer.Add("=======================");
                buffer.Add("1) any comments allowed in this file");
                buffer.Add("2) * means null value");
                buffer.Add("3) 0 means zero-weighted value");
                buffer.Add("4) no rows allowed between #matrix definition and matrix");
                buffer.Add("5) any spaces allowed");
                buffer.Add("6) in non-oriented graphs only top-right values handled");
                buffer.Add("7) top-left - down-right diagonal line always must be null (* filled)");

                StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8);

                for (int i = 0; i < buffer.Count(); i++)
                {
                    writer.WriteLine(buffer[i]);
                }

                writer.Close();
                return true;
            } catch
            {
                return false;
            }
        }

        private List<string> writeMatricesToBuffer(List<string> buffer)
        {
            string temp;

            temp = "=======================";
            buffer.Add(temp);
            temp = "===     matrices    ===";
            buffer.Add(temp);
            temp = "=======================";
            buffer.Add(temp);

            if (this.vertices == null || this.edges == null)
            {
                return null;
            }

            string[,] matrix = new string[this.vertices.Count, this.vertices.Count];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    matrix[i, j] = "*";
                }
            }

            foreach (Edge edge in this.edges)
            {
                int from = edge.from - 1;
                int to = edge.to - 1;
                int weight = this.isWeighted ? edge.weight : 0;

                matrix[from, to] = weight.ToString();
                if (!isOriented)
                {
                    matrix[to, from] = weight.ToString();
                }
            }

            int[] cellLengths = new int[matrix.GetLength(0)];
            for (int i = 0; i < cellLengths.Length; i++) cellLengths[i] = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    cellLengths[j] = Math.Max(matrix[i, j].Length, cellLengths[j]);
                }
            }

            temp = "#matrix";
            buffer.Add(temp);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                temp = "";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    temp += " " + matrix[i, j].PadLeft(cellLengths[j], ' ');
                }
                buffer.Add(temp.Substring(1));
            }

            return buffer;
        }

        private bool readMatricesFromFileReader(StreamReader reader)
        {
            string buff;

            int matrixRowsRemaining = 0;
            while ((buff = reader.ReadLine()) != null)
            {
                if (matrixRowsRemaining > 0)
                {
                    int vertexId = this.vertices.Count - matrixRowsRemaining; // vertexId can be from 0 to length - 1
                    string[] cols = buff.Trim().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (cols.Length < this.vertices.Count)
                    {
                        return false;
                    }

                    int from;
                    if (this.isOriented)
                    {
                        from = 0;
                    } else
                    {
                        from = vertexId;
                    }
                    for (int i = from; i < this.vertices.Count; i++)
                    {
                        int value;
                        if (int.TryParse(cols[i].Trim(), out value) && i != vertexId)
                        {
                            Edge edge;
                            if (this.isWeighted)
                            {
                                edge = new Edge(vertexId + 1, i + 1, value);
                            }
                            else
                            {
                                edge = new Edge(vertexId + 1, i + 1);
                            }
                            this.edges.Add(edge);

                            if (!this.isOriented)
                            {
                                this.edges.Add(new Edge(edge.to, edge.from, edge.weight));
                            }
                        }
                        else if (cols[i].Trim() != "*")
                        {
                            return false;
                        }

                    }

                    matrixRowsRemaining--;
                }
                else
                {
                    string key = buff.Trim();
                    switch (key)
                    {
                        case "#matrix":
                            {
                                if (this.vertices == null || this.vertices.Count < 1)
                                {
                                    return false;
                                }

                                matrixRowsRemaining = this.vertices.Count;
                                this.edges = new List<Edge>();
                                break;
                            }
                    }
                }
            }

            if (this.edges == null || this.edges.Count < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool generateGraphFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return false;
            }

            try
            {
                StreamReader reader = File.OpenText(filePath);
                bool isCorrect = this.readKeysFromFileReader(reader);
                
                if (isCorrect)
                {
                    reader.BaseStream.Position = 0;
                    isCorrect = this.readMatricesFromFileReader(reader);
                }

                reader.Close();
                return isCorrect;
            }
            catch
            {
                return false;
            }
        }

        public string[,] getAdjacencyMatrix(bool isMirrored = false)
        {
            if (this.vertices == null || this.edges == null)
            {
                return new string[0, 0];
            }

            string[,] matrix = new string[this.vertices.Count, this.vertices.Count];
            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                {
                    matrix[i, j] = "*";
                }
            }

            foreach (Edge edge in this.edges)
            {
                if (isMirrored)
                {
                    matrix[edge.from - 1, edge.to - 1] = edge.weight.ToString();
                } else if (edge.to > edge.from)
                {
                    matrix[edge.from - 1, edge.to - 1] = edge.weight.ToString();
                }
            }

            return matrix;
        }

        public bool generateRandomGraph(bool isOriented = false, bool isWeighted = false, int size = 10)
        {
            this.isOriented = isOriented;
            this.isWeighted = isWeighted;

            Random random = new Random();

            this.vertices = new List<Vertex>();
            for (int i = 0; i < size; i++)
            {
                this.vertices.Add(new Vertex(i + 1));
            }

            this.edges = new List<Edge>();
            for (int i = 0; i < vertices.Count(); i++) {
                int j;
                if (this.isOriented)
                    j = 0;
                else
                    j = i;
                for (; j < vertices.Count(); j++)
                {
                    if (i != j && random.Next(0, 2) == 1)
                    {
                        Edge edge;
                        if (this.isWeighted)
                        {
                            edge = new Edge(i + 1, j + 1, random.Next(1, 1000));
                        } else
                        {
                            edge = new Edge(i + 1, j + 1);
                        }
                        this.edges.Add(edge);

                        if (!this.isOriented)
                        {
                            this.edges.Add(new Edge(edge.to, edge.from, edge.weight));
                        }
                    }
                }
            }
            return true;
        }
    }
}
