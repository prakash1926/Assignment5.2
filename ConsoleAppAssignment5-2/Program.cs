using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First 10 natural Numbers :");
            for (int i = 1; i <= 10; i++)
            {
                
                Console.WriteLine(i);
            }
           

            //first 10 even numbers:

            int Num = 1;
            Console.WriteLine("\nFirst even natural numbers");
            while(Num<=20)
            {
                if(Num % 2 == 0)
                {
                    Console.WriteLine(Num);
                   
                }
                Num++;

            }
           
           

            //first 10 odd numbers:
            int OddNum = 1;
            Console.WriteLine("\nFirst even natural numbers");
            while (OddNum <= 20)
            {
                if (OddNum % 2 != 0)
                {
                    Console.WriteLine(OddNum);

                }
                OddNum++;

            }
            Console.ReadKey();

        }
    }
}
