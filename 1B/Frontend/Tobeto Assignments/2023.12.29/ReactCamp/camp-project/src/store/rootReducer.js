//tüm state'leri burada toplarız, sonra uygulamaya bunu ekleriz
//bundan sonra:
// önce actions'ı (aksiyonları) yazacağız
//initialvalue varsa onu vereceğiz
//reducer'ı yazacağız
//son olarak yazdığımız reducer'ı, rootReducer'a ekleyeceğiz. rootReducer üzerinden çalışacağımız için rootReducer'a yazmak,
//eklenen reducer'ı tüm uygulamada kullanılabilir hale getirir

import { combineReducers } from "redux";
import cartReducer from "./reducers/cartReducer";

const rootReducer = combineReducers({
  cart: cartReducer,
  //başka reducer olsaydı onları da yazacaktık. userReducer ekledik fakat içini henüz doldurmadığımız için
  //buraya eklemeye gerek yok
});

export default rootReducer;
