using System;
using Dotnet5.GraphQL.Store.Domain.Enumerations;
using Dotnet5.GraphQL.Store.Domain.ValueObjects.ProductTypes;
using FluentValidation;

namespace Dotnet5.GraphQL.Store.Domain.Entities.Products.Kayaks
{
    public class Kayak : Product
    {
        internal Kayak(Guid id, string description, DateTimeOffset introduceAt, string name, string photoUrl, decimal price,
            ProductType productType, int rating, int stock, Option option, KayakType kayakType, int amountOfPerson)
            : base(id, description, introduceAt, name, photoUrl, price, productType, rating, stock, option)
        {
            KayakType = kayakType;
            AmountOfPerson = amountOfPerson;
            Validate();
        }

        protected Kayak() { }

        public int AmountOfPerson { get; }
        public KayakType KayakType { get; }

        protected sealed override bool Validate()
            => OnValidate(this, new InlineValidator<Kayak>());
    }
}