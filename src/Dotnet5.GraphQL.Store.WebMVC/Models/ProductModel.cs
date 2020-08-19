using System;
using System.Collections.Generic;
using Dotnet5.GraphQL.Store.Domain.Enumerations;
using Dotnet5.GraphQL.Store.Domain.ValueObjects.ProductTypes;

namespace Dotnet5.GraphQL.Store.WebMVC.Models
{
    public class ProductModel
    {
        public string Description { get; set; }
        public Guid Id { get; set; }
        public DateTimeOffset IntroduceAt { get; set; }
        public string Name { get; set; }
        public Option Option { get; set; }
        public string PhotoUrl { get; set; }
        public decimal Price { get; set; }
        public ProductType ProductType { get; set; }
        public int Rating { get; set; }
        public int Stock { get; set; }
        public IEnumerable<ReviewModel> Reviews { get; set; }
    }
}