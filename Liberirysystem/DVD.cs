using System;

namespace LibrarySystem
{
    internal class DVD
    {
        //Titel på DVD:n
        public string Titel { get; set; } = "";
        //Unik ID
        public int Id { get; set; }
        //spela DVD
        public void Play()
        {
            Console.WriteLine($"Playing DVD: {Titel}");
        }
        //Pausa DVD
        public void Pausa()
        {
            Console.WriteLine($"Pausa DVD {Titel}");
        }
    }
}
