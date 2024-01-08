import { Field, Form, Formik, ErrorMessage } from "formik";
import React from "react";
import * as Yup from "yup";
import { Button, FormField, Label } from "semantic-ui-react";
import TobetoTextInput from "../utilities/customFormControls/TobetoTextInput";

export default function ProductAdd() {
  const initialValues = { productName: "", unitPrice: 10 };

  const schema = Yup.object({
    //obje formatında ilişkilendirilen şeyleri ister
    productName: Yup.string().required("Ürün adı zorunlu"),
    //metinsel girilecek ve değer girmek zorunlu olacak
    unitPrice: Yup.number().required("Ürünün fiyatı zorunludur"),
  });
  return (
    <div>
      {
        //bir formik açtığımızda default değerlere ihtiyaç duyar
        //obje formatında initalValues ister
        //doğrulama şeması(validationSchema) ister: doğrulama yapmamızı sağlara
        //formik'te name önemlidir
      }
      <Formik
        initialValues={initialValues}
        validationSchema={schema}
        onSubmit={(values) => {
          console.log(values);
          //burada axios'u çağırdığımızda ürünü backend'e göndermiş de olacağız
        }}
      >
        <Form className="ui form">
          <TobetoTextInput name="productName" placeholder="Ürün adı" />
          <TobetoTextInput name="unitPrice" placeholder="Ürün fiyatı" />
          <Button color="green" type="submit">
            Ekle
          </Button>
        </Form>
      </Formik>
    </div>
  );
}
