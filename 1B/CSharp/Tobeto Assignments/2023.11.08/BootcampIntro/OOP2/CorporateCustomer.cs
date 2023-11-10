using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //corporate - tüzel, kurumsal: discord
    //class class CorporateCustomer : Customer -> inheritance: miras -> müşteride olan özellikler tüzel müşteride de vardır
    //tüzel müşteri bir müşteridir
    class CorporateCustomer : Customer             //entity; entity içerisinde operasyon olmaz
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
