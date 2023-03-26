using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace TestProject
{

    class Program
    {
        
        public static void Main(string[] rushikesh)
        {
            Console.WriteLine("Enter String");
            string input, reverse = string.Empty;
            input = Console.ReadLine();
            if (input != null)
            {
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reverse = reverse + input[i];

                }
                if (reverse == input)
                {
                    Console.WriteLine("GIVEN STRINGS ARE PALINDROME" + input + reverse);
                }
            }


        }
    }
}



