using System;

namespace LibrarySystem
{
    public class Loan
    {
        //Unikt ID för lån
        public int LoanId { get; set; }
        //Vem lånade (kopplat till kund)
        public string CustomerName { get; set; } = "";
        //vilket objekt
        public string ItemTitel { get; set; } = "";
        //Datum när lånaden stratade
        public DateTime  LoanDate { get; set; }
        //Datum när lånet lämnas tillbaka
        public DateTime DueDate { get; set; }
        //Markera att lånet är tillbaka
        public void ReturnItem()
        {
            Console.WriteLine($"{ItemTitel} has been returned by {CustomerName}.");
        }
    }
}
