using System;
using System.Collections.Generic;
using creationalPattern.Structure;

namespace creationalPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TextBook> lst = new List<TextBook>();
            Book book = new Book("Author1","Title1",252,153);
            Magazine mag = new Magazine("Author2", "Title2", 48, 1,38);
            Magazine mag2 = new Magazine("Author3", "Title3", 51, 2,52);
            Place place = new Library("Malyatko");
            Place place2 = new Kiosk("Malyatko");
            Accounting library = place.createAccounting();
            lst.Add(book);
            lst.Add(mag);
            library.arrival(lst);
            library.giveBooks(lst);
            Accounting kiosk = place2.createAccounting();
            kiosk.arrival(lst);
            kiosk.giveBooks(lst);
            Console.WriteLine("check");
            kiosk.catalog();
            
        }
    }
}