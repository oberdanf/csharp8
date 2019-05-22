using System;

namespace CSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me your preferred language, i.e.: pt-br");
            Console.WriteLine(GetGreeting(Console.ReadLine()));
        }

        static string GetGreeting(string language) =>
            language switch
            {
                "pr-br" => "Oi!",
                "en-us" => "Hello!",
                "es-es" => "¡Hola!",
                _ => "???????????"
            };
    }
}