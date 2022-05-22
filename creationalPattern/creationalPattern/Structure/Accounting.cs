using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creationalPattern.Structure
{
    abstract class Accounting
    {
        public List<TextBook> storage = new List<TextBook>();
        abstract public void giveBook(TextBook lst);
        public void arrival(List<TextBook> lst)
        {
            storage.AddRange(lst);
            Console.WriteLine("----- NEW ARRIVAL -----");
            foreach (TextBook temp in lst)
            {
                temp.getInfo();
            }
        }
        public void catalog()
        {
            Console.WriteLine("\n--------- CURRENT CATALOG: --------");
            foreach (var temp in storage)
            {
                temp.getInfo();
            }
        }
    }

    class LibraryAccounting : Accounting
    {
        public override void giveBook(TextBook textBook)
        {
            if (!storage.Contains(textBook))
            {
                Console.WriteLine("\n!!! Missing textBook in the storage. Can not make the operation. !!!\n");
                return;
            }
            storage.Remove(textBook);

            int sum = textBook.Price;
            Console.WriteLine("----- NEW BORROW -----", sum);
            textBook.getInfo();
        }   

    }
    class KioskAccounting : Accounting
    {
        public override void giveBook(TextBook textBook)
        {

            if (!storage.Contains(textBook))
            {
                Console.WriteLine("\n!!! Missing textBook in the storage. Can not make the operation. !!!\n");
                return;
            }
            storage.Remove(textBook);

            int sum = textBook.Price;
            Console.WriteLine("----- NEW SALE {0} UAH-----",sum);
            textBook.getInfo();
        }
    }
}