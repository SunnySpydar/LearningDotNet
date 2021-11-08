using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //version1 of string array
            
            string[] animals = new string[5] { "Cat", "Dog", "Bird", "Bug", "Lizard" };
            foreach (string i in animals)
            {
                Console.WriteLine(i);
            }

            //version2 of string array

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
            }

            //version1 of int array

            int[] myNumbers = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            for (int i = myNumbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myNumbers[i] + " ");
            }

            //version2 of int array

            Array.Sort(myNumbers);
            Array.Reverse(myNumbers);
            for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.Write(myNumbers[i] + " ");
            }






            Console.ReadLine();
        }

    }
}
