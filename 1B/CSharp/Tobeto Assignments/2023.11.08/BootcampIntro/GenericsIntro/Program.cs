namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GENERICS
            //<>: yapısıdır. Liste yapısını kendimiz oluşturacağız
            MyList<string> names = new MyList<string>(); //kendimiz herhangi bir tip girdik, int vs de girebilirdik
            names.Add("Engin");
            names.Add("Hazal");
            names.Add("Ersin");


            foreach (string item in names.GetValues()) 
            { 
                Console.WriteLine(item);
            }

        }
    }
}