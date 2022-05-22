using System;
using System.Collections.Generic;
using creationalPattern.Structure;

namespace creationalPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create 3 books and 2 magazines
            TextBook book1 = new Book("Author1","Title1",250,150);
            TextBook book2 = new Book("Author2","Title2",150,100);
            TextBook book3 = new Book("Author3","Title3",350,250);

            TextBook magazine1 = new Magazine("Author1","Title1",50,1,100);
            TextBook magazine2 = new Magazine("Author2","Title2",30,2,80);
            TextBook magazine3 = new Magazine("Author3","Title3",20,3,70);

            List<TextBook> lst = new List<TextBook>() { book1, book2, book3, magazine1, magazine2 };

            Console.WriteLine("----------Work with Library----------");

            //Create accounting creator for Libraries
            Place place = new Library("Ababagalamaga");

            //Create abstract accounting with creator
            Accounting library1 = place.createAccounting();

            //Make an arrival to our place
            library1.arrival(lst);

            //Output the current catalog
            library1.catalog();

            //Give a book and magazine to a person 
            library1.giveBook(book1);
            library1.giveBook(magazine2);

            //Output the current catalog
            library1.catalog();

            Console.WriteLine("----------Work with Kiosk----------");

            //Accounting creator for Kiosks
            place = new Kiosk("TviyDim");

            //Create abstract accounting with creator
            Accounting kiosk1 = place.createAccounting();

            //Make an arrival to our place
            kiosk1.arrival(lst);

            //Output the current catalog
            kiosk1.catalog();

            //Give a book and magazine to a person 
            kiosk1.giveBook(book1);
            kiosk1.giveBook(magazine2);

            //Output the current catalog
            kiosk1.catalog();

            //Try to give the book that is not in storage
            kiosk1.giveBook(magazine3);
        }
    }
}