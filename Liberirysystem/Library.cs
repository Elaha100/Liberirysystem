using System.Collections.Generic;

namespace LibrarySystem
{
    public class Library
    {
        //Namn på bibliotek
        public string Name { get; set; } = "";
        //Adress på bibliotek
        public string Address { get; set; } = "";
        //öppetideder
        public string OpenTime { get; set; } = "";

        // Listor som håller reda på alla böcker
        public List<Book> Books { get; set; } = new();
        // Listor som håller reda på alla magasin
        public List<Magazine> Magazine { get; set; } = new();
        //Listor som håller redan på alla DVD-filmer
        public List<DVD> DVDs { get; set; } = new List<DVD>();
        //Listor som håller reda på alla kunder 
        public List<Customer> customers { get; set; } = new List<Customer> ();
        //Listor aom håller reda på alla bibliotekareier 
        public List<Librarian> librarians { get; set; } = new List<Librarian>();
 }

    }



