using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;
using System.Net.Http.Json;

namespace ShopOnline.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;  
        }

        public async Task<IEnumerable<ProductDto>> GetItems()
        {
            try
            {
                //Get the value from an Uri and deserialize it in Json
                var products = await this.httpClient.GetFromJsonAsync<IEnumerator<ProductDto>>("api/Product");
                return (IEnumerable<ProductDto>)products;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
