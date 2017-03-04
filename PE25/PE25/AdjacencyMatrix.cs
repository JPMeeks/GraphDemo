using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE25
{
    class AdjacencyMatrix
    {
        // attributes
        string[] names = new string[5];
        int[,] matrix = new int[5, 5];

        // constructor
        public AdjacencyMatrix()
        {
            // set the names
            names[0] = "Basement";
            names[1] = "Kitchen";
            names[2] = "Parlor";
            names[3] = "Balcony";
            names[4] = "Outside";

            // set the matrix
            matrix[0, 0] = 0; matrix[0, 1] = 1; matrix[0, 2] = 1; matrix[0, 3] = 0; matrix[0, 4] = 0;
            matrix[1, 0] = 1; matrix[1, 1] = 0; matrix[1, 2] = 0; matrix[1, 3] = 0; matrix[1, 4] = 0;
            matrix[2, 0] = 1; matrix[2, 1] = 0; matrix[2, 2] = 0; matrix[2, 3] = 1; matrix[2, 4] = 1;
            matrix[3, 0] = 0; matrix[3, 1] = 0; matrix[3, 2] = 1; matrix[3, 3] = 0; matrix[3, 4] = 0;
            matrix[4, 0] = 0; matrix[4, 1] = 0; matrix[4, 2] = 1; matrix[4, 3] = 0; matrix[4, 4] = 0;
            
        }

        // returns a list of adjacent rooms given a room name
        public List<string> GetAdjacentList(string room)
        {
            List<string> list = new List<string>();
            int roomLocation = CheckRoom(room);
            
            if(roomLocation == -1)
            {
                return null;
            }
            else
            {
                for(int x = 0; x < 5; x++)
                {
                    if(matrix[roomLocation, x] == 1)
                    {
                        list.Add(names[x]);
                    }
                }
            }

            return list;
        }

        // check whether two rroms are connected
        public bool IsConnected(string room1, string room2)
        {
            if (GetAdjacentList(room1).Contains(room2))
            {
                return true;
            }
            else
                return false;
        }

        // gets position in names array of a room
        public int CheckRoom(string room)
        {
            if (room.ToUpper() == "BASEMENT")
                return 0;
            else if (room.ToUpper() == "KITCHEN")
                return 1;
            else if (room.ToUpper() == "PARLOR")
                return 2;
            else if (room.ToUpper() == "BALCONY")
                return 3;
            else if (room.ToUpper() == "OUTSIDE")
                return 4;
            else
                return -1;
        }
    }
}