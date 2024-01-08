import React from "react";
import ReactDOM from "react-dom";
import "./index.css";
import App from "./App";
import reportWebVitals from "./reportWebVitals";
import { BrowserRouter } from "react-router-dom";
import { Provider } from "react-redux";
import { configureStore } from "./store/configureStore";

//uygulamamızı react altyapısına getirmek için react-redux'tan gelen Provider ile sarmalıyoruz
//Provider bir component'tir, bu component'e biz params ile store geçiyoruz. Böylece
//Provider içerisindeki uygulamamız store'un içeriklerinden faydalanabilecek
const store = configureStore();
ReactDOM.render(
  <Provider store={store}>
    <BrowserRouter>
      <App />
    </BrowserRouter>
  </Provider>,
  document.getElementById("root")
);
// Route'un çalışabilmesi için ana bileşenimizi (app) browserrouter ile sarmallamamız gerekmektedir
//bu, route işlemini app'de destekleyeceğiz demektir

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();