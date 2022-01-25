﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibraryDotNet
{
    public struct Vertex
    {
        public readonly int id;
        public int weight;

        public Vertex(int id, int weight = 0)
        {
            this.id = id;
            this.weight = weight;
        }
    }
}
