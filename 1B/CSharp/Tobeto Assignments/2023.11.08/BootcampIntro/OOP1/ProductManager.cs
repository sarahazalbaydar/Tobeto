using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        //operasyonları içeren(örn: CRUD op.'ları) class'ları isimlendirirken genellikle Manager veya service kullanılır
        public void Add(Product product) //like string name
        {
            Console.WriteLine("Ürün eklendi: {0}", product.ProductName);

            //product.ProductName = "Kamera";
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

    }
}
