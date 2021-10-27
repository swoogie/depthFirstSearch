using System;
using System.Collections.Generic;
 
namespace DFS
{
class Digraph {
    private int V;
 
    private List<int>[] adj;    // Gretimumo sarasas
 
    Digraph(int v) // Constr.
    {
        V = v;
        adj = new List<int>[ v ];
        for (int i = 0; i < v; ++i)
            adj[i] = new List<int>();
    }
 
    void Briauna(int v, int w)
    {
        adj[v].Add(w); // sukuriami krastai
    }
 
    void DFSFun(int v, bool[] visited)
    {
        visited[v] = true; // Taskas pazymimas kaip aplankytas
        Console.Write(v + " "); // ir israsomas
 
        //visoms virsunems gretimoms pirmai aplankytai virsunei
        List<int> vList = adj[v];
        foreach(var n in vList)
        {
            if (!visited[n])
                DFSFun(n, visited); // jeigu virsune neaplankyta atliekama rekursija
        }
    }
 
    void DFS(int v)
    {
        bool[] visited = new bool[V]; // visi taskai pazymimi kaip neaplankyti
        DFSFun(v, visited);
    }
 
    public static void Main(String[] args)
    {
        Digraph g = new Digraph(5); // 5 - virsuniu skaicius
        
        g.Briauna(0, 1);
        g.Briauna(0, 2);
        g.Briauna(1, 0);
        g.Briauna(1, 3);
        g.Briauna(2, 1);
        g.Briauna(2, 3);
        g.Briauna(3, 0);
        g.Briauna(2, 2);
        g.Briauna(2, 4);
 
        Console.WriteLine(
            "Skaiciu seka pagal gyli: ");
 
        g.DFS(0); // 0 - virsune nuo kurios pradedame 
    }
}
}