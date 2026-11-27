using AppProduto.Data;
using AppProduto.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppProduto.Repository
{
    internal class ProductRepository : IProductRepository
    {
        private readonly AppDataBase _dataBase;

        public ProductRepository(AppDataBase dataBase)
        {
            _dataBase = dataBase;
        }

        public async Task<int> DeleteProductAsync(ProductModel product)
        {
            var db = await _dataBase.GetAsyncConnection();

            return await db.DeleteAsync(product);
        }

        public async Task<List<ProductModel>> GetAllProductsAsync()
        {
            var db = await _dataBase.GetAsyncConnection();

            return await db.Table<ProductModel>().ToListAsync();
        }

        public async Task<ProductModel?> GetProductByIdAsync(int id)
        {
            var db = await _dataBase.GetAsyncConnection();

            return await db.FindAsync<ProductModel>(id);
        }

        public async Task<int> RegisterProductAsync(ProductModel product)
        {
            var db = await _dataBase.GetAsyncConnection();

            return await db.InsertAsync(product);
        }

        public async Task<int> UpdateProductAsync(ProductModel product)
        {
            var db = await _dataBase.GetAsyncConnection();

            return await db.UpdateAsync(product);
        }
    }
}
