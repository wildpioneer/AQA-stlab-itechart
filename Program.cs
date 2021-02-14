using System;

namespace DotNetBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool boolVar = false;
            byte byteVar = 255;
            sbyte sbyteVar = 127;
            short shortVar = -3;
            ushort ushortVar = 65535;
            float floatVar = 13.3f;
            double doubleVar = 123.2d;
            char charVar = 'a';
            decimal decimalVar = -123.2M;
            int intVar = 4;
            uint uintVar = 4;
            long longVar = -1;
            ulong ulongVar = 1;
            object objectVar = null;
            string stringVar = "itechart";
            dynamic dynamicVar = "anything";
            OperatorsAction();
        }

        private static void OperatorsAction()
        {
            int a, b;
            object o = null;
            bool f;
            a = 1;
            b = 2;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(++a);
            Console.WriteLine(b / a);
            Console.WriteLine(b % a);
            Console.WriteLine(a * b);
            Console.WriteLine(b--);
            
            f = (a == 2 && b != 2) ? true: false;
            Console.WriteLine(f);
            f = (a == 0 || b != 2) ? true: false;
            Console.WriteLine(f);
            f = (a == 2 ^ b != 2) ? true: false;
            Console.WriteLine(f);
            f = (a == 2 & b != 2) ? true: false;
            Console.WriteLine(f);
            f = (a == 2 | b != 2) ? true: false;
            Console.WriteLine(f);
            
            Console.WriteLine(b<<a);
            Console.WriteLine(a>>b);
            
            Console.WriteLine(a>b);
            Console.WriteLine(a<=b);
            Console.WriteLine(a is int);
            string c = o as string;
            Console.WriteLine(c + "empty string");
        }
    }
}