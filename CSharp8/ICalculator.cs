using System;

namespace CSharp8
{
    public interface ICalculator
    {
        int FirstNumber { get; set; }
        int SecondNumber { get; set; }

        int Sum()
        {
            return FirstNumber + SecondNumber;
        }
    }
}