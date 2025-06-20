using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pregatirepawexamsub1
{
    public class AccessPackage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public AccessPackage(int Id, string Name, double Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
        }
        public override string ToString() => Name;
    }
}
