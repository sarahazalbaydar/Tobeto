import React, { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import { Button, Card } from "semantic-ui-react";
import ProductService from "../services/productsService";

export default function ProductDetail() {
  let { id } = useParams(); //useParams: parametreleri obje olarak verir. burada id parametresi route'tan gelen id parametresidir
  //parametreler obje olarak geldiği için destructure işlemi yaptık ve route'taki id'yi okuduk

  const [product, setProduct] = useState({}); //ilk değeri array değil bir objedir

  useEffect(() => {
    let productService = new ProductService();

    productService.getById(id).then((result) => setProduct(result.data.data));
  }, []);

  return (
    <div>
      <Card.Group>
        <Card fluid>
          <Card.Content>
            <Card.Header>{product.productName}</Card.Header>
            <Card.Meta>Stock: {product.unitsInStock}</Card.Meta>
            <Card.Description>
              Price: <strong>{product.unitPrice}</strong>
            </Card.Description>
          </Card.Content>
          <Card.Content extra>
            <div className="ui two buttons">
              <Button basic color="green">
                Approve
              </Button>
              <Button basic color="red">
                Decline
              </Button>
            </div>
          </Card.Content>
        </Card>
      </Card.Group>{" "}
    </div>
  );
}
