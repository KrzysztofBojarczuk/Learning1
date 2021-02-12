using System;

namespace dttddttdgdfdg
{
    class Program
    {


        // 0000001
        static void Main(string[] args)
        {
            byte myByte = 1;
            Byte myByte2 = 2;

            short myShort = 3;
            Int16 myShort2 = 5;

            int myInt = 6;
            Int32 myInt2 = 7;

            long myLong = 8;
            Int64 myLong2 = 9;

            decimal myDecimal = 3.14M;
            float myFloat = 1.12f;
            double myDouble = 9.876;
            
            Console.WriteLine("byte max: " + byte.MaxValue);
            Console.WriteLine("Short max: " + short.MaxValue);
            Console.WriteLine("int max: " + int.MaxValue);
            Console.WriteLine("long max: " + long.MaxValue);
            Console.WriteLine();
            Console.WriteLine("decimal max: " + decimal.MaxValue);
            Console.WriteLine("float max: " + float.MaxValue);
            Console.WriteLine("double max: " + double.MaxValue);
        }
    }
}
