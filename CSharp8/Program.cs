using System;
using System.Threading.Tasks;

namespace CSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteNumber();
            Console.ReadLine();
        }

        private static async void WriteNumber()
        {
            await foreach (var number in GenerateSequence())
            {
                Console.WriteLine(number);
            }
           
        }

        public static async System.Collections.Generic.IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }
    }

}
