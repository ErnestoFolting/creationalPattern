using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creationalPattern.Structure
{
    abstract class Place
    {
        public string CompanyName { get; set; }
        public Place(string companyName)
        {
            CompanyName = companyName;
        }
        //fabric method
        abstract public Accounting createAccounting();
    }
    //creates LibraryAccounting
    class Library : Place
    {
        public Library(string companyName) : base(companyName) { }
        public override Accounting createAccounting()
        {
            return new LibraryAccounting();
        }
    }
    class Kiosk : Place
    {
        public Kiosk(string companyName) : base(companyName) { }
        public override Accounting createAccounting()
        {
            return new KioskAccounting();
        }
    }
}
