import { ADD_TO_CART, REMOVE_FROM_CART } from "../actions/cartActions";
import { cartItems } from "../initialValues/cartItems";

const initialState = {
  cartItems: cartItems, //sağ taraf initialValues'deki cartItems'dan geliyor, sol taraf bu değişkeni atadığımız değişken
};

//bu fonksiyon state ve action istiyor -> state, action içerisindeki obje ({ type, payload })
export default function cartReducer(state = initialState, { type, payload }) {
  //gönderdiğimiz aksiyona göre sepetimizin son halini tuttuğumuz yer
  //initialState'i default state olarak geçiyoruz. Çünkü sepet başlangıçta boş da olabilir,
  //ürüne sahip de olabilir, sepetin başlangıçta render edilebilmesi için bir initialState'e sahip olması gerekir

  //buraya gelecek type'a göre state'i nasıl değiştireceğimizi belirliyoruz:
  //(burada aslında bir fonksiyona parametre olarak başka bir fonksiyon gönderiyoruz)
  switch (type) {
    case ADD_TO_CART:
      //sepette gönderilen ürün varsa adedini artıracağız, yoksa sıfırdan ekleteceğiz
      let product = state.cartItems.find(
        (c) => c.product.productId === payload.productId
      );
      if (product) {
        product.quantity++;
        return {
          ...state,
        };
      } else {
        return {
          ...state,
          cartItems: [...state.cartItems, { quantity: 1, product: payload }],
        };
      }

    case REMOVE_FROM_CART:
      return {
        ...state,
        cartItems: state.cartItems.filter(
          (c) => c.product.productId !== payload.productId
        ),
      };

    default:
      return state;
  }
}
