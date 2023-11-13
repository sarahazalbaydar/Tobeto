using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet: C#'ın .Net içerisindeki implementasyonlarını kullandık, başka insanların yazdığı kodları paket halinde aldığımız ortam
    ////DataAccess -> Manage NuGet Packages... -> "entityframeworkcore.sql" -->> bu sayede dataaccess içinde entityframeworkcore kodu yazabileceğiz
    public class EfProductDal : IProductDal
    {   //Burasının içi entity framework teknolojine göre kodlanacaktır
        public void Add(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())   //using bloğu, parametrede new'lenen referans tipleri blok bittikten hemen sonra bellekten siler
            {
                var addedEntity = context.Entry(entity);      //referansı yakala
                addedEntity.State = EntityState.Added;        //ne yapacağını söyle(ekleme işlemi)
                context.SaveChanges();                        //eklemeyi yap
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())   
            {
                var deletedEntity = context.Entry(entity);        //referansı yakala
                deletedEntity.State = EntityState.Deleted;        //ne yapacağını söyle(silme işlemi)
                context.SaveChanges();                            //silmeyi yap
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);  //filtreleme sonucu çıkan çıktıyı product olarak döndür(sql'de product tablosundan 1 satır almak gibi)
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null 
                    ? context.Set<Product>().ToList()  //Set<Product>().ToList() -> veritabanındaki Select * from Products 'ı döndürür
                    : context.Set<Product>().Where(filter).ToList();    //filtre varsa bu kısım çalışır ve filtreyi getirir
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);         //referansı yakala
                updatedEntity.State = EntityState.Modified;        //ne yapacağını söyle(güncelleme işlemi)
                context.SaveChanges();                             //güncellemyi yap
            }
        }
    }
}
