using AppProduto.Models;

namespace AppProduto.Repository
{
    internal interface IProductRepository
    {
        Task<int> RegisterProductAsync(ProductModel product);
        Task<List<ProductModel>> GetAllProductsAsync();
        Task<ProductModel?> GetProductByIdAsync(int id);
        Task<int> UpdateProductAsync(ProductModel product);
        Task<int> DeleteProductAsync(ProductModel product);
    }
}
