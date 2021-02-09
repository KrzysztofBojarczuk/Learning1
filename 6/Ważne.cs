using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer greater than 0: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                if (i == number)
                {
                    Console.Write(i + "\n");

                }
                else
                {
                    Console.Write(i + ", ");
                }
                sum += i;
                    
            }
            Console.WriteLine($"The sum of all numbers is: {sum}");
           
        }
    }
}
