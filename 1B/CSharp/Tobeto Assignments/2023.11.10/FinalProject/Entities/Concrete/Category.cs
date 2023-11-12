using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //Çıplak Class Kalmasın: eğer bir class interface veya inheriance almıyorsa ileride sıkıntı çıkacaktır. Bu nedenle bu varlıkları gruplama eğilimine gideriz
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }



    }
}
