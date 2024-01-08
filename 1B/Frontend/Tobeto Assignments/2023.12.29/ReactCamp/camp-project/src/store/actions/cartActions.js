//sepetle ilgili actions burada tutulur. Yani;
//reducer'lara gönderdiğimiz operasyonlar.
//redux gönderilen aksiyonun hangi state içerisinde olduğuna göre o state'i tetikler

export const ADD_TO_CART = "ADD_TO_CART"; //magic string kullanmak istemediğimiz için burada sabitleme
//yaptık. Çünkü "ADD_TO_CART" yazarken yazım hataları meydana gelebilir. type string istediği için
//mecburen string kullandık
export const REMOVE_FROM_CART = "REMOVE_FROM_CART";

export function addToCart(product) {
  //sepete ekleme action'ı
  //redux bir aksiyon yapıldığında obje gönderilmesini ister bu nedenle obje döndürdük.
  //bu obje 2 şey ister:
  //aksiyonun ismi olsun -> type
  //state'i etkileyecek veri olsun -> payload

  return {
    type: ADD_TO_CART, //aksiyona "ADD_TO_CART" ismini verdik
    payload: product, //aksiyon ile beraber state'i etkileyecek veri
  };
}

export function removeFromCart(product) {
  return {
    type: REMOVE_FROM_CART,
    payload: product,
  };
}
