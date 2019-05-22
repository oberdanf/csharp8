using System;

namespace CSharp8
{
    class Program
    {
        
        static string test = null;

        static void Main(string[] args)
        {
            if(test.Length > 0)
            {
                Console.WriteLine($"{test.Length} characters");
            }
        }
    }
}
