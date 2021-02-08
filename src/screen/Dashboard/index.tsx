import React from "react";

const Dashboard: React.FC = () => {
  return (
    <div>
      <header>
        <h1 id="logo">dev.finance$</h1>
      </header>
      <main className="container">
        <section id="balance">
          <h2>Balanço</h2>
          <div className="card">
            <h3>Entradas</h3>
            <p>R$ 5.000,00</p>
          </div>
          <div className="card">
            <h3>Saídas</h3>
            <p>R$ 2.000,00</p>
          </div>
          <div className="card total">
            <h3>Total</h3>
            <p>R$ 3.000,00</p>
          </div>
        </section>
        <section id="transaction">
          <h2>Transações</h2>
          <table id="data-table">
            <thead>
              <tr>
                <th className="description">Descrição</th>
                <th>Valor</th>
                <th>Data</th>
              </tr>
            </thead>
            <tbody>
              <tr>
                <td className="description">Luz</td>
                <td className="expense">-R$ 500,00</td>
                <td className="date">23/02/2021</td>
              </tr>
              <tr>
                <td className="description">Criar Web Site</td>
                <td className="income">R$ 5000,00</td>
                <td className="date">23/02/2021</td>
              </tr>
              <tr>
                <td className="description">Internet</td>
                <td className="expense">-R$ 200,00</td>
                <td className="date">23/02/2021</td>
              </tr>
            </tbody>
          </table>
        </section>
      </main>
      <footer>
        <p>dev.finance$</p>
      </footer>
    </div>
  );
};

export default Dashboard;
