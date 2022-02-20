using System;

namespace Tutlane
{
    class Airthmetic
    {
        static void Main(string[] args)
        {
            int result;
            int x = 20, y = 10;
            result = (x + y);
            Console.WriteLine("Addition Operator: " + result);
            result = (x - y);
            Console.WriteLine("Subtraction Operator: " + result);
            result = (x * y);
            Console.WriteLine("Multiplication Operator: "+ result);
            result = (x / y);
            Console.WriteLine("Division Operator: " + result);
            result = (x % y);
            Console.WriteLine("Modulo Operator: " + result);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}