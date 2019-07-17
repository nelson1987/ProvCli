using Microsoft.Extensions.DependencyInjection;
using ProvCli.Application.Contracts.Services;
using ProvCli.Application.Services;

namespace ProvCli.CrossCutting.IoC
{
    public static class Bootstrapper
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IFornecedorAppService, FornecedorAppService>();
        }
    }
}
