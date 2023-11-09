//InterfacesIntro();
//bir interface hiçbir zaman new'lenemez çünkü tek başına bir anlamı yoktur örn: IPerson person = new IPerson(); gibi olamaz.
//IPerson person = new Customer(); veya IPerson person = new Student(); vs olabilir

using Interfaces;

//Demo();


//Diyelim ki elimizdeki veriyi, şirketimizin hem sql server hem de oracle data base'ine yazmak istiyoruz:

ICustomerDal[] customerDals = new ICustomerDal[3]
{
    new SqlServerCustomerDal(),             //yeri geldiğinde buraya başka data base'ler de eklenebilir, problem olmayacaktır
    new OracleCustomerDal(),
    new MySqlCustomerDal()
};

foreach (var customerDal in customerDals)
{
    customerDal.Add();
}

static void InterfacesIntro()
{
    //interface'ler sadece birer syntax değildir
    //özellik veya metod gibi operasyonlar tanımlanabilir
    //temel bir nesne oluşturup, bütün nesneleri oradan , implement etmektir
    //soyut nesnelerdir, tek başlarına anlam ifade etmezler

    PersonManager manager = new PersonManager();
    Customer customer = new Customer
    {
        Id = 1,
        FirstName = "Şara Hazal",
        LastName = "Baydar",
        Address = "Aydın"
    };

    Student student = new Student
    {
        Id = 1,
        FirstName = "Derin",
        LastName = "Demiroğ",
        Departmant = "Computer Sciences"
    };
    manager.Add(student);
    manager.Add(customer);

    //2. yol:
    //manager.Add(new Customer { Id = 1, FirstName = "Şara Hazal", LastName = "Baydar", Address = "Aydın" });
}

static void Demo()
{
    CustomerManager customerManager = new CustomerManager();    //CustomerManager class old. için new'lemek gerekti
    customerManager.Add(new OracleCustomerDal());
    customerManager.Add(new SqlServerCustomerDal());
}

interface IPerson       //interface'leri I ile başlayıp sonrasında ilk harfli büyük o.ş. isimlendirmek gerekir
{
    int Id { get; set; }    //interface'ler yazılırken tamamen metodun imzası yazılır, soldaki gibi. (public vs yazılmaz). Bu method'lar için de genellikle geçerlidir
    string FirstName { get; set; }
    string LastName { get; set; }

}

//class'lar somut nesnelerdir
class Customer : IPerson      //burada; IPerson'da tanımlanmış her şeyi burada görebiliriz dedik. 
{
    //IPerson interface'i içindeki tüm özellikleri burada da yazmalıyız.
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //sadece customer içinde olan özellikler de barındırılabilir
    public string Address { get; set; }
}

class Student : IPerson      //burada; IPerson'da tanımlanmış her şeyi burada görebiliriz dedik
{
    //IPerson interface'i içindeki tüm özellikleri burada da yazmalıyız.

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //sadece student içinde olan özellikler de barındırılabilir
    public string Departmant { get; set; }
}

class Worker : IPerson      //burada; IPerson'da tanımlanmış her şeyi burada görebiliriz dedik
{
    //IPerson interface'i içindeki tüm özellikleri burada da yazmalıyız.

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //sadece worker içinde olan özellikler de barındırılabilir
    public string Departmant { get; set; }
}

class PersonManager                   //bir nesne de parametre olabilir
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}