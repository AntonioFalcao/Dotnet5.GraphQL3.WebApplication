using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Dotnet5.GraphQL.Store.Domain.Entities.Products;
using Dotnet5.GraphQL.Store.Domain.Entities.Reviews;
using Dotnet5.GraphQL.Store.Repositories;
using Dotnet5.GraphQL.Store.Repositories.UnitsOfWorks;
using Dotnet5.GraphQL.Store.Services.Abstractions;
using Dotnet5.GraphQL.Store.Services.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet5.GraphQL.Store.Services
{
    public class ProductService : Service<Product, ProductModel, Guid>, IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IProductRepository repository, IMapper mapper)
            : base(unitOfWork, repository, mapper)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Review> AddReviewAsync(ReviewModel reviewModel, CancellationToken cancellationToken = default)
        {
            if (reviewModel is null) return default;
            var product = await _repository.GetByIdAsync(reviewModel.ProductId, products => products.Include(x => x.Reviews), true,
                cancellationToken);
            
            if (product is null) return default;
            
            var review = _mapper.Map<Review>(reviewModel);
            product.AddReview(review);
            await _repository.UpdateAsync(product, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return review;
        }
    }
}