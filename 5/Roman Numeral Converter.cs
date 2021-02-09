using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe arabską:");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("Liczba rzymska to: I");
                    break;
                case 2:
                    Console.WriteLine("Liczba rzymska to: II");
                    break;
                case 3:
                    Console.WriteLine("Liczba rzymska to: III");
                    break;
                case 4:
                    Console.WriteLine("Liczba rzymska to: IV");
                    break;
                case 5:
                    Console.WriteLine("Liczba rzymska to: V");
                    break;
                case 6:
                    Console.WriteLine("Liczba rzymska to: VI");
                    break;
                case 7:
                    Console.WriteLine("Liczba rzymska to: VII");
                    break;
                case 8:
                    Console.WriteLine("Liczba rzymska to: VIII");
                    break;
                case 9:
                    Console.WriteLine("Liczba rzymska to: IX");
                    break;
                case 10:
                    Console.WriteLine("Liczba rzymska to: X");
                    break;

            }
        }
    }
}

