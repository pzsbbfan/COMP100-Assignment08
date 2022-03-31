using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP100_Assignment08
{
    internal class Program
    {
        static void Print(string[] strArray)
        {
            foreach (var str in strArray)
            {
                Console.Write(str + " ");
            }
        }
        static void Main(string[] args)
        {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 };
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();

            Print(poem);
            Console.ReadLine();
        }
    }
}
