using System;
using System.Collections.Generic;

namespace creationalPattern.Structure
{
    abstract class TextBook
    {
        public string Author;
        public string Title;
        public int Sheets;
        public abstract void getInfo();
        public TextBook(string author,string title,int sheets)
        {
            this.Author = author;
            this.Title = title;
            this.Sheets = sheets;
        }
    }
    class Book : TextBook
    {
        public Book(string author, string title, int sheets) : base( author,  title, sheets) { }
        public override void getInfo()
        {
            Console.WriteLine("---Book info: \nTitle: {0}\nAuthor: {1}\nSheets: {2}\n",Title,Author,Sheets);
        }
    }
    class Magazine : TextBook
    {
        public int Number;
        public Magazine(string author, string title, int sheets, int number) : base(author, title, sheets) {
            this.Number = number;
        }
        public override void getInfo()
        {
            Console.WriteLine("---Magazine info: \nTitle: {0}\nNumber: {1}\nAuthor: {2}\nSheets: {3}\n", Title, Number, Author, Sheets);
        }
    }
}