using System;

namespace FibonacciUser
{
    class Program
    {
        public static int Fibonacci(int numbers)
        {
            int a = 0;
            int b = 1;


            for (int i = 0; i < numbers; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with Fibonacci numbers!!");
            Console.WriteLine("How many numbers do you want?");
            int fibonacci = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < fibonacci; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
            Console.ReadKey();
        }
    }
}
