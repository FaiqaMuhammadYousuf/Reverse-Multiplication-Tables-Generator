using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\r");
            Console.WriteLine("Enter the first number for the table:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Table starts from: " + firstNumber);
            Console.WriteLine("==========================");
            Console.WriteLine("\r");

            Console.WriteLine("Enter the last number for the table:");
            int lastNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Table ends at: " + lastNumber);
            Console.WriteLine("==========================");
            Console.WriteLine("\r");

            Console.WriteLine("Enter the limit start from:");
            int S_limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Limit starts from: " + S_limit);
            Console.WriteLine("==========================");
            Console.WriteLine("\r");

            Console.WriteLine("Enter the limit end:");
            int E_limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Limit ends at: " + E_limit);
            Console.WriteLine("==========================");
            Console.WriteLine("\r");

            for (int i = firstNumber; i >= lastNumber; i--)
            {
                for (int j = S_limit; j >= E_limit; j--)
                {
                    Console.WriteLine(i + " x " + j + " = " + i * j);
                }
                Console.WriteLine("==========================");
                Console.WriteLine("\r");
            }

            Console.ReadKey();
        }
    }
}
    
