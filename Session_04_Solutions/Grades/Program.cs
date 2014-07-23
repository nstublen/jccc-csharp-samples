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
            List<int> mGrades = new List<int>();

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
                    mGrades.Add(grade);
                }
                catch
                {

                }
            }

            // Drop the lowest grade.
            mGrades.Sort();
            Console.WriteLine(String.Format("Drop grade: {0}", mGrades[0]));
            mGrades.RemoveAt(0);

            // Print the average.
            double sum = 0;
            foreach (int grade in mGrades)
            {
                sum += grade;
            }
            double average = sum / mGrades.Count;
            Console.WriteLine(String.Format("Average: {0}", average));
        }
    }
}
