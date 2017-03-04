using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE26
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph obj = new Graph();

            obj.DepthFirst("Basement");
            Console.WriteLine("");
            obj.DepthFirst("Kitchen");
            Console.WriteLine("");
            obj.DepthFirst("Parlor");
            Console.WriteLine("");
            obj.DepthFirst("Balcony");
            Console.WriteLine("");
            obj.DepthFirst("Outside");
        }
    }
}
