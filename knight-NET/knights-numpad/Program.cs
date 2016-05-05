using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knights_numpad
{
    class Program
    {
        static int[,] _keypad;
        static int _maxDepth;

        static void Main(string[] args)
        {
            init();

            string maxDepth = String.Empty;
            do
            {
                Console.Write("Enter depth to calculate: ");
                maxDepth = Console.ReadLine();
            }
            while (!int.TryParse(maxDepth, out _maxDepth));

            int total = GetPossiblePathCount(0, 0, 0);

            Console.WriteLine("Total possible paths: {0}", total);
            Console.ReadKey();
        }

        static void init()
        {
            _keypad = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
                { -1, 0, -1 }
            };

            int rank = _keypad.Rank;
            int dimensions = _keypad.GetLength(0);
            dimensions = _keypad.GetLength(1);
            int length = _keypad.Length;
            int lower = _keypad.GetLowerBound(0);
            int upper = _keypad.GetUpperBound(0);
        }

        static bool IsValidMove(int x, int y)
        {
            return !(y < _keypad.GetLowerBound(0) || y > _keypad.GetUpperBound(0) ||
                x < _keypad.GetLowerBound(1) || x > _keypad.GetUpperBound(1) || 
                _keypad[y, x].Equals(-1));
        }

        static int GetPossiblePathCount(int x, int y, int depth)
        {
            if (depth > _maxDepth)
                return 0;
            if (!IsValidMove(x, y))
                return 0;

            int count = (depth == 0) ? 0 : 1;
            depth++;
            //left-up
            count += GetPossiblePathCount(x - 2, y - 1, depth);
            //left-down
            count += GetPossiblePathCount(x - 2, y + 1, depth);
            //right-up
            count += GetPossiblePathCount(x + 2, y - 1, depth);
            //right-down
            count += GetPossiblePathCount(x + 2, y + 1, depth);
            //up-left
            count += GetPossiblePathCount(x - 1, y - 2, depth);
            //up-right
            count += GetPossiblePathCount(x + 1, y - 2, depth);
            //down-left
            count += GetPossiblePathCount(x - 1, y + 2, depth);
            //down-right
            count += GetPossiblePathCount(x + 1, y + 2, depth);

            return count;
        }
    }
}
