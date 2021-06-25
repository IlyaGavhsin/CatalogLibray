using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogCore
{
    class Puzzle: MainElement
    {

        protected string countElements { private set; get; }

        protected string company { private set; get; }

        public Puzzle(string na, string own, string coEl, string com) : base(na, own)
        {
            countElements = coEl;
            company = com;
        }
        public virtual void Change(string name, string coEl, string com)
        {
            Change(name);
            countElements = coEl;
            company = com;
        }

        public override string ToString()
        {
            return base.ToString() + $"Name: {Name}" +
                $"\n    Owner Name: {ownerName}, Data transfer: {transferDate}" +
                $"\n    Count of puzzle: {countElements}, Company: {company}";
        }
    }
}
