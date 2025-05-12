using System;
namespace SimpleApp
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine($"3 + 5 = {calc.Add(3, 5)}");
        }
    }
}