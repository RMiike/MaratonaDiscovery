using BEDF.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BEDF.Data.Context
{
    public class DevFinanceContext : DbContext
    {
        public DevFinanceContext(DbContextOptions<DevFinanceContext> opt) : base(opt) { }

        public DbSet<Transaction> Transactions { get; set; }
        protected override void OnModelCreating(ModelBuilder model)
        {
            foreach (var property in model.Model.GetEntityTypes().SelectMany(
               e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            model.ApplyConfigurationsFromAssembly(typeof(DevFinanceContext).Assembly);
        }
        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }

    }
}
