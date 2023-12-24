//export -> CSharp'taki public -> dışarıdan ulaşmak için kullandığımız alan
class Customer {
  //değerleri atamak için PROTOTYPE denilen yapıdan faydalanırız.
  //yani her şey fonksiyondur, fonks.'a prototype oluşturulur

  //customer'in alanlarını(property'lerini vs) constructor pattern ile geçeriz.
  constructor(id, customerNumber) {
    this.id = id; //instance'ın id'si(customer.id) = id (const'tan gelen id)
    this.customerNumber = customerNumber;
    //this -> aşağıda new'lediğimiz customer oluyor
  } //this. yapısı bir prototyping özelliğidir
}
//js'de de csharp'ta olduğu gibi new kullanımı vardır
let customer = new Customer(1, "12345"); //instance oluşturduk
console.log(customer);

//ES'de INTERFACE yok!

//prototyping:

customer.name = "Şara Hazal Baydar"; //instance'a yapılan prototyping
console.log(customer.name);

Customer.bisey = "Bişey"; //class'a yapılan prototyping
console.log(Customer.bisey);

console.log(customer.customerNumber);

//Bireysel ve Kurumsal Müşteri class'ı oluşturup, bunları temel Customer class'ından
//inherit etmek için extends ifadesi kullanılır
class IndividualCustomer extends Customer {
  //extends ile Customer'dan inherit ettik
  constructor(firstName, id, customerNumber) {
    super(id, customerNumber);
    this.firstName = firstName;
  }
} //SUPER ile base'e yani Customer'a değer gönderiyoruz

class CorporateCustomer extends Customer {
  constructor(companyName, id, customerNumber) {
    super(id, customerNumber);
    this.companyName = companyName;
  }
}
//js'de fonks.'lar REFERANS tip sayılır
console.log("----------------");

//MAP -> bir array'i dönerken map'leme yaparak yeni bir array'e atama yapar
let products = [
  { id: 1, name: "kupa", unitPrice: 150 },
  { id: 2, name: "defter", unitPrice: 130 },
  { id: 3, name: "matara", unitPrice: 170 },
];

console.log("<ul>");
products.map((products) => console.log(`<li>${products.name}</li>`));
console.log("</ul>");
console.log(
  typeof products.map((products) => console.log(`<li>${products.name}</li>`))
);

//FILTER -> verilen dizinin elemanlarını filtreden geçirerek, geçenler ile YENİ BİR array oluşt.(0 elemanlı dahi olsa)
let filteredProducts = products.filter((product) => product.unitPrice > 180);
console.log(filteredProducts);

console.log("-----REDUCE------");
//REDUCE ->
let cartTotal = products.reduce((acc, product) => {
  console.log(acc, product);
  return acc + product.unitPrice;
}, 0);
console.log(cartTotal);
console.log("-----------");

let cartTotal2 = products
  .filter((p) => p.unitPrice > 130)
  .map((p) => {
    p.unitPrice = p.unitPrice * 1.2;
    return p;
  })
  .reduce((acc, p) => acc + p.unitPrice, 0);
console.log(cartTotal2);
