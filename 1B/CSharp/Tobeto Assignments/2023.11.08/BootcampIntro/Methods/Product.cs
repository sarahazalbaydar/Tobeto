using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Product
    { //class: içerisinde string, int veri tipleri gibi bilgileri barındıran(örn:Id, name, price, description) yapılardır

        public int Id { get; set; } //property: özellik
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int UnitInStock { get; set; }

    }
}
