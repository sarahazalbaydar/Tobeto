import React, { useState, useEffect } from "react";
import { Icon, Label, Menu, Table } from "semantic-ui-react";
import ProductService from "../services/productsService";
import { Link } from "react-router-dom";

export default function ProductList() {
  //ürünler, bu sayfanın statedata'sıdır

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

  return (
    <div>
      <Table celled>
        <Table.Header>
          <Table.Row>
            <Table.HeaderCell>Ürün Adı</Table.HeaderCell>
            <Table.HeaderCell>Birim Fiyatı</Table.HeaderCell>
            <Table.HeaderCell>Stok Adedi</Table.HeaderCell>
          </Table.Row>
        </Table.Header>

        <Table.Body>
          {products.map((products) => (
            <Table.Row key={products.productId}>
              <Table.Cell>
                <Link to={`/products/${products.productId}`}>
                  {products.productName}
                </Link>{" "}
              </Table.Cell>
              <Table.Cell>{products.unitsInStock}</Table.Cell>
              <Table.Cell>{products.unitPrice}</Table.Cell>
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
