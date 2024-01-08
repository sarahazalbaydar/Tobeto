import { useField } from "formik";
import React from "react";
import { FormField, Label } from "semantic-ui-react";

export default function TobetoTextInput({ ...props }) {
  //spread operatörü ile({...props}) gelecek değerler kullanılabilir halde geldi
  //çünkü kaç değer girileceği değişebilir
  //console.log(props);
  const [field, meta] = useField(props);
  //useField -> ilgili input elemanı ile ilgili bilgi toplamayı sağlar
  //props ile gelen field için bilgi toplar(reflect api kullanarak)
  //meta: hata olup olmadığı bilgisini verir(isTouched bilgisini de verir)
  //console.log(meta);
  return (
    <FormField error={meta.touched && !!meta.error}>
      {
        //hata varsa ve touched ise hata mesajı gönder. !! -> metin varsa boolean yap demektir
      }
      {meta.touched && !!meta.error ? (
        <Label pointing basic color="red" content={meta.error}></Label>
      ) : null}
      <input {...field} {...props} />
    </FormField>
  );
}
