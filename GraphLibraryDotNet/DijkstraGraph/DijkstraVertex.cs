using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibraryDotNet
{
    public struct DijkstraVertex
    {
        public readonly int id;
        public int previousId;
        public int weight;

        public DijkstraVertex(int id, int previousId, int weight)
        {
            this.id = id;
            this.previousId = previousId;
            this.weight = weight;
        }
    }
}
