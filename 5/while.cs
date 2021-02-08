using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer greater than 0: ");
            int number = int.Parse(Console.ReadLine());
            int counter = 1;
            
            while (counter <= number)
            {
                Console.WriteLine(counter);
                counter++;
            }

           Console.ReadLine();
        }
    }
}
