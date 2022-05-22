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
        abstract public void giveBooks(List<TextBook> lst);
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
        public override void giveBooks(List<TextBook> lst)
        {
            foreach (var temp in lst)
            {
                if (!storage.Contains(temp))
                {
                    Console.WriteLine("\n!!! Missing textBook in the storage. Can not make the operation. !!!\n");
                    return;
                }
            }
            storage = storage.Where(item => lst.Contains(item) == false).ToList();

            Console.WriteLine("----- NEW BORROW -----");
            foreach (TextBook temp in lst)
            {
                temp.getInfo();
            }
        }   

    }
    class KioskAccounting : Accounting
    {
        public override void giveBooks(List<TextBook> lst)
        {
            foreach(var temp in lst)
            {
                if (!storage.Contains(temp))
                {
                    Console.WriteLine("\n!!! Missing textBook in the storage. Can not make the operation. !!!\n");
                    return;
                }
            }
            storage = storage.Where(item => lst.Contains(item) == false).ToList();

            int sum = lst.Sum(item => item.Price);
            Console.WriteLine("----- NEW SALE {0} UAH-----",sum);
            foreach (TextBook temp in lst)
            {
                temp.getInfo();
            }
        }
    }
}