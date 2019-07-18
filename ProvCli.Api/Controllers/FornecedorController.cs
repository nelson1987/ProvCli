using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProvCli.Api.Contracts.Models;
using ProvCli.Application.Contracts.Services;
using ProvCli.Domain.Entities;

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
            [FromServices] IFornecedorAppService servico)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();
                servico.Adicionar(Mapper.Map<Fornecedor>(modelo));
                return Ok("Criado com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}