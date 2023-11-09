//Value Types

int number1 = 10;                          //32 bitlik yer kaplar
long number2 = 1111111111111111111;        //int'in 2 katı yer kaplar. sınırı 19 karakterden oluşan bir sınırdır. 64 bitlik yer kaplar
short number3 = -25481;                    //16 bitlik yer tutar
byte number4 = 255;                        //bellekte 8 bit=1 byte yer kaplar. 0-255 arası değer tutar
bool condition = true;                    //mantıksal veri tipidir. true/false değerlerini tutar
char character = 'H';                     //tek değer alır(tek karakterlik)
double number5 = -10.2;                   // 64 bitlik ondalıklı sayıları tutmak için kul.
decimal number6 = -10.2m;                 //daha büyük ondalıklı sayıları tutar. sonuna m/M harfi eklemek gerekir
var number7 = 10;                         //atanan değerin veri tipi neyse o tutulur
number7 = 'H';                           //atanan veri 10 yani int olduğundan burada farklı değere eşitlemek istendiğinde o verinin int değerini alır
//number7 = "A"; bunu yapamayız çünkü veri tipi string


Console.WriteLine(number1);
Console.WriteLine("number1 is {0}", number1);       //{0} index'i belirtir, virgülden sonraki ilk değeri yazar
Console.WriteLine("number2 is {0}", number2);
Console.WriteLine("number3 is {0}", number3);

Console.WriteLine("number1 is {0}, number2 is {1} number3 is {2}", number1, number2, number3);

Console.WriteLine("number4 is {0}", number4);
Console.WriteLine("character is {0}", character);
Console.WriteLine("character's ASCII value is {0}", (int)character);

Console.WriteLine("number5 is {0}", number5);
Console.WriteLine("number6 is {0}", number6);
Console.WriteLine(Days.Friday);
Console.WriteLine("Friday için tip dönüşümü: {0} çünkü enum'da 4. indexte", (int)Days.Friday);
Console.WriteLine("number7 is {0}", number7);




//enum: programda 100 yerde "friday" yazdıysak ve bunu "monday" yapmak istiyorsak tüm programda tek tek uğraşmaktansa enum kul.
enum Days           //magic string ile uğraşmak durumunda kalmayız
{
    Monday=10, Tuesday=20, Wednesday, Thursday, Friday, Saturday, Sunday  //enum sabitleridir
}
//enum sabitlerinin değerleri değiştirilebilir(yukarıdaki gibi)
