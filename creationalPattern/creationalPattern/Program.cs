using System;
using System.Collections.Generic;
using creationalPattern.Structure;

namespace creationalPattern
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Book book = new Book("Author1","Title1",252);
            List<TextBook> lst = new List<TextBook>();
            lst.Add(book);
            Magazine mag = new Magazine("Author2","Title2",48,1);
            lst.Add(mag);
            foreach(TextBook temp in lst)
            {
                temp.getInfo();
            }
        }
    }
}