using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibraryDotNet
{
    public class DijkstraGraph
    {
        Graph graph;
        DijkstraVertex[] vertices;
        public int sourceId;

        public DijkstraGraph(Graph graph)
        {
            this.graph = graph;
            this.vertices = new DijkstraVertex[graph.getVerticesCount()];
            for (int i = 0; i < this.vertices.Length; i++)
            {
                this.vertices[i] = new DijkstraVertex(i + 1, -1, int.MaxValue);
            }
            this.sourceId = -1;
        }

        public bool calculateDijkstraFrom(int id)
        {
            if (id > this.graph.getVerticesCount() || id < 1)
            {
                return false;
            }

            this.sourceId = id;

            List<Vertex> graphVertices = this.graph.getVertices();
            this.vertices = new DijkstraVertex[graphVertices.Count()];
            for (int i = 0; i < graphVertices.Count(); i++)
            {
                this.vertices[graphVertices[i].id - 1] = new DijkstraVertex(graphVertices[i].id, -1, int.MaxValue);
            }

            List<Edge> queried = this.graph.getEdges();

            Vertex? vertex;
            int currentId = id;
            vertex = this.graph.getVertex(currentId);
            if (!vertex.HasValue)
            {
                return false;
            }
            int index;
            index = Array.FindIndex(this.vertices, x => x.id == currentId);
            if (index == -1)
            {
                return false;
            }
            this.vertices[index] = new DijkstraVertex(currentId, -1, vertex.Value.weight);

            bool isLooped = false;
            while (queried.Count() > 0 && !isLooped)
            {
                var currentEdgesInQuery = queried.FindAll(x => x.from == currentId);
                if (currentEdgesInQuery.Count() < 1)
                {
                    isLooped = true;
                }
                for (int i = 0; i < currentEdgesInQuery.Count(); i++)
                {
                    Vertex? potentialVertex = this.graph.getVertex(currentEdgesInQuery[i].to);
                    if (!potentialVertex.HasValue)
                    {
                        return false;
                    }

                    int indexFrom = Array.FindIndex(this.vertices, x => x.id == currentEdgesInQuery[i].from);
                    if (indexFrom == -1)
                    {
                        return false;
                    }
                    int indexTo = Array.FindIndex(this.vertices, x => x.id == currentEdgesInQuery[i].to);
                    if (indexTo == -1)
                    {
                        return false;
                    }

                    int potentialWeight = this.vertices[indexFrom].weight + currentEdgesInQuery[i].weight + potentialVertex.Value.weight;
                    if (potentialWeight < this.vertices[indexTo].weight)
                    {
                        this.vertices[indexTo] = new DijkstraVertex(currentEdgesInQuery[i].to, currentEdgesInQuery[i].from, potentialWeight);
                    }

                    index = queried.FindIndex(x => x.from == currentEdgesInQuery[i].from && x.to == currentEdgesInQuery[i].to);
                    queried.RemoveAt(index);
                }

                //select minimum
                if (queried.Count() > 0)
                {
                    int tempId = queried[0].from;
                    index = Array.FindIndex(this.vertices, x => x.id == tempId);
                    if (index == -1)
                    {
                        return false;
                    }
                    int tempWeight = this.vertices[index].weight;
                    for (int i = 1; i < queried.Count(); i++)
                    {
                        index = Array.FindIndex(this.vertices, x => x.id == queried[i].from);
                        if (index == -1)
                        {
                            return false;
                        }
                        if (this.vertices[index].weight < tempWeight)
                        {
                            tempId = queried[i].from;
                            tempWeight = this.vertices[index].weight;
                        }
                    }
                    currentId = tempId;
                }
            }

            return true;
        }

        public DijkstraVertex[] getDijkstraPathVerticesTo(int id)
        {
            int index = Array.FindIndex(this.vertices, x => x.id == id);
            if (index == -1)
            {
                return null;
            }

            List<DijkstraVertex> dijkstraVertices = new List<DijkstraVertex>();

            DijkstraVertex vertex;
            vertex = this.vertices[index];
            dijkstraVertices.Add(vertex);
            while (vertex.previousId != -1)
            {
                index = Array.FindIndex(this.vertices, x => x.id == vertex.previousId);
                if (index == -1)
                {
                    return null;
                }
                vertex = this.vertices[index];
                dijkstraVertices.Add(vertex);
            }

            if (vertex.id == this.sourceId)
            {
                return dijkstraVertices.ToArray();
            }
            else
            {
                return null;
            }
        }
    }
}
