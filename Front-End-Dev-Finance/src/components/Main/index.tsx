import React from "react";
import { toBRLString } from "../../Utils";
import income from "../../assets/imgs/income.svg";
import expense from "../../assets/imgs/expense.svg";
import total from "../../assets/imgs/total.svg";
import minus from "../../assets/imgs/minus.svg";
import api from "../../services/api";

interface IModalButton {
  openCloseModal(): void;
  transactions: Array<ITransaction>;
  transactionValues: ITransactionValues;
}
export interface ITransaction {
  id: string;
  description: string;
  amount: number;
  date: string;
}
export interface ITransactionValues {
  income: number;
  expense: number;
  total: number;
}
const Main: React.FC<IModalButton> = ({
  openCloseModal,
  transactions,
  transactionValues,
}) => {
  async function handleRemove(id: string) {
    try {
      await api.delete(`devfinance/transaction/${id}`);
    } catch (error) {
      console.log(error);
    }
  }
  return (
    <main className="container">
      <section id="balance">
        <h2 className="sr-only">Balanço</h2>
        <div className="card">
          <h3>
            <span>Entradas</span>
            <img src={income} alt="Imagem de entradas" />
          </h3>
          <p>{toBRLString(transactionValues.income)}</p>
        </div>
        <div className="card">
          <h3>
            <span>Saídas</span>
            <img src={expense} alt="Imagem de saídas" />
          </h3>
          <p>{toBRLString(transactionValues.expense)}</p>
        </div>
        <div className="card total">
          <h3>
            <span>Total</span>
            <img src={total} alt="Imagem de total" />
          </h3>
          <p>{toBRLString(transactionValues.total)}</p>
        </div>
      </section>
      <section id="transaction">
        <h2 className="sr-only">Transações</h2>
        <button className="button new" onClick={openCloseModal}>
          + Nova Transação
        </button>
        <table id="data-table">
          <thead>
            <tr>
              <th className="description">Descrição</th>
              <th>Valor</th>
              <th>Data</th>
              <th></th>
            </tr>
          </thead>
          <tbody>
            {transactions.map((transaction) => {
              const isIncomeOrExpense =
                transaction.amount > 0 ? "income" : "expense";

              return (
                <tr key={transaction.id}>
                  <td className="description">{transaction.description}</td>
                  <td className={`${isIncomeOrExpense}`}>
                    {toBRLString(transaction.amount)}
                  </td>
                  <td className="date">{transaction.date.slice(0, 10)}</td>
                  <td>
                    <img
                      className="remove"
                      onClick={() => {
                        handleRemove(transaction.id);
                      }}
                      src={minus}
                      alt="Remover transação"
                    />
                  </td>
                </tr>
              );
            })}
          </tbody>
        </table>
      </section>
    </main>
  );
};

export default Main;
