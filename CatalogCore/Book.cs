using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogCore
{
    public class Book: MainElement
    {
        protected string authors { private set; get; }

        protected string illustrator { private set; get; } = "отстутствует";

        protected string publishingHouse { private set; get;}

        protected int yearOfPublication { private set; get; }

        public Book(string na, string own, string aut, string ill, string pubHouse, int yePubl) : base(na,own)
        {
            authors = aut;
            illustrator = ill;
            publishingHouse = pubHouse;
            yearOfPublication = yePubl;
        }
        public Book(string na, string own, string aut, string pubHouse, int yePubl) : base(na,own)   
        {
            authors = aut;
            publishingHouse = pubHouse;
            yearOfPublication = yePubl;
        }

        public virtual void Change(string name, string aut, string ill, string pubHouse, int yePubl)
        {
            Change(name);
            authors = aut;
            if(ill != null) { illustrator = ill; }
            publishingHouse = pubHouse;
            yearOfPublication = yePubl;
        }

        public override string ToString()
        {
            return base.ToString() + $"Name: {Name}" +
                $"\n    Owner Name: {ownerName}, Data transfer: {transferDate}" +
                $"\n    Authors: {authors},  Illustrator: {illustrator}, Publishing House: {publishingHouse}, Year Publication: {yearOfPublication}";
        }
    }
}
