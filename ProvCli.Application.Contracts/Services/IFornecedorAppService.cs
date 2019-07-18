using ProvCli.Domain.Entities;
using System.Collections.Generic;

namespace ProvCli.Application.Contracts.Services
{
    public interface IFornecedorAppService
    {
        void Adicionar(Fornecedor fornecedor);
        List<Fornecedor> Listar();
    }
}
