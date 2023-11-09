namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //class'lar da string, double gibi bir veri tipidir
            //class isimlendirmeleri ilk harfi büyük o.ş. yazılır
            //class'lar 2 şekilde kullanılır 1- ÖZELLİK TUTARLAR

            Product product1 = new Product(); //Product product1; şeklinde tanımlanır fakat Product bir class old. için new'lemek gerekir. Burada bir ürün old. belirttik
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 150;
            product2.Description = "Diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };

            //type-safe -> tip güvenli
            //Product yerine var da yazabiliriz
            foreach (Product product in products) //veritipi dizielemanı in dizi
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("-----------------------");

            }

            Console.WriteLine("--------Methods----------");

            //instance -> örnek (class çağrılırken, class örneği oluşturulur)
            //ENCAPSULATION: KAPSÜLLEME
            //int Id, string Name, double Price, string Description, int UnitInStock  --->> Product

            BasketManager basketManager = new BasketManager();
            //basketManager.Add();    //class içerisindeki method'u çağırdığımız için instance üzerinden method çağrılır
            //basketManager.Add();
            //basketManager.Add();
            //basketManager.Add();
            //basketManager.Add();
            basketManager.Add(product1);
            basketManager.Add(product2);

            basketManager.Add2(product1.Name, product1.Description, product1.Price, product1.UnitInStock);    //ileride Product class'ına property eklemesi yaptığımızda (örn:stok bilgisi) fonksiyon parametresine ve tüm sayfalardaki Add2 method'unun çağrıldığı alanlara da stok girdisini eklememiz gerekir. Bu nedenle bu kullanım verimli değildir.
            
            //Bu yapıyı bir düzene sokmaya ENCAPSULATION denir

        }
    }
}

//Don't repeat yourself - DRY - Clean Code - Best Practice