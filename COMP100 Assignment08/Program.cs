using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP100_Assignment08
{
    internal class Program
    {
        static void Print(int[] intArray)
        {
            foreach (var num in intArray)
            {
                Console.Write(num + " ");
            }
        }
        static void Main(string[] args)
        {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 };
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();

            Print(numbers);
            Console.WriteLine();
            Console.WriteLine("position of number 3 in numbers: ");
            Console.WriteLine(Array.BinarySearch(numbers, 3));
            Console.WriteLine();
            Console.WriteLine("numbers list after sorted: ");
            Array.Sort(numbers);
            Print(numbers);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("After sorting the list, the position of number 3 in numbers:");
            Console.WriteLine(Array.BinarySearch(numbers, 3));
            Console.ReadLine();
        }



    }
}
