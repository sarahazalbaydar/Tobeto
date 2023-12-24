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
