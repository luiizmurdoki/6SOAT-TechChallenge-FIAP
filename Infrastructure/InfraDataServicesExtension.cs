using Domain.Interfaces;
using Infrastructure.Gateways;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class InfraDataServicesExtensions
    {
        public static IServiceCollection AddInfraDataServices(this IServiceCollection services)
        {
            services.AddScoped<IClienteGateway, ClienteGateway>();
            services.AddScoped<IPedidoGateway, PedidoGateway>();
            services.AddScoped<IProdutosGateway, ProdutosGateway>();
            return services;
        }
    }
}