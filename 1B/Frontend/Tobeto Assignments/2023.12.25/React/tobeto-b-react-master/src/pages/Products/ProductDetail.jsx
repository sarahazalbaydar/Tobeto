import React, { useEffect, useState } from "react";
import axios from "axios";
import { useParams } from "react-router-dom";
import { Link } from "react-router-dom";

export default function ProductDetail() {
  const [productDetail, setProductDetail] = useState([]);

  let { id } = useParams(); //URL'den id parametresi alındı

  useEffect(() => {
    axiosGet();
  }, []);

  const axiosGet = async () => {
    let response = await axios.get("https://dummyjson.com/products/" + id);
    setProductDetail(response.data);
  };

  return (
    <div class="card" style={{ width: "18rem" }}>
      <img
        src={productDetail.thumbnail}
        class="img-fluid rounded-start"
        alt="..."
      />
      <div class="card-body">
        <h5 class="card-title" style={{ textAlign: "center" }}>
          {productDetail.title}
        </h5>
        <p class="card-text">{productDetail.description}</p>
      </div>
      <ul class="list-group list-group-flush">
        <li class="list-group-item">
          <strong>Price: </strong> {productDetail.price} £{" "}
        </li>
        <li class="list-group-item">
          <strong>Category: </strong>
          {productDetail.category}
        </li>
        <li class="list-group-item">
          <strong>Brand: </strong>
          {productDetail.brand}
        </li>
        <li class="list-group-item">
          <strong>Rating:</strong> 5/{productDetail.rating}
        </li>
        <li class="list-group-item">
          <strong>Stock: </strong> {productDetail.stock}
        </li>
      </ul>
      <div class="card-body" style={{ textAlign: "center" }}>
        <Link to={"/products/"} class="btn btn-violet mb-3" style={{ backgroundColor: "purple", color: "white" }}> Products </Link>
      </div>
    </div>
  );
}
