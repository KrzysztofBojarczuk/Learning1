using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your courrent temeprature in centigrade: ");
            int x = int.Parse(Console.ReadLine());

            if (x <= 0)
                Console.WriteLine("Freezing weather");
            else if (x > 0 && x <= 10)
                Console.WriteLine("Very Cold weather");
            else if (x > 10 && x <= 20)
                Console.WriteLine("Cold weather");
            else if (x > 20 && x <= 30)
                Console.WriteLine("Normal temperature");
            else if (x > 30 && x <= 40)
                Console.WriteLine("Hot weather");
            else if (x > 40)
                Console.WriteLine("Very hot weather");

            Console.ReadLine();
        }
    }
}
