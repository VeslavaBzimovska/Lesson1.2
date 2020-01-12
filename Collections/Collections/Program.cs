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
            UserInput(listOfGrades);
            Console.WriteLine("");
            ShowGrades(listOfGrades);
            Console.ReadLine();
            decimal average = AverageGrade(listOfGrades);
            Console.WriteLine(average);
            Console.ReadLine();


        }
        private static void UserInput(int[] listOfGrades)
        {
            Console.WriteLine("Please enter grades: ");
            for (int i = 0; i < listOfGrades.Length; i++)
            {
                Console.WriteLine("Please enter next grade: ");
                int grade = Convert.ToInt32(Console.ReadLine());
                listOfGrades[i] = grade;
            }
        }
        private static void ShowGrades(int[] listOfGrades)
        {
            for (int i = 0; i < listOfGrades.Length; i++)
            {
                if (i == listOfGrades.Length - 1)
                {
                    Console.Write(listOfGrades[i]);
                }
                else
                {
                    Console.Write(listOfGrades[i] + ", ");

                }
            }
        }
        private static decimal AverageGrade(int[] listOfGrades)
        {
            decimal sum = 0;
            decimal average = 0;
            for (int i = 0; i < listOfGrades.Length; i++)
            {
                sum = sum + listOfGrades[i];
            }
            average = sum / Convert.ToDecimal(listOfGrades.Length);
            average = Math.Round(average, 2);
            return average;
        }
    }
}
