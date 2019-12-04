using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo FizzBuzz");
            Console.WriteLine("");

            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(FizzBuzzer.FizzBuzzer.GetValue(i));
            }

            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
