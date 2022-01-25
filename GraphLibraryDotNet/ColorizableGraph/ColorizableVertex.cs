using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibraryDotNet
{
    public struct ColorizableVertex
    {
        public int id;
        public int colorId;
        public Color color;

        public ColorizableVertex(int id)
        {
            this.id = id;
            colorId = -1;
            color = Color.Empty;
        }
    }
}
