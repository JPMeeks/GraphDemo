using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE26
{
    class Graph
    {
        // attributes
        int[,] matrix = new int[5, 5]; // adjacency matrix
        List<Vertex> vertList; // vertex object storage
        Dictionary<string, Vertex> vertDict; // access a vertex based its value

        // constructor
        public Graph()
        {
            // set up data structures
            vertList = new List<Vertex>();
            vertDict = new Dictionary<string, Vertex>();

            // populate the vertex dictionary
            vertDict.Add("Basement", new Vertex("Basement"));
            vertDict.Add("Kitchen", new Vertex("Kitchen"));
            vertDict.Add("Parlor", new Vertex("Parlor"));
            vertDict.Add("Balcony", new Vertex("Balcony"));
            vertDict.Add("Outside", new Vertex("Outside"));

            // populate the vertex list
            vertList.Add(vertDict["Basement"]);
            vertList.Add(vertDict["Kitchen"]);
            vertList.Add(vertDict["Parlor"]);
            vertList.Add(vertDict["Balcony"]);
            vertList.Add(vertDict["Outside"]);

            // set the matrix
            matrix[0, 0] = 0; matrix[0, 1] = 1; matrix[0, 2] = 1; matrix[0, 3] = 0; matrix[0, 4] = 0;
            matrix[1, 0] = 1; matrix[1, 1] = 0; matrix[1, 2] = 0; matrix[1, 3] = 0; matrix[1, 4] = 0;
            matrix[2, 0] = 1; matrix[2, 1] = 0; matrix[2, 2] = 0; matrix[2, 3] = 1; matrix[2, 4] = 1;
            matrix[3, 0] = 0; matrix[3, 1] = 0; matrix[3, 2] = 1; matrix[3, 3] = 0; matrix[3, 4] = 0;
            matrix[4, 0] = 0; matrix[4, 1] = 0; matrix[4, 2] = 1; matrix[4, 3] = 0; matrix[4, 4] = 0;
        }

        // loop through all vertices and set visited to false
        public void Reset()
        {
            for (int x = 0; x < vertList.Count; x++)
            {
                vertList[x].Visited = false;
            }
        }

        // will return adjacent unvisited vertices after being given a specified vertix
        public Vertex GetAdjacentUnvisited(string name)
        {
            // is the key present
            if (vertDict.ContainsKey(name))
            {
                // loop through the list of adjacent vertices
                for(int x = 0; x < 5; x++)
                {
                    if(vertList[x].Visited == true)
                    {
                        for(int y = 0; y < 5; y++)
                        {
                            if(matrix[x,y] == 1 && vertList[y].Visited == false)
                            {
                                return vertList[y];
                            }
                        }
                    }
                }
            }

            // all have been visited or name is invalid
            return null;
        }

        // depth-first search
        public void DepthFirst(string first)
        {
            // is the starting location valid
            if (vertDict.ContainsKey(first) == false)
            {
                Console.WriteLine(first + " IS AN INVALID VERTEX");
                return;
            }

            // reset all of the visited vertices
            Reset();

            // create a stack
            Stack<Vertex> stack = new Stack<Vertex>();

            // list the starting point
            Console.WriteLine("START: " + vertDict[first].Data);

            // store as the initial vertex
            stack.Push(vertDict[first]);
            vertDict[first].Visited = true;

            // search as long there's vertices in the stack
            while (stack.Count > 0)
            {
                // get unvisted adjacent vertex
                Vertex v = GetAdjacentUnvisited(stack.Peek().Data);

                // check if v is null
                if (v == null)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(v);
                    Console.WriteLine(v.Data);
                    v.Visited = true;
                }
            }
        }
    }
}
