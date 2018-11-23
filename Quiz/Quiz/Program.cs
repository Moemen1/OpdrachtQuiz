using System;

namespace Quiz
{

    public class KeuzeVraag : Vraag
    {

    }

    public class Vraag
    {
        public string tekst { get; set; }
        public string antwoord { get; set; }

        public bool CheckAntwoord(string correctAntwoord)
        {
            return correctAntwoord.Equals(antwoord);
        }

        public void Display()
        {
            Console.WriteLine(tekst);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
