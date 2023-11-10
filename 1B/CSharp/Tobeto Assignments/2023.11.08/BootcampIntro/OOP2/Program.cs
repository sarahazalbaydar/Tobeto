using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SOYUTLAMA(abstraction)
            //interface'ler belirli imzalara sahiptir, new'lenemez, bir class'ta birden fazla interface implemente olabilir
            //Customer customer1 = new Customer();
            //customer1.FirstName = "Engin";
            //customer1.LastName = "Demiroğ";
            //customer1.Id = 1;
            //customer1.IdentityNumber = "2222222";
            //customer1.CustomerNo = "12345";
            //customer1.CompanyName = "?";        //Engin Demiroğ tüzel kişidir, şirketadı olamaz
            //customer1.CustomerType = 1; çok yanlış bir kullanım

            //Gerçek(Corporate) Müşteri - Tüzel(Individual) Müşteri birbirlerinin yerine kullanılamazlar
            //SOLID -> L: birbirine benziyor diye birbiri yerine kullanma, inheritance'ı farklı çerçevede ele al
            Console.WriteLine("-----------");


            //Engin Demiroğ
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.FirstName = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.IdentityNumber = "12345678910";

            //Kodlama.io
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "1234567890";

            //customer class'ı hem Individual hem Corporate müşterinin referansını tutabilir!!! ÖNEMLİ
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}