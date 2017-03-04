using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE24
{
    class AdjacencyList
    {
        // attributes
        Dictionary<string, List<string>> diction; // stores names as keys, and connections as lists

        // constructor
        public AdjacencyList()
        {
            diction = new Dictionary<string, List<string>>();
            List<string>[] list = new List<string>[5];

            // set up lists
            for(int x = 0; x < 5; x++)
            {
                list[x] = new List<string>();
            }

            // add to lists
            list[0].Add("Kitchen");
            list[0].Add("Parlor");
            list[1].Add("Basement");
            list[2].Add("Basement");
            list[2].Add("Balcony");
            list[2].Add("Outside");
            list[3].Add("Parlor");
            list[4].Add("Parlor");

            // set the dictionary
            diction.Add("Basement", list[0]);
            diction.Add("Kitchen", list[1]);
            diction.Add("Parlor", list[2]);
            diction.Add("Balcony", list[3]);
            diction.Add("Outside", list[4]);
        }

        // returns a list of adjacent rooms given a room name
        public List<string> GetAdjacentList(string room)
        {
            if(diction.ContainsKey(room))
                return diction[room];

            else
                return diction["Basement"];
        }

        // check whether two rroms are connected
        public bool IsConnected(string room1, string room2)
        {
            if(GetAdjacentList(room1).Contains(room2))
            {
                return true;
            }
            else
                return false;
        }
    }
}
