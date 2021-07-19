using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Strings!");

            string sentence = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";

            string[] arr1 = sentence.Split("");

            Console.WriteLine(string.Join(",", arr1));

            string[] arr2 = sentence.Split(". ");

            Console.WriteLine(string.Join(". ", arr2));
        }
    }
}
