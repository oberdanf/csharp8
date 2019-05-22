using System;

namespace CSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator = new Calculator();
            calculator.FirstNumber = 1;
            calculator.SecondNumber = 2;
            Console.WriteLine(calculator.Sum());
            Console.ReadLine();
        }
    }
}
