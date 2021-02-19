using BEDF.Domain.Entity;
using System;
using System.Threading.Tasks;

namespace BEDF.Domain.Interfaces
{
    public interface IGenericService<T> where T : class
    {
        Task<CustomizedResult> ObterTodos();
        Task<CustomizedResult> ObterPorId(Guid id);
        Task<CustomizedResult> Adicionar(T transaction);
        Task<CustomizedResult> Deletar(Guid id);
    }
}
