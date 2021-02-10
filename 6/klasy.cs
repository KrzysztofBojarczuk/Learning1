using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Yellow", 2014, 4);
            Car car2 = new Car("Red", 2016, 2);
            Car car3 = new Car("BMW");
            Console.WriteLine($"{car1.Color}");
            Console.WriteLine($"{car2.Color}");
            string manufacturer = car3.GetManufacturer();
            Console.WriteLine(manufacturer);

            Console.ReadLine();
        }
    }


    public class Car
    {
        private string _manufacturer;


        public Car(string color, int year, int numbersOfDoors)
        {
            Color = color;
            Year = year;
            NumbersOfDoors = numbersOfDoors;
        }
        public Car()
        {

        }
        public Car(string manufacturer)
        {
            _manufacturer = manufacturer;
        }


        public string Color { get; set; }
        public int Year { get; set; }
        public int NumbersOfDoors { get; set; }

        public string GetManufacturer()
        {
            return _manufacturer;
        }
    }
}
