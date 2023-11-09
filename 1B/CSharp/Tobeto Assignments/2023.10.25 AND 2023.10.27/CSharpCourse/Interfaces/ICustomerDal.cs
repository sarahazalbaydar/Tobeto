using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //amaç uygulamamızın bağımlılıklarını minimize etmek
    //müşterimiz bizden farklı data base'lerde sonuçlar isteyebilir, bunun için farklı data base'ler için kod yazmaktansa ICustomerDal verilip
    //(yani interface), farklı veri tabanları için yazmamızı mümkün kılabiliriz
    //gerçek hayat uygulamalarında interface'ler bu şekilde katmanlar arası geçişlerde kullanılır

    internal interface ICustomerDal       //dal: data access layer : insert, update, delete gibi veri tabanı işlemlerinin yapılacağı sınıf
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");

        }

        public void Update()
        {
            Console.WriteLine("Sql updated");

        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");

        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }
    }

    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added");

        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            //burada girdi olarak ne sql ne de oracle görünür, sadece interface görünür
            customerDal.Add();
        }
    }
}
