using System;

namespace LibrarySystem
{
    public class Customer
    { //kundens namn
        public string Name { get; set; } = "";   
        //public ID för användaren
        public int UserId { get; set; } 
        //Emailadress
        public string Email { get; set; } = "";
        //Låna något (Book, DVD, Magazine)
        public void Borrow (string itemTitel)
        {
            Console.WriteLine ($"{Name} borrowed: ({itemTitel})");
        }
        //lämna tillbaka
        public void Return(string itemTitel)
        {
            Console.WriteLine ($"{Name} Returned: {itemTitel}");
        }
        //Reservad något
        public void Reserve(string itemTitel)
        {
            Console.WriteLine ($"{Name} Reserved: ({itemTitel})");
        }
    }
}
