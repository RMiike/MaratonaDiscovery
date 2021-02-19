using BEDF.Domain.Base;
using FluentValidation;
using System;

namespace BEDF.Domain.Entity
{
    public class Transaction : BaseEntity
    {
        public Transaction(string description, float amount, DateTime date)
        {
            Description = description;
            Amount = amount;
            Date = date;
        }

        public string Description { get; private set; }
        public float Amount { get; private set; }
        public DateTime Date { get; private set; }
        public override bool IsValid()
        {
            ValidationResult = new ValidateTransaction().Validate(this);
            return ValidationResult.IsValid;
        }
        public class ValidateTransaction : AbstractValidator<Transaction>
        {
            public ValidateTransaction()
            {
                RuleFor(x => x.Amount)
                    .NotEmpty().WithMessage("Preencha o montante.");
                RuleFor(x => x.Description)
                   .NotEmpty().WithMessage("Preencha o campo de descrição da transação")
                   .MaximumLength(250).WithMessage("O campo possui mais de 250 caracteres");
                RuleFor(x => x.Date)
                    .NotEmpty().WithMessage("Preencha o campo data.");
            }
        }
    }
}
