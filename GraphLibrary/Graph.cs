using System;
using System.Diagnostics;
using System.IO;

namespace GraphLibrary
{
    public class Graph
    {
        private Vertex[] vertices = null;
        private Edge[] edges = null;

        public Graph()
        {
            vertices = null;
            edges = null;
        }

        public bool isNotEmpty()
        {
            return vertices != null && edges != null;
        }

        public bool generateGraphFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return false;
            }

            using (StreamReader sr = File.OpenText(filePath))
            {
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    Debug.WriteLine(str);
                    Debug.WriteLine(str.Length);
                }
            }
            return true;
        }
    }
}
