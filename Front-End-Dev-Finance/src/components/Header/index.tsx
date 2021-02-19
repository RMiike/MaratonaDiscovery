import React from "react";
import logo from "../../assets/imgs/logo.svg";

const Header: React.FC = () => {
  return (
    <header>
      <img src={logo} alt="Logo Dev Finance" />
    </header>
  );
};

export default Header;
