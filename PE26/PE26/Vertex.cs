using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE26
{
    // one vertex in a graph
    class Vertex
    {
        // attributes
        private string data;
        private bool visited;

        // constructor
        public Vertex(string str)
        {
            data = str;
            visited = false;
        }

        // properties
        public string Data
        {
            get { return data; }
        }

        public bool Visited
        {
            get { return visited; }
            set { visited = value; }
        }
    }
}
