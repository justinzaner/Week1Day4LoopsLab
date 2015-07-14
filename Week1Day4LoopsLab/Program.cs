using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_Day_4___Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Section 1; FizzBuzz
            //Introduces the program
            Console.WriteLine("This program is callled FizzBuzz");

            //This for loop runs iterations for each number
            for (int x = 1; x < 101; x++)
            {
                if (x % 3 != 0 && x % 5 != 0)
                    Console.WriteLine(x);
                else if (x % 3 == 0 && x % 5 == 0)
                    Console.WriteLine(x + " FizzBuzz");
                else if (x % 3 == 0)
                    Console.WriteLine(x + " Fizz");
                else if (x % 5 == 0)
                    Console.WriteLine(x + " Buzz");
            }

            string reverseString = "";
            Console.WriteLine();
            Console.WriteLine("This program will reverse whatever you enter");
            Console.WriteLine("Please enter a word or sentence");
            string myWord = Console.ReadLine();
            Console.WriteLine("You entered: " + myWord);
            for (int i = myWord.Length - 1; i >= 0; i--)
            {
                reverseString = String.Concat(reverseString, myWord[i]);
            }

            Console.Write("In reverse that is: " + reverseString);

            Console.Read();
        }
    }
}