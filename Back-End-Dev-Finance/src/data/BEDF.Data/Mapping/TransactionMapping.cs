using BEDF.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BEDF.Data.Mapping
{
    class TransactionMapping : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Transaction");

            builder.Property(x => x.Description)
                .HasColumnType("nvarchar(250)")
                .IsRequired(true);


            builder.Property(x => x.Amount)
                .HasColumnType("money")
                .IsRequired(true);


            builder.Property(x => x.Date)
                .HasColumnType("datetime")
                .IsRequired(true);


            builder.Ignore(x => x.ErrorMessages);
            builder.Ignore(x => x.ValidationResult);



        }
    }
}
