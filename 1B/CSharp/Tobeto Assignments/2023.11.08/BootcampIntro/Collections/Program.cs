using System.Collections.Generic;   //list sınıfını kullanabilmek için

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Engin", "Murat", "Kerem", "Halil"}; //stack kısmı = heap kısmı[] {değerler}
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);

            //burada names dizisine 5 elemanlı boş bir dizi atadık. Sonrasında 5. elemana "İlker" değerini atadık. Diğer elemanlar hala boş
            names = new string[5];
            names[4] = "İlker";
            Console.WriteLine(names[4]);
            Console.WriteLine(names[0]);
            Console.WriteLine("0. index boş olduğu için yukarıda boş yazdırdı");
            Console.WriteLine("-------------------");
            Console.WriteLine();

            //COLLECTIONS
            //using System.Collections.Generic; eklemek gereklidir
            Console.WriteLine("----COLLECTIONS----");
            List<string> names2 = new List<string>() { "Engin", "Murat", "Kerem", "Halil" };
            // names2.Add("Engin"); //listeye eleman eklemek
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("İlker");            //Add(): List'in method'u
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
            Console.WriteLine("-------------------");
            Console.WriteLine();

        }
    }
}