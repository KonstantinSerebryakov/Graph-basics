using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibraryDotNet
{
    public struct ColorizableEdge
    {
        public int from;
        public int to;
        public int colorId;
        public Color color;

        public ColorizableEdge(int from, int to)
        {
            this.from = from;
            this.to = to;
            this.colorId = -1;
            color = Color.Empty;
        }
    }
}
