import React from "react";
import { Button, Menu } from "semantic-ui-react";

export default function SignedOut({ signIn }) {
  return (
    <div>
      <Menu.Item>
        <Button onClick={signIn} color="violet">
          Giriş Yap
        </Button>
        <Button color="violet" style={{ marginLeft: "0.5em" }}>
          Kayıt Ol
        </Button>
      </Menu.Item>
    </div>
  );
}
