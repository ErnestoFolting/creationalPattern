using System;
using System.Collections.Generic;

namespace creationalPattern.Structure
{
    public abstract class TextBook
    {
        public string Author;
        public string Title;
        public int Sheets;
        public int Price;
        public abstract void getInfo();
        public TextBook(string author,string title,int sheets, int price)
        {
            this.Author = author;
            this.Title = title;
            this.Sheets = sheets;
            this.Price = price;
        }
    }
    class Book : TextBook
    {
        public Book(string author, string title, int sheets, int price) : base( author,  title, sheets,price) { }
        public override void getInfo()
        {
            Console.WriteLine(" Book info: \nTitle: {0}\nAuthor: {1}\nSheets: {2}\nPrice: {3}\n",Title,Author,Sheets,Price);
        }
    }
    class Magazine : TextBook
    {
        public int Number;
        public Magazine(string author, string title, int sheets, int number, int price) : base(author, title, sheets,price) {
            this.Number = number;
        }
        public override void getInfo()
        {
            Console.WriteLine(" Magazine info: \nTitle: {0}\nNumber: {1}\nAuthor: {2}\nSheets: {3}\nPrice: {4}\n", Title, Number, Author, Sheets,Price);
        }
    }
}