using ProvCli.Application.Contracts.Services;
using ProvCli.Domain.Command;
using ProvCli.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ProvCli.Application.Services
{
    public class FornecedorAppService : IFornecedorAppService
    {
        public void Adicionar(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        public List<Fornecedor> Listar()
        {
            ICommandHandler<CriacaoFornecedorCommand> comando;
            throw new NotImplementedException();
        }
    }
}
