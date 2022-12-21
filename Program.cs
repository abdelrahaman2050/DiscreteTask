using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1PerfectProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" please enter the first number: ");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine(" please enter the second number: ");
            int secondnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            int sum;
            for (int x = firstnumber; firstnumber < secondnumber; firstnumber++)
            {
                sum = 0;
                for (int i = 1; i <= firstnumber / 2; i++)
                {
                    if (firstnumber % i == 0)
                    {
                        sum += i;
                    }
                }
                if (sum == firstnumber)
                {
                    Console.WriteLine(" this number is perfect number :" + firstnumber);
                }

            }
            Console.WriteLine("\n");
            Console.WriteLine("Developed by : ");
            Console.WriteLine("Abdelahman Elshrabasi\nYousif Emad\nBasant Omar");
            Console.ReadKey();
        }
    }
}
