using System;

    namespace LibrarySystem
{
    //Klassen Magazine represenrerar en tidning 
    public class Magazine
    {
        //utgivare
        public string Publisher { get; set; } = "";
        //unik Id 
        public int Id { get; set; }
        //Titel på tidningen
        public string Titel { get; set; } = "";
        //Bläddra i tidingen
        public void Browse()
        {
            Console.WriteLine($"Browsing magazine: {Titel}");
        }
        //läsa tidningen
        public void Read()
        {
            Console.WriteLine($"Reading magazine: {Titel}");
        }
    }
}