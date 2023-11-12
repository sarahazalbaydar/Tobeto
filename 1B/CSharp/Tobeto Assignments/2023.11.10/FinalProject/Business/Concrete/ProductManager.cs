using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //Manager: business katmanının somut sınıfı
    //!!! Bir iş sınıfı, başka sınıfları new'lemez
    public class ProductManager : IProductService
    {
        IProductDal _productDal;    //her teknoloji olabilir?

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //İş kodları
            //yetkisi var mı? 
            //vs vs

            return _productDal.GetAll();
        }
    }
}
