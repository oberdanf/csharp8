using System;

namespace CSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            using var fileReader = new System.IO.StreamReader("test.txt");

            using (var fileWriter = new System.IO.StreamWriter("test.txt"))
            {
                fileWriter.Write("oi");
                //File writer is disposed here
            }
            
            var text = fileReader.ReadToEnd();
            Console.WriteLine(text);
            Console.ReadLine();

        //file reader is disposed here
        }
    }
}
