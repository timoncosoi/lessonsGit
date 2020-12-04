using System;
using System.Collections.Generic;

namespace dotnet{
    class Vertex{

        public string Name{get;}
        public double Cost{get;set;}

        public Vertex(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }
    }
}