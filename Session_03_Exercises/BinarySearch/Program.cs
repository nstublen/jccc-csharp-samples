using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a name.");
                string newName = Console.ReadLine();
                if (newName == "")
                {
                    break;
                }

                int result = nameList.BinarySearch(newName);
                if (result < 0)
                {
                    int index = ~result;
                    Console.WriteLine("Insert at index {0}.", index);
                    nameList.Insert(index, newName);
                }
                else
                {
                    int index = result;
                    Console.WriteLine("Found at index {0}.", index);
                }

                for (int index = 0; index < nameList.Count(); ++index)
                {
                    Console.WriteLine(index + ": " + nameList[index]);
                }
                Console.WriteLine();
            }
        }
    }
}
