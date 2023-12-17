using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MoneyTransfer.Data.Contexts;
using System.Reflection;

namespace MoneyTransfer.Data
{
    public static class ServiceRegistrations
    {
        public static void AddDataServices(this IServiceCollection services)
        {
            services.AddDbContext<MoneyTransferAPIDbContext>(options => options.UseSqlServer(Configuration.SQLConnectionString));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(MoneyTransferAPIDbContext).GetTypeInfo().Assembly));
        }
    }
}
