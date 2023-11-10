using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //snippet: hazır kodlar
    class Product       //bu tip class'larda sadece property olur
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }  //kod okunurluğu için FK'lar PK altına yazılır (SQL)
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //CRUD operasyonları: create, read, update, delete



    }
}
