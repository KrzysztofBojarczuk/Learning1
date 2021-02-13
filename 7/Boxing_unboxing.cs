using System;

namespace Boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;
            Console.WriteLine(o);

            int j = (int)o;
            Console.WriteLine(j);

            Console.WriteLine(String.Concat("Hello", 123, true));

            int a = 123456;
            long b = a;
            Console.WriteLine(b);

            double c = 10.00;
            int d = (int)c;
            Console.WriteLine(d);



            Console.ReadLine();
        }
    }
}
