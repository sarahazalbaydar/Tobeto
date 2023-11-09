//inheritance: kalıtım, miras
//interface'ler bir inheritance değildir fakat öyle gibi kullanılabilir
//abstract class'larda inheritance kul.

//bir nesne SADECE BİR KERE INHERITANCE alınabilir fakat BİRDEN FAZLA IMPLEMENTASYON yapılabilir
//örn: bir kişinin sadece bir babası(inheritance'ı) olabilir
//önce inheritance yazılır, sonra interface
//interface tek başına anlam ifade etmez fakat class'lar tek başına anlam ifade eder

//Customer customer = new Customer();
//customer.City;

Person[] persons = new Person[3]
{
    new Customer
    {
        FirstName="Şara Hazal"
    }, new Student
    {
        FirstName="Derin"
    }, new Person
    {
        FirstName="Engin"
    }    

};

foreach (var person in persons)
{
    Console.WriteLine(person.FirstName);
}

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }
}

class Person2
{
    
}

class Customer : Person         
{
    //burada Person, Customer'in ebeveyni gibidir
    public string City { get; set; }
}

class Student : Person
{
    public string Department { get; set; }
}