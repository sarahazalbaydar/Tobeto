import React from "react";
import { Dropdown, Menu, Image } from "semantic-ui-react";

export default function SignedIn({ signOut }) {
  return (
    <div>
      <Menu.Item>
        <Image
          avatar
          spaced="right"
          src="https://media.licdn.com/dms/image/D4D03AQGczCARrT-8dw/profile-displayphoto-shrink_800_800/0/1700672757514?e=1709164800&v=beta&t=mvuNGIFt2UcKLcfX6I8PiWC4Fz3wCykH-t7c6QeLDAw"
        />
        <Dropdown pointing="top left" text="Şara Hazal">
          <Dropdown.Menu>
            <Dropdown.Item text="Bilgilerim" icon="info" />
            <Dropdown.Item onClick={signOut} text="Çıkış Yap" icon="sign-out" />
          </Dropdown.Menu>
        </Dropdown>
      </Menu.Item>
    </div>
  );
}
