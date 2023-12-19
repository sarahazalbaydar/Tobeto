// java, c#, dart -> dil güvenli diller

//js type-safe(tip güvenli) değildir => TS (type script) javascript'in type-safe hali
var text = "Merhaba, Tobeto";
console.log(text);
text = 50;
console.log(text);
text = true;
console.log(text);

//EcmaScript (betik dili?) => javascript'in eski yapısının modern dillere yakın uyarlanmış hali => EC6 (2015)
//EC6 ile gelen let & const -> var keyword'ünün problemlerini ortadan kaldırır(let keyword'ü)

//console.log(hello);
//var hello = "Merhaba";

//

//var number = 10;
//if (number > 5) {
//  var newVariable = "Hello";              //scope dışında kullanamamamız gerekir
//}
//console.log(newVariable);

// console.log(hello);
// let hello = "Merhaba";

// let number = 10;
// if (number > 5) {
//   let newVariable = "Hello";
// }
// console.log(newVariable);

//ES6 2015 - ES 2016 - ES 2017 - ES 2018

function topla(sayi1, sayi2) {
  return sayi1 + sayi2;
}

// console.log(topla(5, 10));
// console.log(topla()); //Not a number
// console.log(topla(1));
// console.log(topla(1, "5"));
// console.log(topla(1, 5, 3, 3, 7, 8, 5, 11, 9));

// Arrow Function -> syntax -> let keyword'ü ile fonksiyonu bir değişken gibi tanımlamakla başlar.. ?
//let toplaFunction = () => {}
//topla değişkeni bir fonksiyondur

const toplaFunction = (sayi1, sayi2) => sayi1 + sayi2;
const toplaFunction2 = (sayi1, sayi2) => {
  //blah blah
  //

  return sayi1 + sayi2;
};

console.log(toplaFunction(5, 10));
console.log(toplaFunction()); //Not a number
console.log(toplaFunction(1));
console.log(toplaFunction(1, "5"));
console.log(toplaFunction(1, 5, 3, 3, 7, 8, 5, 11, 9));

//const'a bir değer tanımladığımızda bu değeri değiştiremeyiz, sabit bir değerdir
//arrow function'larda önerilen const'tur

const PI = 3.14;
//PI = 5 //hatalı bir durumdur, yapılamaz

console.log("--------------");

// CB(callback) functions
// fonksiyon içerisinde fonks. verdiğimiz sistemlerdir

let list = [5, 10, 15, 20];
list.forEach((element, index) => {
  console.log(element, index);
}); //bana bir fonks. ver ben listenin içini dönerken bu fonks'u uygulayayım

console.log("--------------");

// map-filter-reduce functions
//array dediğimiz listelerin içindeki (array interface) fonks.'lardır

//MAPPING -> elimizdeki list'i istediğimiz şekilde map'leyerek yeni bir lis oluşt. sağlar
let newList = list.map((element) => element * 2);
console.log(newList);

//FILTER -> filtreleme yapar ve geriye yine bir list döner
let filteredList = list.filter((element) => element >= 10);
console.log(filteredList);
//predicate'e uyan tüm elemanları list haline getirip yeni bir list oluşturdu

//REDUCE -> elemanlar arasında kümülatif şekilde her eleman ile sonraki eleman arasında işlem yapıp, bir sonraki adımdaki ikinci elemanı kullanmanızı sağlar
//bu işlemi listede işlemi yapacak eleman kalmayana kadar yapar
let value = list.reduce((previous, next) => {
  console.log(previous, next);
  return previous + next;
}, 0); //verdiğimiz ikinci parametredeki değeri; yaptığı ilk toplamadaki değere ekler yani [5, 10, 15, 20] -> 5 + 10 + 0
console.log(value);
