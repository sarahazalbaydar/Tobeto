// class'lar yapılan işlemleri gruplara ayırmak, bu grup üzerinden işlemleri yapmak ve bu gruba rahat bir şekilde ulaşmak için method'lar ile kullanılabilir
// class'lar property adı verilen özellikleri tutabilirler

using System.Runtime.CompilerServices;

CustomerManager customerManager = new CustomerManager();
//bir class'ı kullanabilmek için class'ın bir örneğini/referansını oluşturmak gerekir
//büyük küçük harf önemlidir
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

Customer customer = new Customer();
customer.City = "Aydın";                  //class'taki property'yi yazıp = dediğimizde set bloğu çalışır
customer.Id = 1;
customer.FirstName = "Şara Hazal";
customer.LastName = "Baydar";

Customer customer2 = new Customer
{   //ctrl + space ile class içerisindeki property'ler önümüze listelenir
    Id = 2,
    FirstName = "Engin",
    LastName = "Demiroğ",
    City = "İstanbul"
};

Console.WriteLine(customer2.FirstName);     //burada ise bana customer2'nin FirstName'ini al yani get bloğu çalışır
