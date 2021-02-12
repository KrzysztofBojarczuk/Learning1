using System;

namespace RefAndValues
{
    class Program
    {
        static void Main(string[] args)
        {
            IntContainer first = new IntContainer();
            first.i = 5;
            IntContainer second = first;
            second.i = 10;

            IntContainerClass firstClass = new IntContainerClass();
            firstClass.i = 5;

            IntContainerClass secondClass = firstClass;
            secondClass.i = 10;


            Console.WriteLine(first.i);
            Console.WriteLine(second.i);
            Console.WriteLine(firstClass.i);
            Console.WriteLine(secondClass.i);
            Console.ReadLine();
        }
    }
    struct IntContainer
    {
        public int i;
    }
    class IntContainerClass
    {
        public int i { get; set; }
    }
}
