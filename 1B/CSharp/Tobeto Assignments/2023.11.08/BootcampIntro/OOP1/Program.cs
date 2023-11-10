namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;    //2:mobilya olsun
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //ProductManager productManager2 = new ProductManager();
            //productManager2.Add(product1);
            //product1.ProductName = "Silgi";
            //productManager2.Add(product1);

            Product product2 = new Product {Id=2, CategoryId=5, UnitsInStock=5,  ProductName="Kalem", UnitPrice=35};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}