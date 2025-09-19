using System.Collections.Generic;

namespace LibraryStstem
{
    internal class Library
    {
        //Namn på bibliotek
        public string Name { get; set; } = "";
        //Adress på bibliotek
        public string Address { get; set; } = "";
        //öppetideder
        public string OpenTime { get; set; } = "";
        //Lista som innehåller olika "tags" eller kat
        public List<string> Tags { get; set; } = new List<string>();
        public Library() { }



    }
}



