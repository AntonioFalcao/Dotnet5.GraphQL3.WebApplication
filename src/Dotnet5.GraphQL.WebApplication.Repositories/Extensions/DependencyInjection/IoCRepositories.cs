using System;
using Dotnet5.GraphQL.WebApplication.Repositories.Contexts;
using Dotnet5.GraphQL.WebApplication.Repositories.UnitsOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Dotnet5.GraphQL.WebApplication.Repositories.Extensions.DependencyInjection
{
    public static class IoCRepositories
    {
        private static readonly RepositoriesOptions Options = new RepositoriesOptions();

        public static IServiceCollection AddDbContext(this IServiceCollection services, Action<RepositoriesOptions> options)
        {
            options.Invoke(Options);
            return services.AddDbContext<StoreContext>(DbContextOptionsBuilderAction);
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
            => services.AddScoped<IProductRepository, ProductRepository>();

        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
            => services.AddScoped<IUnitOfWork, UnitOfWork>();

        private static void DbContextOptionsBuilderAction(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
               .UseSqlServer(Options.ConnectionString, SqlServerOptionsAction)
               .EnableDetailedErrors()
               .EnableSensitiveDataLogging();

        private static void SqlServerOptionsAction(SqlServerDbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
               .EnableRetryOnFailure(5, TimeSpan.FromSeconds(5), null)
               .MigrationsAssembly(typeof(StoreContext).Assembly.GetName().Name);
    }

    public class RepositoriesOptions
    {
        public string ConnectionString { get; set; }
    }
}