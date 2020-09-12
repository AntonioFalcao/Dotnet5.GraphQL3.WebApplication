﻿using Dotnet5.GraphQL.Store.Repositories.Abstractions.UnitsOfWork;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;

namespace Dotnet5.GraphQL.Store.Repositories.Abstractions.DependencyInjection
{
    public static class ConfigureService
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
            => services.Scan(selector
                => selector
                    .FromApplicationDependencies()
                    .AddClasses(filter => filter.AssignableToAny(typeof(IRepository<,>)))
                    .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                    .AsImplementedInterfaces()
                    .WithScopedLifetime());

        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
            => services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}