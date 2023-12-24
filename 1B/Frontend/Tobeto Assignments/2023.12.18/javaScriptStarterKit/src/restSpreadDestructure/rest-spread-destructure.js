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
