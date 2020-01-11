using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listOfGrades = new int[3];
            Console.WriteLine("Please enter grades: ");
            for (int i = 0; i < listOfGrades.Length; i++)
            {
                Console.WriteLine("Please enter next grade: ");
                int grade = Convert.ToInt32(Console.ReadLine());
                listOfGrades[i] = grade;
            }
            Console.WriteLine("");
            for (int i = 0; i < listOfGrades.Length; i++)
            {
                if (i==listOfGrades.Length -1)
                {
                    Console.Write(listOfGrades[i]);
                }
                else
                {
                    Console.Write(listOfGrades[i] + ", ");

                }
            }
            Console.ReadLine();





        }
    }
}
