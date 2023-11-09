namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForeachLoop();

            if (IsPrimeNumber(7))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }

        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;         //break, continue gibi ifadeler de kullanılabilir
                }
            }
            return result;
        }

        static void ForLoop()
        {
            for (int i = 100; i >= 0; i -= 2)
            {
                //for(başlangıç değer; şart; bir dönüş bittiğinde ne yapılmasını istediğimiz)
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
        }

        static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
        }

        static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                //do while döngüsü önce bir kez çalışır, sonra şarta bakar
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
        }

        static void ForeachLoop()
        {
            string[] students2 = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in students2)
            {
                //foreach içerisinde döndüğümüz elemanları değiştiremeyiz
                Console.WriteLine(student);
            }
        }
    }
}