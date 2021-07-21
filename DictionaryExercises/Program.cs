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
            Dictionary<string, string> students = new Dictionary<string, string>();
            string newStudentID;
            string newName;

            Console.WriteLine("Enter your students ID number (or ENTER to finish):");

            ///////MY CONTENT:///////
            do
            {
                Console.WriteLine("Student ID Number: ");
                string input = Console.ReadLine();
                newStudentID = input;

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
            //string sum = "";

            foreach (KeyValuePair<string, string> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
                //sum += student.Value;
            }

            //string avg = sum / students.Count;
            //Console.WriteLine("Average grade: " + avg);

            ///////MY CONTENT:///////

        }
    }
}
