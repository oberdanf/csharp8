using System;

namespace CSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point();
            point.X = 10;
            point.Y = 20;
            System.Console.WriteLine(point.ToString());
        }
    }
}
