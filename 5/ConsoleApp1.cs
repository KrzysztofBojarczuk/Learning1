using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to act as console");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the seconf number: ");
            int y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine($"{x} is greater than {y}");
            }
            else if (x == y)
            {
                Console.WriteLine($"{x} is equal to {y}");
            }
            else
            {
                Console.WriteLine($"{x} is than less than {y}");
            }

            Console.ReadLine();
        }
    }
}
