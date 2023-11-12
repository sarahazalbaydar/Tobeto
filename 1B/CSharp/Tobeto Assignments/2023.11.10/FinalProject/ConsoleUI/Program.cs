using Business.Concrete;
using DataAccess.Concrete.InMemory;

//abstract class: interface'ler, abstract class, base class (soyut nesneleri bulundurur), referans tutucular 
//concrete class: (somut nesneleri bulundurur)


ProductManager productManager = new ProductManager(new InMemoryProductDal());

foreach (var product in productManager.GetAll())
{
    Console.WriteLine(product.ProductName);
}