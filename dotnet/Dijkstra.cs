using System;
using System.Collections.Generic;

namespace dotnet{
    class Dijkstra{
        public List<Vertex> VertexList{get;set;} = new List<Vertex>();
        List<Edge> EdgeList{get;set;} = new List<Edge>();
        public void AddVertex(Vertex vertexItem){
            VertexList.Add(vertexItem);
        }
        public void AddEdge(Edge edgeItem){
            EdgeList.Add(edgeItem);
        }
        public Vertex ReturnVertexByName(string nameVertexItem){
            foreach (Vertex item in VertexList)
            {
                if(item.Name == nameVertexItem){
                    return item;
                }
            }
            return null;
        }
        public void CreateGrapgh(){
            AddVertex(new Vertex("Start",0));
            AddVertex(new Vertex("A",double.MaxValue));
            AddVertex(new Vertex("B",double.MaxValue));
            AddVertex(new Vertex("C",double.MaxValue));
            AddVertex(new Vertex("D",double.MaxValue));
            AddVertex(new Vertex("Finish",double.MaxValue));

            AddEdge(new Edge(5, returnVertexByName("Start"), returnVertexByName("A")));
            AddEdge(new Edge(2, returnVertexByName("Start"), returnVertexByName("C")));
            AddEdge(new Edge(4, returnVertexByName("A"), returnVertexByName("B")));
            AddEdge(new Edge(2, returnVertexByName("A"), returnVertexByName("D")));
            AddEdge(new Edge(3, returnVertexByName("B"), returnVertexByName("Finish")));
            AddEdge(new Edge(6, returnVertexByName("B"), returnVertexByName("D")));
            AddEdge(new Edge(7, returnVertexByName("C"), returnVertexByName("D")));
            AddEdge(new Edge(8, returnVertexByName("C"), returnVertexByName("A")));
            AddEdge(new Edge(1, returnVertexByName("D"), returnVertexByName("Finish")));
        }
        public void FindShortPass(){
            foreach (var item in EdgeList)
            {
                if((item.StartVertex.Cost+item.Cost)<item.FinishVertex.Cost){
                    item.FinishVertex.Cost=item.StartVertex.Cost+item.Cost;
                }
            }
            ShowResultOnConsole();
        }
        public Edge ReturnEdgeByVertex(Vertex vertexItem){
            foreach (Edge edgeItem in EdgeList)
            {
                if(edgeItem.StartVertex.Name == vertexItem.Name){
                    return edgeItem;
                }
            }
            return null;
        }
        public void ShowResultOnConsole(){
            foreach(var item in VertexList){
                System.Console.WriteLine(item.Name+"---"+item.Cost);
            }
        }
    }
}
