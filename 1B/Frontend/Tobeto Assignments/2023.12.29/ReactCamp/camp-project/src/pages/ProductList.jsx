import React, { useState, useEffect } from "react";
import { Button, Icon, Menu, Table } from "semantic-ui-react";
import ProductService from "../services/productsService";
import { Link } from "react-router-dom";
import { useDispatch } from "react-redux";
import { addToCart } from "../store/actions/cartActions";
import { toast } from "react-toastify";

export default function ProductList() {
  //ürünler, bu sayfanın statedata'sıdır

  const dispatch = useDispatch();
  //DISPATCH; aksiyonları(fonksiyonları) çağırmak için kullanılır. Dispatch, fonks'un aksiyonun ismini ister.
  //fonksiyonu çağırmasını istediğimiz yerde oluşturduğumuz butona tıkladığımızda ADD_TO_CART aksiyonunu çağıracak

  //useState bize bir object döndürecek ve bunu destruct edeceğiz
  const [products, setProducts] = useState([]);
  //default değeri boşbirarray olan products data'mız var ve bu products'ı değiştirmek için de
  //setProducts'ı kullanıyoruz. Buna react hook ifadesini kullanıyoruz

  //useEffect bir fonks'dur.
  useEffect(() => {
    //component yüklendiğinde yapılmasını istediğimiz kodu bu blokta(useEffect bloğunda) yazarız.
    //yani bu blok içerisinde çalışan kod, sayfa yüklendiğinde çalışan koddur
    let productService = new ProductService();

    //products'ı set etmemiz gerekir
    productService
      .getProducts()
      .then((result) => setProducts(result.data.data));
    //productService'deki getProducts'ı çalıştır, bu bize bir PROMISE döndürür
    //başarılı olursa; then ile gelecek result(sonuç) için result.data'daki data'yı set et (setProducts, parametre ol. aldığını
    //products'a eşitler)
    //axios result'da data dışında şeyler de(success=true gibi) döndürür, axios bunu bize data olarak döndürür
    //fakat bize bunun sadece data'sı lazım old. için result.data.data şeklinde döndürdük
    //başarısız olursa da durumu catch ile ele alabiliriz(try-catch gibi)
  }, []); //boş array ele almamız lazım yoksa çalışır fakat network'e sürekli istekte bulunur
  //hook'lar ile çalışırken yapılan değişiklikleri sürekli takip etmesini istediğimiz state'leri bu boş array içerisine ekleyeceğiz

  const handleAddToCart = (product) => {
    dispatch(addToCart(product));
    toast.success(`${product.productName} sepete eklendi!`);
  };

  return (
    <div>
      <Table celled>
        <Table.Header>
          <Table.Row>
            <Table.HeaderCell>Ürün Adı</Table.HeaderCell>
            <Table.HeaderCell>Birim Fiyatı</Table.HeaderCell>
            <Table.HeaderCell>Stok Adedi</Table.HeaderCell>
            <Table.HeaderCell></Table.HeaderCell>
          </Table.Row>
        </Table.Header>

        <Table.Body>
          {products.map((product) => (
            <Table.Row key={product.productId}>
              <Table.Cell>
                <Link to={`/products/${product.productId}`}>
                  {product.productName}
                </Link>{" "}
              </Table.Cell>
              <Table.Cell>{product.unitsInStock}</Table.Cell>
              <Table.Cell>{product.unitPrice}</Table.Cell>
              <Table.Cell>
                <Button onClick={() => handleAddToCart(product)}>
                  Sepete Ekle
                </Button>
              </Table.Cell>
            </Table.Row>
          ))}
        </Table.Body>

        <Table.Footer>
          <Table.Row>
            <Table.HeaderCell colSpan="3">
              <Menu floated="right" pagination>
                <Menu.Item as="a" icon>
                  <Icon name="chevron left" />
                </Menu.Item>
                <Menu.Item as="a">1</Menu.Item>
                <Menu.Item as="a">2</Menu.Item>
                <Menu.Item as="a">3</Menu.Item>
                <Menu.Item as="a">4</Menu.Item>
                <Menu.Item as="a" icon>
                  <Icon name="chevron right" />
                </Menu.Item>
              </Menu>
            </Table.HeaderCell>
          </Table.Row>
        </Table.Footer>
      </Table>
    </div>
  );
}
