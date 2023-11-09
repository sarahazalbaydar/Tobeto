//Şart bloğu

//if bloğu ile çalışmak

var number = 10;

if (number == 10)
{
    Console.WriteLine("number is 10");
}
else
{
    Console.WriteLine("number is not 10");
}
Console.WriteLine("------------");

Console.WriteLine(number == 10 ? "number is 10" : "number is not 10"); // (şart ifadesi ? ifade doğruysa çalışır : ifade yanlışsa çalışır)
//(şart ? true ise çalışır : false ise çalışır)
Console.WriteLine("------------");

if (number == 10)
{
    Console.WriteLine("number is 10");
}
else if (number == 20)
{
    Console.WriteLine("number is 20");

}
else
{
    Console.WriteLine("number is not 10 or 20");
}
//else bloğu olduğu sürece mutlaka bir şart bloğu çalışır
Console.WriteLine("------------");

switch (number)
{
    case 10:
        Console.WriteLine("number is 10");
        break;
    case 20:
        Console.WriteLine("number is 20");
        break;
    default:
        Console.WriteLine("number is not 10 or 20");
        break;
}
//ctrl + k ve peşine ctrl + d basınca identation işlemini (kodu okunaklı hale getirme) yapar
//ctrl + k ve peşine ctrl + c basınca seçili kısmı yorum satırına alır (c:comment yani comment bloğu oluşur)
//ctrl + k ve peşine ctrl + u basınca seçili kısmı yorum satırından çıkartır

Console.WriteLine("------------");

if (number >= 0 && number <= 100)
{
    Console.WriteLine("Number is between 0-100");
}
else if (number > 100 && number <= 200)
{
    Console.WriteLine("Number is between 101-200");
}
else if (number > 200 || number < 0)
{
    Console.WriteLine("{0} is less than 0 or greater than 200", number);
}
Console.WriteLine("------------");

//nested if (iç içe if blokları:

if (number <= 100)
{
    if (number >= 50)
    {
        Console.WriteLine("Number is between 49-101");

    }
    else { Console.WriteLine("Number is less than 50"); }
}
else
{
   Console.WriteLine("Number is greater than 100");

}
