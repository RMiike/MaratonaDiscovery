using BEDF.Domain.Entity;
using BEDF.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace BEDF.Domain.MappingEntity
{
    public static class TransactionMapping
    {
        public static Transaction ConvertToEntity(this CreateTransactionModel model)
        {
            return new Transaction(model.Description, model.Amount, model.Date);
        }
        public static TransactionModel ConvertToModel(this Transaction transaction)
        {
            return new TransactionModel(transaction.Id, transaction.Description, transaction.Amount, transaction.Date);
        }
        public static IEnumerable<TransactionModel> ConverterParaViewModel(this IEnumerable<Transaction> transactions)
        {
            return new List<TransactionModel>(transactions.Select(c => new TransactionModel(c.Id, c.Description, c.Amount, c.Date)));
        }
    }
}
