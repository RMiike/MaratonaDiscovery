using System;

namespace BEDF.Domain.Models
{
    public class TransactionModel
    {
        public TransactionModel(Guid id, string description, float amount, DateTime date)
        {
            Id = id;
            Description = description;
            Amount = amount;
            Date = date;
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public float Amount { get; set; }
        public DateTime Date { get; set; }
    }
    public class CreateTransactionModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public float Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
