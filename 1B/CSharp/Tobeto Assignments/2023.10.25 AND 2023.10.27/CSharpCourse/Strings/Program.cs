namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Şara Hazal Baydar";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Hazal Baydar";

            bool result3 = sentence.EndsWith("r");
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("namee");      //index'ini alır. bulamazsa -1 döndürür
            var result6 = sentence.IndexOf(" ");          //bulduğu ilk boşluğu alır
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");  // cümlenin başına ekleme yapar
            var result9 = sentence.Substring(3, 4);       //3. karakterden itibaren 4 tane karakter al
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ", "-");
            var result13 = sentence.Remove(2);            //2. karakterden itibaren kaldırır yani boşluktan itibaren
            var result14 = sentence.Remove(2, 5);         //2. karakterden itibaren 5 karakter kaldırır

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);
            Console.WriteLine(result9);
            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.WriteLine(result12);
            Console.WriteLine(result13);
            Console.WriteLine(result14);

        }

        private static void Intro()
        {
            string city = "Ankara";
            //stringler bir char array'dir
            Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------");

            string city2 = "İstanbul";
            //string result = city + city2;
            //Console.WriteLine(result);

            Console.WriteLine(String.Format("{0} {1}", city, city2));
            //bellekte 3. bir değişken tanımlamaz
        }
    }
}