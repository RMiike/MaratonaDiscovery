using BEDF.Domain.Entity;
using BEDF.Domain.Interfaces;
using BEDF.Domain.MappingEntity;
using BEDF.Domain.Models;
using System;
using System.Threading.Tasks;

namespace BEDF.Services.MainServices
{
    public class DevFinanceService : ITransactionService
    {
        private readonly ITransactionRepository _repository;
        public DevFinanceService(ITransactionRepository repository)
        {
            _repository = repository;
        }
        public async Task<CustomizedResult> Adicionar(CreateTransactionModel model)
        {
            var transaction = model.ConvertToEntity();

            if (!transaction.IsValid())
            {
                var result = new CustomizedResult("Found an error", transaction);
                result.AdicionarMensagensDeErro(transaction.ErrorMessages);
                return result;
            };
            var addedTransaction = await _repository.Adicionar(transaction);
            var successResult = new CustomizedResult("Transaction added", addedTransaction.ConvertToModel());

            return successResult;
        }
        public async Task<CustomizedResult> Deletar(Guid id)
        {
            var transaction = await _repository.ObterPorId(id);


            if (transaction == null)
            {
                var result = new CustomizedResult("Invalid id", transaction);
                result.AdicionarMensagensDeErro(unicError: "Invalid id");
                return result;
            }

            await _repository.Deletar(transaction);
            var resultS = new CustomizedResult("Successfully deleted", transaction);

            return resultS;
        }
        public Task<CustomizedResult> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }
        public async Task<CustomizedResult> ObterTodos()
        {
            var transactions = await _repository.ObterTodos();
            if (transactions == null)
            {
                var result = new CustomizedResult("Please, register a transaction", transactions);
                result.AdicionarMensagensDeErro(unicError: "0 transaction founded");
                return result;
            }

            foreach (var transaction in transactions)
            {
                if (!transaction.IsValid())
                {
                    var result = new CustomizedResult("Found an error", transaction.ValidationResult);
                    result.AdicionarMensagensDeErro(transaction.ErrorMessages);
                    return result;
                }
            }
            var models = transactions.ConverterParaViewModel();
            var resultSucess = new CustomizedResult("Found an error", models);
            return resultSucess;
        }
    }
}