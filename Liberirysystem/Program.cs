using System;

namespace LibrarySystem;

public class Program
{
    static void Main(string[] args)
    {
        // Skapar ett nytt bibliotek
        Library myLibrary = new Library
        {
            Name = "Stadsbiblioteket",
            Address = "Storgatan 1",
            OpenTime = "08:00 - 18:00"
        };

        // Skriver ut info
        Console.WriteLine("Bibliotek: " + myLibrary.Name);
        Console.WriteLine("Adress: " + myLibrary.Address);
        Console.WriteLine("Öppettider: " + myLibrary.OpenTime);

        Console.WriteLine("\nTryck på en knapp för att avsluta...");
        Console.ReadKey();
    }
}