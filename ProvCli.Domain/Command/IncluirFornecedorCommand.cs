using ProvCli.Domain.Entities;

namespace ProvCli.Domain.Command
{
    public class CriacaoFornecedorCommand : ICriacaoFornecedorCommand
    {
        public string RazaoSocial { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }

        public void Execute(CriacaoFornecedorCommand command)
        {
            throw new System.NotImplementedException();
        }
        //public void Execute(CriacaoFornecedorCommand command)
        //{
        //    var fornecedor = new Fornecedor()
        //}
    }
    public class CriacaoFornecedorHandler
               : ICommandHandler<CriacaoFornecedorCommand>
    {
         public ICommandResult Execute(CriacaoFornecedorCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}
