using System;

namespace dotnet{
    class Edge{
        public double Cost{get;}
        public Vertex StartVertex{get;}
        public Vertex FinishVertex{get;}
        public Edge(double cost, Vertex startVertex, Vertex fiinishVertex)
        {
            Cost = cost;
            StartVertex = startVertex;
            FinishVertex = fiinishVertex;
        }
    }
}