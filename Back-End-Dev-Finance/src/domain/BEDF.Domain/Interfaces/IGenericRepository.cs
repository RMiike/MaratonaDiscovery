using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BEDF.Domain.Interfaces
{
    public interface IGenericRepository<T> : IDisposable where T : class
    {
        Task<IEnumerable<T>> ObterTodos();
        Task<T> ObterPorId(Guid id);
        Task<T> Adicionar(T transaction);
        Task<T> Deletar(T transaction);
    }
}
