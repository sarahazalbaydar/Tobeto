using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        //InMemoryProductDal -> InMemory(bellek) teknolojisinde product ile ilgili, data access kodlarının yazılacağı yer

        List<Product> _products;   //method dışında tanımlanan global değişkenler isimlendirilirken _ ile başlar _products
        public InMemoryProductDal()   //constructor: ctor, tab yapınca oluşur, class ile aynı isimdedir
        {
            _products = new List<Product>()
            {
                //Oracle, SQL, Postgre, MonDb veritabanından geliyor gibi simüle ettik
                new Product{ProductId = 1, CategoryId = 1, ProductName = "Bardak", UnitPrice = 15, UnitsInStock = 15},
                new Product{ProductId = 2, CategoryId = 1, ProductName = "Kamera", UnitPrice = 500, UnitsInStock = 3},
                new Product{ProductId = 3, CategoryId = 2, ProductName = "Telefon", UnitPrice = 1500, UnitsInStock = 2},
                new Product{ProductId = 4, CategoryId = 2, ProductName = "Klavye", UnitPrice = 150, UnitsInStock = 65},
                new Product{ProductId = 5, CategoryId = 2, ProductName = "Fare", UnitPrice = 85, UnitsInStock = 1}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated Query: foreach gibi çalışır. Listeyi döner ve istenen değerin referansını çeker. Tek referans değeri döner
            //Linq olmasaydı bu şekilde olacaktı
            //Product productToDelete = null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}
            //productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId); //First(), FirstOrDefault() da kullanılabilirdi
            //_products.Remove(productToDelete);


            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            //Where: içindeki şarta uyan tüm elemanları yeni bir liste halina getirir
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);    //Gönderdiğim ProductId'ye sahip olan listedeki product'ı bul 

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

    }
}
