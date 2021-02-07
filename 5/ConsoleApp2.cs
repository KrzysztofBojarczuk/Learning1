using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You will be asked to provide 3 numbers ");
            Console.WriteLine("Please enter 1st number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the 2nd number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the 3rd number: ");
            int k = int.Parse(Console.ReadLine());

            if(x > y)
            {
                if  (x > k)
                {
                    Console.WriteLine($"The largest number is: {x}");
                }
                else
                {
                    Console.WriteLine($"The largest numbers is: {k}");
                }
            }
            else if (y > k)
            {
                Console.WriteLine($"The largest number is: {y}");
            }
            else
            {
                Console.WriteLine($"The largest number is: {k}");
            }
            
           
            Console.ReadLine();
        }
    }
}
