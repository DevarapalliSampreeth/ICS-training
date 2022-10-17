using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class program
    {
        public static void Main(string[] args)
        {
            int Total;
            int Sum = 0;
            int Value;
            float Average;
            Console.WriteLine("enter total count of matches : ");
            Total = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Total; i++)
            {
                Console.WriteLine("enter score: ");
                Value = Convert.ToInt32(Console.ReadLine());
                Sum += Value;
            }
            Average = (float)Sum / Total;
            Console.WriteLine("Sum: " + Sum + ", Average: " + Average);
        }
    }
}