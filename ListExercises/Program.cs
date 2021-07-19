using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            //INSTRUCTIONS:
            //Write a static method to find the sum of all the even numbers in a List.
            //Within Main, create a list with at least 10 integers and call your method on the list.
            //Write a static method to print out each word in a list that has exactly 5 letters.
            //Modify your code to prompt the user to enter the word length for the search.


            Console.WriteLine("Hello Lists!");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

   

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    + number;
                }
            }

        }

        static void SumofEvens(string[] args)
        {
       

        }
    }
}
