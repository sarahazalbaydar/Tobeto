using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: database tabloları ile proje class'larını bağlayan class(yani veritabanındaki tablolar ile entities'i eşleme yapacağız)
    //connection string: 
    public class NorthwindContext:DbContext   //DbContext EntityFrameWork ile geliyor, burada implement etmek gerekir
    {
        //"override on" yazınca gelen method; projenin ilişkili olduğu database'i belirttiğimiz alan
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)  //proje çalıştırıldığında ilk bakılan kısım
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=Northwind;Trusted_Connection=true;TrustServerCertificate=True");   //SQL server'a nasıl bağlanacağımızı belirtmemiz yeterli

        }
        
        //hangi tablonun neye karşılık geldiği yazılır
        public DbSet<Product> Products { get; set; }    //Product entity'si, database'deki Products tablosuna karşılık geldi demek (yani hangi class hangi tabloya karşılık geldi demek)
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
