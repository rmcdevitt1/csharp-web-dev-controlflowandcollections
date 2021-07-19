using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Arrays!");

            int[] numbers = new int[] { 1, 1, 2, 3, 5, 8 };

            //INSTTRUCTIONS:
            //1.Loop through the array and print out each value.

            //2.Modify the loop to only print the odd numbers from the array.



            //HOW DO I DO IT WITH A FOREACH LOOP?!?
            foreach (int number in numbers)
            {
                if(number % 2 != 0)
                {
                    Console.WriteLine(number);
                }
                
            }


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //this is printing 0 1 3 4 WTF?!?!




        }
    }
}
