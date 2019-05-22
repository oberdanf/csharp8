using System;

namespace CSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var statement = Console.ReadLine();
            var words = statement.Split(' ');
            while(words.Length < 2)
            {
                Console.Write("Please type more than 2 words");
                statement = Console.ReadLine();
                words = statement.Split(' ');
            }
            Console.WriteLine($"The last word is {words[^1]}");
            Console.WriteLine($"The prior to last word is {words[^2]}"); 
            // When using ranges the last one is not included
            Console.WriteLine($"The first two words are {string.Join(',',words[..2])}");
            Range lastTwo = ^2..^0;
            Console.WriteLine($"The last two words are {string.Join(',',words[lastTwo])}");

            double middle = words.Length/2;
            if(words.Length % 2 == 0)
            {
                var first = (int)middle -1;
                var last = (int)middle;                
                Range middleWords = first..(last+1);
                Console.WriteLine($"The middle words are {string.Join(',',words[middleWords])}");
            } else {
                Console.WriteLine($"The middle word is {string.Join(',',words[(int)middle])}");
            }

        }
    }
}
