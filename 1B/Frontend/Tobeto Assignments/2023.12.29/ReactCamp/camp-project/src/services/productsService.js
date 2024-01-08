import axios from "axios";

export default class ProductService {
  getProducts() {
    return axios.get("https://localhost:7295/api/Products/getall");
    //API'ye request etme kodu
  }

  getById(id) {
    return axios.get("https://localhost:7295/api/Products/getbyid?id=" + id);
    //API'ye request etme kodu
  }
}
