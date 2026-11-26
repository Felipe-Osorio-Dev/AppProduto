using AppProduto.Models;
using SQLite;

namespace AppProduto.Data
{
    public class AppDataBase
    {
        private readonly SQLiteAsyncConnection _database;
        private readonly SemaphoreSlim _semaphore = new(1, 1);
        private bool _isInitialized;

        public AppDataBase()
        {
            _database = new SQLiteAsyncConnection(
                AppDbConfig.DatabasePath,
                AppDbConfig.Flags
            );
        }

        private async Task InitializeAsync()
        {
            if (_isInitialized)
                return;

            await _semaphore.WaitAsync();

            try
            {
                if (_isInitialized)
                    return;

                await _database.CreateTableAsync<ProductModel>();
                _isInitialized = true;
            }
            finally
            {
                _semaphore.Release();
            }
        }

        public async Task<SQLiteAsyncConnection> GetAsyncConnection()
        {
            await InitializeAsync();
            return _database;
        }
    }
}
