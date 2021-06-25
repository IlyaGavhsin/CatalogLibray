using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogCore
{
    class DesktopGame: MainElement
    {
        protected string developer { private set; get; }

        protected string description { private set; get; }

        protected (int, int) countGamers { private set; get; }

        public DesktopGame(string na, string own, string dev, string descr, int minGamer, int maxGamer) : base(na, own)
        {
            developer = dev;
            description = descr;
            countGamers = (minGamer, maxGamer);
        }
        public virtual void Change(string na, string dev, string descr, int minGamer, int maxGamer)
        {
            Change(na);
            developer = dev;
            description = descr;
            countGamers = (minGamer, maxGamer);
        }

        public override string ToString()
        {
            return base.ToString() + $"Name: {Name}" +
                $"\n    Owner Name: {ownerName}, Data transfer: {transferDate}" +
                $"\n    Developer: {developer}, Description: {description}, Min-Max Gamers: {countGamers.Item1} - {countGamers.Item2}";
        }
    }
}
