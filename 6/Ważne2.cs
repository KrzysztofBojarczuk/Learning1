using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 10 numbers! ");
            int sum = 0;
            double avg = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Number {i}: ");
                int number = int.Parse(Console.ReadLine());
                sum = sum + number;
            }
            avg = sum / 10.0;
            Console.WriteLine($"The sume of your provided number is: {sum}");
            Console.WriteLine($"The average of oyur provided numbers is: {avg}");
           
           
        }
    }
}
