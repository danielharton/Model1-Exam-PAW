using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pregatirepawexamsub1
{
    public  class Registration
    {
        public string CompanyName { get; set; }
        public int NoOfPasses { get; set; }
        public int AccessPackageId { get; set; }

        public Registration() { }

        public Registration(string CompanyName, int NoOfPasses, int AccessPackageId)
        {
            this.CompanyName = CompanyName;
            this.NoOfPasses = NoOfPasses;
            this.AccessPackageId = AccessPackageId;
        }
        public static explicit operator double(Registration r)
        {
            var pkg = DataStore.AccessPackages.Find(p => p.Id == r.AccessPackageId);
            return pkg != null ? r.NoOfPasses * pkg.Price : 0.0;
        }
    }
}
