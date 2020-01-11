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
            int[] listOfgrades = new int[3];
            Console.WriteLine("Please enter grades: ");
            for (int i = 0; i < listOfgrades.Length; i++)
            {
                Console.WriteLine("Please enter next grade: ");
                int grade = Convert.ToInt32(Console.ReadLine());
                listOfgrades[i] = grade;
            }
            Console.WriteLine("");
            foreach (var item in listOfgrades)
            {
                Console.Write(item + ", " + item);

            }
            Console.ReadLine();
        }
    }
}
