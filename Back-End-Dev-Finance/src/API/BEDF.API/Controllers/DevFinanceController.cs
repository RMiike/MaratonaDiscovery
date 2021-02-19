using BEDF.Domain.Interfaces;
using BEDF.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BEDF.API.Controllers
{
    public class DevFinanceController : BaseController
    {
        private readonly ITransactionService _transactionService;
        public DevFinanceController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }
        [HttpPost("transaction")]
        public async Task<IActionResult> Adicionar([FromBody] CreateTransactionModel createTransactionModel)
            => CustomResponse(await _transactionService.Adicionar(createTransactionModel));
        [HttpGet("transaction")]
        public async Task<IActionResult> ObterTodos()
           => CustomResponse(await _transactionService.ObterTodos());

        [HttpDelete("transaction/{id}")]
        public async Task<IActionResult> Deletar([FromRoute] Guid id)
          => CustomResponse(await _transactionService.Deletar(id));
    }
}
