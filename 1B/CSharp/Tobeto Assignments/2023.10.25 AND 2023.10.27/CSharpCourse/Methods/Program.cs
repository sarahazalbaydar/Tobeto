namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2(20, 30);
            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(out number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            //Console.WriteLine(result);
            //Console.WriteLine(Add0(20));

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));

            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));



        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2)
        {
            //void git şunu yap şeklinde kul. örn: git bir yere bir kayıt yap, bir yere bir şey yaz vs
            //döndürmek istediğimiz veri tipi ne ise o tip ile fonksiyon oluşt.
            var result = number1 + number2;
            return result;
        }

        static int Add0(int x, int number1 = 20, int number2 = 30)    //number2 verilmezse default olarak 30'u kullanır. default değer sona yazılır
        {
            var result = x + number1 + number2;
            return result;
        }

        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //ref ile out farkı: ref'te girilen değişkeni mutlaka ilk başta set etmemiz(default değer vermemiz) gerekir.
        //out'ta ise: out kullanılan metodun içinde o değişken mutlaka bir kere set edilmelidir

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        //method overload: farklı parametreler ile aynı method kullanılabilir
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        //params keyword'ü: metodumuza istediğimiz kadar parametre girebilme imkanı sağlar
        static int Add4(int number, params int[] numbers)
        {
            return numbers.Sum();
        }
        //params; metodun parametrelerinin son parametresi olmak zorundadır

    }
}