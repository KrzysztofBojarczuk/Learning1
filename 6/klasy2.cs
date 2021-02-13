using System;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal myAnimal = new Animal();
            myAnimal.Name = "Bob";
            myAnimal.Age = 5;

            myAnimal.Breath();

            Animal myAnimal2 = new Animal();
            myAnimal2.Name = "Jennifer";
            myAnimal2.Age = 27;

            myAnimal2.Breath();

            Console.WriteLine(myAnimal.Name);
            Console.WriteLine(myAnimal2.Name);

        }
    }
    class Animal
    {
        public string Name;
        public int Age; 

        public void Breath()
        {

        }
    }
}
