﻿using Domain.Repositories;
using Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Data
{
    public static class InfraDataServicesExtensions
    {
        public static IServiceCollection AddInfraDataServices(this IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IProdutosRepository, ProdutosRepository>();
            return services;
        }
    }
}