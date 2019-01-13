using System;

namespace GraphInDepth
{
 
 
    class Program
    {
     
public class StackX
{
private readonly int SIZE =20;
private int[] st;
private int top;
public StackX() // constructor
{
st = new int[SIZE]; // make array
top = -1;
}
public virtual void push(int j) // put item on stack
{
    st[++top] = j;
}
public virtual int pop() // take item off stack
{
    return st[top--];
}
public virtual int peek() // peek at top of stack
{
    return st[top];
}
public virtual bool Empty
{
    get
    {
        return (top == -1);
    }
}
} // end class StackX
////////////////////////////////////////////////////////////////
 
       
public class Vertex
{
public char label; // label (e.g. 'A')
public bool wasVisited;
// ------------------
public Vertex(char lab) // constructor
{
label = lab;
wasVisited = false;
}
// ------------------
} // end class Vertex
////////////////////////////////////////////////////////////////
 
               
public class Graph
{
private readonly int MAX_VERTS = 20;
private Vertex[] vertexList; // list of vertices
private int[][] adjMat; // adjacency matrix
private int nVerts; // current number of vertices
private StackX theStack;
// ------------------
public Graph() // constructor
{
vertexList = new Vertex[MAX_VERTS];
// adjacency matrix
//ORIGINAL LINE: adjMat = new int[MAX_VERTS][MAX_VERTS];
adjMat = RectangularArrays.ReturnRectangularIntArray(MAX_VERTS, MAX_VERTS);
nVerts = 0;
for (int j = 0; j < MAX_VERTS; j++) // set adjacency
{
for (int k = 0; k < MAX_VERTS; k++) // matrix to 0
{
adjMat[j][k] = 0;
}
}
theStack = new StackX();
} // end constructor
// ------------------
public virtual void addVertex(char lab)
{
vertexList[nVerts++] = new Vertex(lab);
}
// ------------------
public virtual void addEdge(int start, int end)
{
adjMat[start][end] = 1;
adjMat[end][start] = 1;
}
// ------------------
public virtual void displayVertex(int v)
{
Console.Write(vertexList[v].label);
}
// ------------------
public virtual void dfs() // depth-first search
{ // begin at vertex 0
vertexList[0].wasVisited = true; // mark it
displayVertex(0); // display it
theStack.push(0); // push it
while (!theStack.Empty) // until stack empty,
{
// get an unvisited vertex adjacent to stack top
int v = getAdjUnvisitedVertex(theStack.peek());
if (v == -1) // if no such vertex,
{
theStack.pop();
}
else // if it exists,
{
vertexList[v].wasVisited = true; // mark it
displayVertex(v); // display it
theStack.push(v); // push it
}
} // end while
// stack is empty, so we're done
for (int j = 0; j < nVerts; j++) // reset flags
{
vertexList[j].wasVisited = false;
}
} // end dfs
// ------------------
// returns an unvisited vertex adj to v
public virtual int getAdjUnvisitedVertex(int v)
{
for (int j = 0; j < nVerts; j++)
{
if (adjMat[v][j] == 1 && vertexList[j].wasVisited == false)
{
return j;
}
}
return -1;
} // end getAdjUnvisitedVert()
// ------------------
 
} 
internal static partial class RectangularArrays
{
    internal static int[][] ReturnRectangularIntArray(int Size1, int Size2)
    {
        int[][] Array = new int[Size1][];
        for (int Array1 = 0; Array1 < Size1; Array1++)
        {
            Array[Array1] = new int[Size2];
        }
        return Array;
    }
}
 
public static void Main(string[] args)
{
Graph theGraph = new Graph();
theGraph.addVertex('1'); // 0 (start for dfs)
theGraph.addVertex('2'); // 1
theGraph.addVertex('3'); // 2
theGraph.addVertex('4'); // 3
theGraph.addVertex('5'); // 4
theGraph.addEdge(0, 1); // 1-2
theGraph.addEdge(1, 4); // 2-5
theGraph.addEdge(4, 2); // 5-3
theGraph.addEdge(2, 3); // 3-4
Console.Write("Visits: ");
theGraph.dfs(); // depth-first search
Console.WriteLine();
    Console.ReadKey();
} // end main()
 
    }
}
