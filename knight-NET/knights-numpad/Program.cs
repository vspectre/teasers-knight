using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knights_numpad
{
    class Program
    {
        static int _maxDepth;

        static void Main(string[] args)
        {
            string maxDepthString = String.Empty;
            do
            {
                Console.Write("Enter depth to calculate: ");
                maxDepthString = Console.ReadLine();
            }
            while (!int.TryParse(maxDepthString, out _maxDepth));

            int total = StupidDynamicArray.Run(_maxDepth);

            Console.WriteLine("Total possible paths: {0}", total);
            Console.ReadKey();
        }
    }
}
