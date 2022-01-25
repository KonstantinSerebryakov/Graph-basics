using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibraryDotNet
{
    public struct Edge
    {
        public readonly int from;
        public readonly int to;
        public readonly int weight;

        public Edge(int from, int to, int weight = 0)
        {
            this.from = from;
            this.to = to;
            this.weight = weight;
        }
    }
}
