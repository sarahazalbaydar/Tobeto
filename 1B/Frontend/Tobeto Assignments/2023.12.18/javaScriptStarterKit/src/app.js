//Degisken tanimlamada kullanilan keyword'ler:
//var, let(cogunlukla kullanilan), const

var sayi1 = 10;
sayi1 = "Engin Demiroğ"; //let sayi1 = "Engin Demiroğ"; hata verirdi
let student1 = { id: 1, name: "Engin" }; //object notation
//{} -> obje tanımlarken kul.
//console.log(student);

function save(student) {
  //console.log(student);
}
//js'de class'lar da fonksiyonlara çevrilir/aslında fonksiyondur
save(student1);
//undefined -> yok olduğu anlamına gelir

function save2(puan = 10, ogrenci) {
  //console.log(ogrenci.name + " : " + puan);
}
//js'de class'lar da fonksiyonlara çevrilir/aslında fonksiyondur
save2(undefined, student1);

let students = [
  "Şara Hazal Baydar",
  "Ersin Kaya",
  "Gökçe Fırat",
  "Özgür Sönmez",
];
//console.log(students);

let students2 = [students, { id: 2, name: "Hazal" }, "Ankara"];
//console.log(students2);

console.log("-------------------");
console.log("restSpreadDestructure");
console.log("-------------------");

//REST(geriye kalan) operatörü -> CSharp'ta params ->
//istediğimiz miktarda gönderdiğimiz parametreyi array olarak tutmayı sağlar
//rest'te ...products yapısı bir array'dir
//rest parametreleri array formatınca değil de sıralı n-li formatında gönderilir
let showProducts = function (id, ...products) {
  console.log(id);
  console.log(products);
}; //bir değişkene fonksiyon atayabiliyoruz

//console.log(typeof showProducts);
//showProducts();
//showProducts(10, ["Elma", "Erik", "Karpuz"]);   //array içinde array gelir, 3 eleman bir eleman gibi yani bir array'in bir elemanı gibi gönderilir
// (doğru kullanım) showProducts(10, "Elma", "Erik", "Karpuz"); // 10, bir array çıktısı gelir

console.log("-------------------");

//SPREAD operatörü -> (ayrıştırmak) bir array'i parametre gibi virgül ile ayrıştırmaya yarar
//console.log(Math.max(1, 2, 5, 2, 30, 13));
let points = [1, 2, 5, 2, 30, 13];
console.log(...points); //AYRIŞTIRMA İŞLEMİ YAPILDI
console.log(Math.max(...points));
console.log(..."ABC", "D", ..."EFG", "H");

console.log("-------------------");

//DESTRUCTURING (parçalamak)-> bir array'in değerlerini, değişkenlere atama yöntemidir
let populations = [10000, 20000, 30000, [40000, 100000]];
let [small, medium, high, [veryHigh, maximum]] = populations;
console.log(small);
console.log(medium);
console.log(high);
console.log(veryHigh);
console.log(maximum);

console.log("-------------------");

function someFunction([small1], number) {
  console.log(small1);
}
someFunction(populations);
//js'de function'lara parametre verirken tip belirtilmediği için,
//burada verdiğimiz [small1] parametresi burada destructing yapıldığını
//belirtir

//OBJE'lerde destruct edilmek istenebilir
//önce bir obje oluşturalım
let category = { id: 1, name: "İçecek" }; //obje
console.log(category.id); //objelerde genel kullanım bu şekilde
console.log(category["name"]); //fakat bu şekilde notasyonu da mümkün

//şimdi bu objeyi destruct edelim
let { id, name } = category;
console.log(id);
console.log(name);

console.log("-------------------");
console.log("OOP");
console.log("-------------------");

//export -> CSharp'taki public
class Customer {
  //değerleri atamak için PROTOTYPE denilen yapıdan faydalanırız.
  //yani her şey fonksiyondur, fonks.'a prototpe oluşturulur
  constructor(id, customerNumber) {
    this.id = id;
    this.customerNumber = customerNumber;
    //this -> aşağıda new'lediğimiz customer oluyor
  } //this. yapısı bir prototyping özelliğidir
}
let customer = new Customer(1, "12345");
console.log(customer);

//prototypeing:
customer.name = "Şara Hazal Baydar"; //instance'a yapılan prototyping
console.log(customer.name);

Customer.bisey = "Bişey"; //class'a yapılan prototyping
console.log(Customer.bisey);

console.log(customer.customerNumber);

class IndividualCustomer extends Customer {
  //extends ile Customer'dan inherit ettik
  constructor(firstName, id, customerNumber) {
    super(id, customerNumber); //super'e id ve customerNumber göndermişiz yani Customer'e
    this.firstName = firstName;
  }
}

class CorporateCustomer extends Customer {
  constructor(companyName, id, customerNumber) {
    super(id, customerNumber);
    this.companyName = companyName;
  }
}
//js'de fonks.'lar referans tip sayılır

//MAP
let products = [
  { id: 1, name: "kupa", unitPrice: 150 },
  { id: 2, name: "defter", unitPrice: 130 },
  { id: 3, name: "matara", unitPrice: 170 },
];

console.log("<ul>");
products.map((products) => console.log(`<li>${products.name}</li>`));
console.log("</ul>");

//FILTER -> verilen dizinin elemanlarını filtreden geçirerek, geçenler ile yeniden array oluşt.
let filteredProducts = products.filter((product) => product.unitPrice > 12000);
console.log(filteredProducts);

//REDUCE ->
let cartTotal = products.reduce((acc, product) => acc + product.unitPrice, 0);
console.log(cartTotal);

let cartTotal2 = products
  .filter((p) => p.unitPrice > 13000)
  .map((p) => {
    p.unitPrice = p.unitPrice * 1.2;
    return p;
  })
  .reduce((acc, p) => acc + p.unitPrice, 0);
console.log(cartTotal2);
