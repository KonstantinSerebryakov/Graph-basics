using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibraryDotNet
{
    public struct VertexDrawable
    {
        public readonly int id;
        public readonly Point center;
        public readonly double degree;

        public VertexDrawable(int id, int x, int y, double degree)
        {
            this.id = id;
            this.center = new Point(x, y);
            this.degree = degree;
        }
    }

    public class VertexDrawableComparer: IComparer
    {
        public int Compare(object x, object y)
        {
            return (new CaseInsensitiveComparer()).Compare(((VertexDrawable)x).id, ((VertexDrawable)y).id);
        }
    }
}
