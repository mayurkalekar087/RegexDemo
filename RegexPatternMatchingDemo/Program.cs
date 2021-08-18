using System;

namespace RegexPatternMatchingDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Patterns patterns = new Patterns();
            Console.WriteLine(patterns.validatePinCode("443001"));
        }
    }
}