namespace ValueAndReferanceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //value types(değer tip): int, decimal, float, double, bool(=true)
            //reference types(referans tip): array, class, interface
            //değişken new'lendiği an, bellekte adres oluşturulur ve bu adres ile tutulur
            //değer tiplerde stack'e, ref tiplerde heap'e atılır

            int number1 = 10;
            int number2 = 30;
            number1 = number2;    //number1'in değeri eşittir number2'nin değeri şeklinde okunur
            number2 = 65;
            //number1 ? 30

            int[] numbers1 = new int[] {10, 20, 30};
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers1 = numbers2;   //numbers1'in ref numarası number2'nin ref numarasına eşittir şeklinde okunur
            numbers2[0] = 999;
            //numbers1[0] ? 999

        }
    }
}