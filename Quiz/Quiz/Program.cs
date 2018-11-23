using System;
using System.Transactions;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {

            var v1 = new KeuzeVraag();
            v1.tekst = "Hoe heet ik?";
            v1.addKeuze("Moemen", true);
            v1.addKeuze("Amro", false);
            v1.CheckAntwoord("Moemen");

            v1.Display();
            Console.Write("Jouw antwoord: ");
            string response = Console.ReadLine();

            Console.WriteLine(v1.CheckAntwoord(response));
        
            Console.ReadKey();

            

            Console.WriteLine("Hello World!");
        }
    }
}
