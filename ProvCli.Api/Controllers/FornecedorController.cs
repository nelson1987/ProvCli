using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProvCli.Api.Contracts.Models;
using ProvCli.Domain.Command;
using System;

namespace ProvCli.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Create(
            [FromBody] CriacaoFornecedorModel modelo,
            [FromServices] ICommandHandler<CriacaoFornecedorCommand> servico)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                var commando = Mapper.Map<CriacaoFornecedorCommand>(modelo);
                //commando.Execute()
                return Ok("Criado com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}