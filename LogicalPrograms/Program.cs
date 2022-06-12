using System;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Program");

            int n, i, sum;
            int max, min;

            Console.WriteLine("Find the perfect number within the given range");
            Console.WriteLine("Input the starting range or number");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the ending range or number");
            max = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("The perfect numbers within the given range");
            for (n = min; n < max; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;


                }

                if (sum == n)
                    Console.WriteLine("{0} ", n);
              
            }

        }
    }
}

