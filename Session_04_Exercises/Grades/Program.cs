using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            // Storage for the ten grades.

            // Ask for ten grades.
            int grades = 0;
            while (grades < 10)
            {
                System.Console.Write(String.Format("Enter grade #{0}.\r\n>", grades + 1));
                try
                {
                    int grade = int.Parse(System.Console.ReadLine());
                    grades++;

                    // Remember the new grade.
                }
                catch
                {

                }
            }

            // Drop the lowest grade.

            // Print the average.
            double average = 0;
            Console.WriteLine(String.Format("Average: {0}", average));
        }
    }
}
