using ApiDotNet.Domain.Entities;

namespace ApiDotNet.Infra.Data.Repositories
{
    public interface IProductRepository
    {
        Task<Product> CreateAsync(Product product);
    }
}