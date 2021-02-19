using BEDF.Domain.Entity;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BEDF.API.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    [Produces("application/json")]
    public class BaseController : Controller
    {
        protected ICollection<string> Erros = new List<string>();

        protected ActionResult CustomResponse(object result = null)
        {
            if (OperacaoValida())
            {
                return Ok(result);
            }

            return BadRequest(new ValidationProblemDetails(new Dictionary<string, string[]>
            {
                { "Mensagens", Erros.ToArray() }
            }));
        }

        //protected ActionResult CustomResponse(ModelStateDictionary modelState)
        //{
        //    var erros = modelState.Values.SelectMany(e => e.Errors);
        //    foreach (var erro in erros)
        //    {
        //        AdicionarErroProcessamento(erro.ErrorMessage);
        //    }

        //    return CustomResponse();
        //}

        protected ActionResult CustomResponse(ValidationResult validationResult)
        {
            foreach (var erro in validationResult.Errors)
            {
                AdicionarErroProcessamento(erro.ErrorMessage);
            }

            return CustomResponse();
        }

        protected ActionResult CustomResponse(CustomizedResult resposta)
        {
            ResponsePossuiErros(resposta);

            return CustomResponse(resposta.Data);
        }

        protected bool ResponsePossuiErros(CustomizedResult resposta)
        {
            if (resposta == null || !resposta.Erros.Mensages.Any())
                return false;

            foreach (var mensagem in resposta.Erros.Mensages)
            {
                AdicionarErroProcessamento(mensagem);
            }

            return true;
        }

        protected bool OperacaoValida()
        {
            return !Erros.Any();
        }

        protected void AdicionarErroProcessamento(string erro)
        {
            Erros.Add(erro);
        }

        protected void LimparErrosProcessamento()
        {
            Erros.Clear();
        }
    }
}

