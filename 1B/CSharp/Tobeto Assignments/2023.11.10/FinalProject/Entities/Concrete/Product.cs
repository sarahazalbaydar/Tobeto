using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        //public class Product -> public demek bu class'a diğer katmanların da ulaşımını sağlar

        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; } //int'in küçüğü short(sql'deki smallint gibi)
        public decimal UnitPrice { get; set; }
    }
}
