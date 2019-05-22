using System;

namespace CSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Choose one of the following:
            switch
            property
            tuple");
            var option = Console.ReadLine();
            var outcome = RunChosenOption(option);

            string RunChosenOption(string option) =>
            option switch
            {
                "switch" => RunSwitchExpressions(),
                "property" => RunPropertyPatterns(),
                "tuple" => RunTuplePatterns(),
                _ => $"{option} is invalid."
            };

            Console.WriteLine(outcome);
        }

        static string RunSwitchExpressions()
        {
            Console.WriteLine("Tell me your preferred language, i.e.: pt-br");
            string choice = Console.ReadLine();
            return GetGreeting(choice);
        }

        static string GetGreeting(string language) =>
        language switch
        {
            "pt-br" => "Oi!",
            "en-us" => "Hello!",
            "es-es" => "¡Hola!",
            _ => "👋"
        };

        static string RunPropertyPatterns()
        {
            Console.WriteLine("Tell me a currency you want to convert R$ to:");
            var currency = Currency.FromName(Console.ReadLine());
            Console.WriteLine("Tell me the amount");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            return ConvertBrlTo(currency, amount);
        }

        public static string ConvertBrlTo(Currency currency, decimal amount) =>
        currency switch
        {
            { Name: "Dollar", Sign: var sign } => $"The R${amount} in dollars is {sign}{(0.247856m * amount)}",
            { Name: "Euro", Sign: var sign } => $"The R${amount} in euros is {sign}{(0.22183m * amount)}",
            { Name: "Pound", Sign: var sign } => $"The R${amount} in pound sterling is {sign}{(0.19533m * amount)}",
            _ => amount.ToString()
        };

        static string RunTuplePatterns()
        {
            Console.WriteLine("Let's play rock, paper, scissors");
            Console.WriteLine("Select one of 👊, ✋, ✌️");
            var firstChoice = Console.ReadLine();
            Console.WriteLine("Select one of 👊, ✋, ✌️");
            var secondChoice = Console.ReadLine();
            return RockPaperScissors(firstChoice, secondChoice);
        }

        public static string RockPaperScissors(string first, string second)
    => (first, second) switch
    {
        ("👊", "✋") => "rock is covered by paper. Paper wins.",
        ("👊", "✌️") => "rock breaks scissors. Rock wins.",
        ("✋", "👊") => "paper covers rock. Paper wins.",
        ("✋", "✌️") => "️paper is cut by scissors. Scissors wins.",
        ("✌️", "👊") => "scissors is broken by rock. Rock wins.",
        ("✌️", "✋") => "scissors cuts paper. Scissors wins.",
        (_, _) => "tie"
    };
    }

    class Currency
    {
        public Currency(string name, string sign) => (Name, Sign) = (name, sign);
        
        public string Name { get; }
        public string Sign { get; }

        public static Currency FromName(string name) =>
        name switch
        {
            "pound" => new Currency("Pound", "£"),
            "dollar" => new Currency("Dollar", "$"),
            "euro" => new Currency("Euro", "€"),
            _ => new Currency("?", "?"),
        };
    }
}