using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class BasketManager
    {
        //class'ların kullanımı 2) class'ın adında; manager, service, dal, dataaccess, controller vb. bulunabilir. Bu yapılar içlerinde operasyon tutarlar

        //naming convention:
        //Camel Case (camelCase), Pascal Case (PascalCase)
        public void Add(Product product) //Product bir veritipi gibi old. için (int gibi), bir class içerisindeki bir method'a parametre olarak verebiliriz
        {
            Console.WriteLine("Tebrikler. {0} Sepete eklendi!", product.Name);
            //Console.WriteLine("Tebrikler. Sepete eklendi : " + product.Name);
        }

        public void Add2(string productName, string description, double price, int unitInStock) 
        {
            Console.WriteLine("Tebrikler. {0} Sepete eklendi!", productName);
        }

    }
}
