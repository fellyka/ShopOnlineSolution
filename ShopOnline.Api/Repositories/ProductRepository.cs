using Microsoft.EntityFrameworkCore;

using ShopOnline.Api.Data;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories.Contracts;

namespace ShopOnline.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopOnlineDBContext shopOnlineDBContext;

        public ProductRepository(ShopOnlineDBContext shopOnlineDBContext)
        {
            this.shopOnlineDBContext = shopOnlineDBContext;
        }


        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            List<ProductCategory> productCategory = await this.shopOnlineDBContext.ProductCategories.ToListAsync();
            return productCategory;
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            List<Product> product = await this.shopOnlineDBContext.Products.ToListAsync();
            return product;
        }
    }
}
