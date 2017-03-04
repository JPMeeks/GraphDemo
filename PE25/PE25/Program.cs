using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE25
{
    class Program
    {
        static void Main(string[] args)
        {
            // new adjacency list
            AdjacencyMatrix adjacent = new AdjacencyMatrix();
            string room = "Basement";

            while (room != "Outside")
            {
                // tell current room
                Console.WriteLine("You are in: " + room);

                // get adjacent rooms
                List<string> list = adjacent.GetAdjacentList(room);
                Console.Write("Nearby are:");
                for (int x = 0; x < list.Count; x++)
                {
                    Console.Write("   " + list[x] + "   ");
                }
                Console.Write("\n");

                Console.Write("Go to: ");
                string roomTemp = Console.ReadLine();
                if (adjacent.IsConnected(room, roomTemp))
                {
                    room = roomTemp;
                    if (room == "Outside")
                    {
                        Console.WriteLine("Congratulations! You have escaped the house!");
                    }
                }
                else
                {
                    Console.WriteLine("That room is not connected to " + room);
                }
            }
        }
    }
}