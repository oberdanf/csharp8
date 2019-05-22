using System;

namespace CSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DoSum());    
        }

        static int DoSum()
        {   
            var x = 1;
            var y = 2;

            return Add(x,y);


            static int Add(int first, int second) => first + second;
        }

        
    }
}
