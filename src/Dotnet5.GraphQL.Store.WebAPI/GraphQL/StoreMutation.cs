using Dotnet5.GraphQL.Store.Services;
using Dotnet5.GraphQL.Store.Services.Models;
using Dotnet5.GraphQL.Store.WebAPI.GraphQL.Types.Reviews;
using GraphQL.Types;

namespace Dotnet5.GraphQL.Store.WebAPI.GraphQL
{
    public class StoreMutation : ObjectGraphType
    {
        public StoreMutation(IReviewService service)
        {
            FieldAsync<ReviewGraphType>("createReview",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<ReviewInputGraphType>> {Name = "review"}),
                resolve: async context =>
                {
                    var review = context.GetArgument<ReviewModel>("review");
                    return await context.TryAsyncResolve(async fieldContext
                        => await service.SaveAsync(review, context.CancellationToken));
                });
        }
    }
}