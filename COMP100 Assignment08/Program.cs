using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP100_Assignment08
{
    internal class Program
    {
        static int[] func(int number)
        {
            int[] myArray = new int[number];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Enter the {i + 1} item in the array");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            return myArray;
        }
        static void Main(string[] args)
        {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 };
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();

            int[] a = func(5);
            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine();
            Console.WriteLine("All elements in this variable: " + String.Join(" ",a));
            Console.ReadLine();
        }



    }
}
