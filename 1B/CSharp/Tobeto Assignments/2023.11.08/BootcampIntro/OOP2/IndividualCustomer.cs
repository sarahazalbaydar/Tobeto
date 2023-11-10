using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //individual - bireysel(gerçek) : Hazal
    //class IndividualCustomer:Customer -> inheritance: miras -> müşteride olan özellikler gerçek müşteride de vardır
    //gerçek müşteri bir müşteridir
    class IndividualCustomer :Customer        //entity; entity içerisinde operasyon olmaz
    {
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
