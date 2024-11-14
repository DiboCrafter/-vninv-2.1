using System;
namespace övning2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej! Vilken är din favorite bok?");
            string x = Console.ReadLine();
            Console.WriteLine("okej så din favorite bok är" + " " + x + " " + "jag gillar den också.");
        }
    }
}