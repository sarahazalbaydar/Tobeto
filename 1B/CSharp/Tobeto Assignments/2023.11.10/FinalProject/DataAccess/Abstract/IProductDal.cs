using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //DataAccess katmanı; veritabanında yapılacak işlemleri içeren katman
    public interface IProductDal    //Product ile ilgili veritabanında yapılacak operasyonları listeler
    { //IProductDal -> I:interface old., Product: hangi entity'ye karşılık geldiği, Dal: hangi katmana karşılık geldiğini. anlatır

        List<Product> GetAll(); //Burada entity katmanının içeriğini kullanacağımız için Entity katmanını REFERANS vermemiz gerekiyor
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetAllByCategory(int categoryId);

    }
}
