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
            List<string> words = new List<string> { "dog", "cat", "Raine", "birds", "salamander" };

            int myListSum = 0;

            myListSum = SumofEvents(numbers);
            Console.WriteLine(myListSum);

            Printing(words);

            Console.WriteLine("Please enter the length of a word to search: ");
            var input = Console.ReadLine();
            int result = Int32.Parse(input);

            Printing(words, result);
            

        }
        //Write a static method to find the sum of all the even numbers in a List.
        static int SumofEvents(List<int> inputList)
        {
            int sum = 0;
            foreach (int number in inputList)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            return sum;

        }
        //Write a static method to print out each word in a list that has exactly 5 letters.
        static void Printing(List<string> inputList)
        {
            foreach (string word in inputList)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                }

            }
            
        }

        static void Printing(List<string> inputList, int searchLength)
        {
            foreach (string word in inputList)
            {
                if (word.Length == searchLength)
                {
                    Console.WriteLine(word);
                }

            }

        }


    }
}
