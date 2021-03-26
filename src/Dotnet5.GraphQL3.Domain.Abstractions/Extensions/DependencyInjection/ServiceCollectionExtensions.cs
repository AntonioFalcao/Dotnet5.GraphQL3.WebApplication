﻿using Dotnet5.GraphQL4.CrossCutting;
using Dotnet5.GraphQL3.Domain.Abstractions.Builders;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;

namespace Dotnet5.GraphQL3.Domain.Abstractions.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBuilders(this IServiceCollection services)
            => services
                .Scan(selector => selector.FromAssemblies(Application.Assemblies)
                    .AddClasses(filter => filter.AssignableTo(typeof(IBuilder<,>)))
                    .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                    .AsImplementedInterfaces()
                    .WithScopedLifetime());
    }
}