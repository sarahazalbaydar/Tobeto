namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ile metinsel veri tipleri kullanılır. referans veri tipidir
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            string[] students2 = { "Engin", "Derin", "Salih" };
            //string[] students2 = new[] { "Engin", "Derin", "Salih" };
            //string[] students2 = new string[3] { "Engin", "Derin", "Salih" };

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("---------");

            //multidimensional arrays: çok boyutlu diziler

            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"Aydın","İzmir","Manisa" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)     //[5,3] old. için (0): 5; (1):3
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("**********");
            }
        }
    }
}