using System;
using Dotnet5.GraphQL.WebApplication.Domain.Abstractions;
using Dotnet5.GraphQL.WebApplication.Domain.Enumerations;
using FluentValidation;

namespace Dotnet5.GraphQL.WebApplication.Domain.Entities
{
    public class Product : Entity<Guid>
    {
        public Product(string description, DateTimeOffset introduceAt, string name, string photoFileName, decimal price, ProductType productType,
            int rating, int stock)
        {
            Description = description;
            IntroduceAt = introduceAt;
            Name = name;
            PhotoFileName = photoFileName;
            Price = price;
            ProductType = productType;
            Rating = rating;
            Stock = stock;

            Validate(this, new InlineValidator<Product>());
        }

        public string Description { get; }
        public DateTimeOffset IntroduceAt { get; }
        public string Name { get; }
        public string PhotoFileName { get; }
        public decimal Price { get; }
        public ProductType ProductType { get; }
        public int Rating { get; }
        public int Stock { get; }
    }
}