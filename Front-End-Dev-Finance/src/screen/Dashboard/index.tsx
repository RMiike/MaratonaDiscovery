import React, { useEffect, useState, useCallback } from "react";
import Footer from "../../components/Footer";
import Header from "../../components/Header";
import Modal from "../../components/Modal";
import Main, { ITransaction, ITransactionValues } from "../../components/Main";
import api from "../../services/api";
import { IncomingMessage } from "http";

const Dashboard: React.FC = () => {
  const [isOpen, setIsOpen] = useState(false);
  const [transactions, setTransactions] = useState<ITransaction[]>([]);
  const [values, setValues] = useState<ITransactionValues>(
    {} as ITransactionValues
  );

  const handleGetTransaction = useCallback(async () => {
    let response = await api.get("devfinance/transaction");
    setTransactions(response.data);
  }, []);

  useEffect(() => {
    handleGetTransaction();
  }, [handleGetTransaction]);

  useEffect(() => {
    let income = 0;
    let expense = 0;
    transactions.map((x) => {
      if (x.amount > 0) {
        income += x.amount;
      } else {
        expense += x.amount;
      }
    });
    let total = income + expense;
    setValues({ income, expense, total });
  }, [transactions]);
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
