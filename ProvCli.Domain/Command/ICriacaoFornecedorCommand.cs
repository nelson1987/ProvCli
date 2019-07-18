namespace ProvCli.Domain.Command
{
    public interface ICommand { }
    public interface ICommandResult { }
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        ICommandResult Execute(TCommand command);
    }
    public interface ICriacaoFornecedorCommand : ICommand
    {
    }
}
