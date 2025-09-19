using System;

namespace LibrarySystem
{
    internal class Book
    {
        //författarens namn
        public string Author { get; set; } = "";
        //Unik ID för boken
        public string Title { get; set; } = "";
        //Genre (t.ex. roman, fakta)
        public string Genre { get; set; } = "";
        //Antal sidor
        public int Pages { get; set; }
        //Titel på boken
        public string Titel { get; set; } = "";
        //Är boken tillgänlig
        public bool Avaible { get; set; } = true;
        //Metod: läsa en bok
        public void Read()
        {
            Console.WriteLine($"You are reading {Titel} by {Author}.");
        }
    }
}
