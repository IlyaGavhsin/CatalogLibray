using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogCore
{
    public class MainElement
    {
        public string Name { private set;  get; }

        public string ownerName { private set; get; }

        public DateTime transferDate { private set; get; }

        public MainElement(string name, string owName)
        {
            Name = name;
            ownerName = owName;
            transferDate = DateTime.Now;
        }

        public virtual void Change(string name)
        { 
            Name = name;
        }

        public override string ToString()
        {
            return base.ToString() + $"Name: {Name}, Owner Name: {ownerName}, Data transfer: {transferDate}";
        }

    }
}
