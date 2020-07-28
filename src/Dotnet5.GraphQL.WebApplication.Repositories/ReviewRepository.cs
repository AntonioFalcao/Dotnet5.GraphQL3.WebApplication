using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotnet5.GraphQL.WebApplication.Domain.Entities;
using Dotnet5.GraphQL.WebApplication.Repositories.Abstractions;
using Dotnet5.GraphQL.WebApplication.Repositories.Contexts;

namespace Dotnet5.GraphQL.WebApplication.Repositories
{
    public class ReviewRepository : Repository<Review, Guid>, IReviewRepository
    {
        public ReviewRepository(StoreContext dbContext)
            : base(dbContext) { }

        public async Task<ILookup<Guid, Review>> GetForProducts(IEnumerable<Guid> productIds)
        {
            var reviews = await base.GetAllAsync(x => productIds.Contains(x.Product.Id));
            return reviews.ToLookup(x => x.Product.Id);
        }
    }
}