using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//abstract class: interface'ler, abstract class, base class (soyut nesneleri bulundurur), referans tutucular 
//concrete class: (somut nesneleri bulundurur)


ProductManager productManager = new ProductManager(new EfProductDal());

foreach (var product in productManager.GetAllByCategoryId(2))
{
    Console.WriteLine(product.ProductName);
}