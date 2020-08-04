using System;
using Dotnet5.GraphQL.Store.Domain.Entities;
using Dotnet5.GraphQL.Store.Domain.Entities.Products;
using Dotnet5.GraphQL.Store.Services;
using Dotnet5.GraphQL.Store.WebAPI.GraphQL.Types.Reviews;
using GraphQL.DataLoader;
using GraphQL.Types;

namespace Dotnet5.GraphQL.Store.WebAPI.GraphQL.Types.Products.Backpacks
{
    public class BackpackGraphType : ObjectGraphType<Backpack>
    {
        public BackpackGraphType(IReviewService reviewService, IDataLoaderContextAccessor dataLoaderContextAccessor)
        {
            Name = "Backpack";

            Field(x => x.BackpackType, type: typeof(BackpakcTypeEnumGraphType));

            Field(x => x.Id, type: typeof(GuidGraphType));
            Field(x => x.Description);
            Field(x => x.IntroduceAt);
            Field(x => x.Name).Description("The name of the product.");
            Field(x => x.PhotoUrl);
            Field(x => x.Price);
            Field(x => x.ProductType, type: typeof(ProductTypeGraphType));
            Field(x => x.Rating);
            Field(x => x.Stock);
            Field<ProductOptionEnumGraphType>("Option");

            FieldAsync<ListGraphType<ReviewGraphType>>("reviews",
                resolve: async context
                    => await dataLoaderContextAccessor.Context
                       .GetOrAddCollectionBatchLoader<Guid, Review>("GetReviewsByProductId", reviewService.GetForProductsAsync)
                       .LoadAsync(context.Source.Id));

            Interface<ProductInterfaceGraphType>();
            IsTypeOf = o => o is Product;
        }
    }
}