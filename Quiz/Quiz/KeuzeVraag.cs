using System;
using System.Collections.Generic;

namespace Quiz
{
    public class KeuzeVraag : Vraag
    {
        private List<string> keuzes;

        public KeuzeVraag()
        {
            keuzes = new List<string>();
        }

        public void addKeuze(string keuze, bool correct)
        {
            keuzes.Add(keuze);
            if (correct)
            {
                string keuzeString = "" + keuzes.Count;
                antwoord = keuzeString;
            }
        }

        public void Display()
        {
            Console.WriteLine(tekst);

            for (int i = 0; i < keuzes.Count; i++)
            {
                int keuzeNummer = i + 1;
                Console.WriteLine(keuzeNummer + ": " + keuzes[i]);
            }
        }
    }
}