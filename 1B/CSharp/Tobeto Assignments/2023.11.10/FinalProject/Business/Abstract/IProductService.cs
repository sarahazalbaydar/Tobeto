using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    //business kodlarını service olarak isimlendiririz
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
