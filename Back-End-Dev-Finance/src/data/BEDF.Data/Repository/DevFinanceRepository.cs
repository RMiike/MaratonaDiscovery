using BEDF.Data.Context;
using BEDF.Domain.Entity;
using BEDF.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEDF.Data.Repository
{
    public class DevFinanceRepository : ITransactionRepository
    {
        private readonly DevFinanceContext _context;
        public DevFinanceRepository(DevFinanceContext context)
        {
            _context = context;
        }
        public async Task<Transaction> Adicionar(Transaction transaction)
        {
            var resultado = await _context.Transactions.AddAsync(transaction);
            await _context.Commit();
            return resultado.Entity;
        }

        public async Task<Transaction> Deletar(Transaction transaction)
        {
            _context.Transactions.Remove(transaction);
            await _context.Commit();
            return transaction;
        }


        public async Task<Transaction> ObterPorId(Guid id)
        {
            return await _context.Transactions.Where(p => p.Id == id)
                                          .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Transaction>> ObterTodos()
        {
            var resultado = await _context.Transactions.AsNoTracking().ToListAsync();
            return resultado;
        }
        public void Dispose()
        {
            _context?.Dispose();
        }

    }
}
