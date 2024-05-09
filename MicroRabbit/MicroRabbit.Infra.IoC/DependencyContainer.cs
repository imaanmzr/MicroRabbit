using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            //Domain Bus Services
            services.AddTransient<IEventBus,RabbitMQBus>();

            //Application Services
            services.AddTransient<IAccountService, AccountService>();

            //Data Services
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();

            return services;
        }
    }
}
