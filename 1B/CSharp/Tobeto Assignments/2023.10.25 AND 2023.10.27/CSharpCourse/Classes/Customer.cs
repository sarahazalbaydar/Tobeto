class Customer
{
    public int Id { get; set; }
    //property class'lar, bir müşterinin özelliklerini tutmak için kul. nesnelerdir.
    //Örn: veri tabanlarındaki kolonları bir class içerisinde tutabiliriz

    //Field(alan):
    //Encapsulation(kapsülleme): kullanıcıdan alınan veriyi farklı şekilde get etmek istersek kullanılabilir
    //private string _firstName;
    //public string FirstName
    //{
    //    get { return "Mrs." + _firstName; }       //set ettiğimiz value'nun önüne get ederken gelmesi için ek ekledik
    //    set { _firstName = value; }               //value: set etmeye çalıştığımız değere karşılık gelir
    //}

    //eğer bir class içinde property tutmak istiyorsak aşağıdaki gibi tanımlamalıyız
    //Property:
    public string FirstName { get; set; }       //auto-property. daha çok kullanılır, gerektiğinde parantez açıp gerekli ekleme yapılır
    public string LastName { get; set; }
    public string City { get; set; }

}