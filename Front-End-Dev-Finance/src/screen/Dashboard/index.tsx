import React, { useState } from "react";
import Footer from "../../components/Footer";
import Header from "../../components/Header";
import Modal from "../../components/Modal";
import Main, { ITransaction } from "../../components/Main";

const Dashboard: React.FC = () => {
  const [isOpen, setIsOpen] = useState(false);
  const [transactions, setTransactions] = useState<ITransaction[]>([
    {
      id: 1,
      description: "Luz",
      amount: -500,
      date: "23/01/2021",
    },
    {
      id: 2,
      description: "Criar Web Site",
      amount: 5000,
      date: "23/01/2021",
    },
    {
      id: 3,
      description: "Internet",
      amount: -200,
      date: "23/01/2021",
    },
  ]);
  const values = { income: 5000.25, expense: 2000, total: 3000 };
  function openCloseModal() {
    setIsOpen(!isOpen);
  }
  return (
    <div>
      <Header />
      <Main
        openCloseModal={openCloseModal}
        transactions={transactions}
        transactionValues={values}
      />
      <Modal openCloseModal={openCloseModal} isOpen={isOpen} />
      <Footer />
    </div>
  );
};

export default Dashboard;
