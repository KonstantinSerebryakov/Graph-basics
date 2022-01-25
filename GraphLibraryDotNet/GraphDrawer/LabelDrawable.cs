using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibraryDotNet
{
    public struct LabelDrawable
    {
        public readonly string text;
        public readonly Color color;
        public Rectangle? rect;

        public LabelDrawable(string text, Color color)
        {
            this.text = text;
            this.color = color;
            rect = null;
        }
    }
}
