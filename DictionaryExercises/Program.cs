using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Dictionary!");

            //(keys:IDs, values:names)
            Dictionary<int, string> students = new Dictionary<int, string>();
            int newStudentID;
            string newName;

            Console.WriteLine("Enter your students ID number (or ENTER to finish):");


            //"COPIED" CONTENT:
            do
            {
                Console.WriteLine("Student ID Number: ");
                string input = Console.ReadLine();
                newStudentID = int.Parse(input);

                if (!Equals(newStudentID, ""))
                {
                    Console.WriteLine("Student's Name: ");
                    input = Console.ReadLine();
                    newName = input;
                    students.Add(newStudentID, newName);

                    Console.ReadLine();
                }
            } while (!Equals(newStudentID, ""));

            Console.WriteLine("\nClass Roster:");
            string sum = "";

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
                sum += student.Value;
            }

            string avg = sum / students.Count;
            Console.WriteLine("Average grade: " + avg);

        }
    }
}
