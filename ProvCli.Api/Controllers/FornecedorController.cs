using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProvCli.Api.Contracts.Models;
using ProvCli.Application.Contracts.Services;

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
        public IActionResult Create([FromServices] IFornecedorAppService servico)
        {
            try
            {
                
                return Ok("Criado com sucesso");
            }
            catch (Exception ex)
            {
                return  BadRequest(ex);
            }
        }
    }
}