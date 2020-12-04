using System;
using System.Collections.Generic;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Dijkstra dijkstra = new Dijkstra();
            dijkstra.createGrapgh();
            dijkstra.FindShortPass();
        }

    }
}
