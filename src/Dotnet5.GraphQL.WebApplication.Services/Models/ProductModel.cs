using System;
using Dotnet5.GraphQL.WebApplication.Domain.ValueObjects.ProductTypes;
using Dotnet5.GraphQL.WebApplication.Services.Abstractions;

namespace Dotnet5.GraphQL.WebApplication.Services.Models
{
    public class ProductModel : Model<Guid>
    {
        public string Description { get; set; }
        public DateTimeOffset IntroduceAt { get; set; }
        public string Name { get; set; }
        public string PhotoFileName { get; set; }
        public decimal Price { get; set; }
        public ProductType ProductType { get; set; }
        public int Rating { get; set; }
        public int Stock { get; set; }
    }
}