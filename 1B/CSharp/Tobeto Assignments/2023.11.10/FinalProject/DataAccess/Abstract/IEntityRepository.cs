using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Generic Constraint: generic kısıt
    //T:class -> T referans tip olabilir demek, class olabilir demek değil
    //T:class, IEntity -> ve T ya IEntity olarak ya da IEntity implemente eden bir nesne olabilir
    //T:class, IEntity, new() -> new'lenebilir olmalı demek(IEntity new'lenemez old.'dan IEntity'yi devre dışı bırakmış olduk
    public interface IEntityRepository<T> where T:class, IEntity, new() //<T> -> çalışacağımız tipi(product, category vs) söyleyeceğiz demek(generic yapısı)
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //parantez içindeki yapı ile ürünü ayrı ayrı categoryId'ye göre, price'ına göre vs filtrele ve getir dememize gerek kalmayacak. filter = null: filtre vermeyebilirsin. Filtre vermemişse tüm data'yı istiyor, filtre vermişse filtreleyip verecek
        T Get(Expression<Func<T, bool>> filter);    // -> filtre olmak zorunda
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
