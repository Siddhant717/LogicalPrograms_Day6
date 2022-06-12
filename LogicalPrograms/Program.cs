using System;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Program");

            Console.WriteLine("Enter a number :");



            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }


            if (count == 2)
            {
                Console.WriteLine("It is a Prime Number");
            }
            else
            {
                Console.WriteLine("It is not a Prime Number");
            }



        }
    }
}

