using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //DataAccess katmanı; veritabanında yapılacak işlemleri içeren katman
    //IProductDal -> I:interface old., Product: hangi entity'ye karşılık geldiği, Dal: hangi katmana karşılık geldiğini. anlatır
    //Product ile ilgili veritabanında yapılacak operasyonları listeler
    public interface IProductDal:IEntityRepository<Product>     //IProductDal bir IEntityRepository ve çalışma tipi Product
    {
    }
}
