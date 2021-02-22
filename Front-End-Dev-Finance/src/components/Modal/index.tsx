import React, { useState } from "react";
import api from "../../services/api";

interface IModalButton {
  openCloseModal(): void;
  isOpen: boolean;
}
const Modal: React.FC<IModalButton> = ({ openCloseModal, isOpen }) => {
  const [description, setDescription] = useState("");
  const [amount, setAmount] = useState("");
  const [date, setDate] = useState("");

  async function handleSubmit(e: any) {
    e.preventDefault();
    try {
      let doubleAmount = parseFloat(amount);
      let data = {
        description,
        amount: doubleAmount,
        date,
      };
      await api.post("devfinance/transaction", data);
      openCloseModal();
    } catch (error) {
      console.log(error.message);
    }
  }
  return (
    <div className={`modal-overlay ${isOpen ? "active" : ""}`}>
      <div className="modal">
        <div className="form">
          <h2> Nova Transação</h2>
          <form action="">
            <div className="input-group">
              <label className="sr-only" htmlFor="description">
                Descrição
              </label>
              <input
                type="text"
                id="description"
                name="description"
                placeholder="Descrição"
                onChange={(e) => {
                  setDescription(e.target.value);
                }}
              />
            </div>
            <div className="input-group">
              <label className="sr-only" htmlFor="amount">
                Valor
              </label>
              <input
                type="number"
                id="amount"
                step="0.01"
                name="amount"
                placeholder="0,00"
                onChange={(e) => {
                  setAmount(e.target.value);
                }}
              />
              <small className="help">
                Use o sinal - (negativo) para despesas e , (vírgula para casas
                decimais)
              </small>
            </div>
            <div className="input-group">
              <label className="sr-only" htmlFor="date">
                Data
              </label>
              <input
                type="date"
                id="date"
                name="date"
                placeholder="01/01/2021"
                value={date}
                onChange={(e) => {
                  setDate(e.target.value);
                }}
              />
            </div>
            <div className="input-group actions">
              <a href="#" className="button cancel" onClick={openCloseModal}>
                Cancelar
              </a>
              <button onClick={(e: any) => handleSubmit(e)}>Salvar</button>
            </div>
          </form>
        </div>
      </div>
    </div>
  );
};

export default Modal;
