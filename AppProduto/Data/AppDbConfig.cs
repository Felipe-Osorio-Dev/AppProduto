using SQLite;

namespace AppProduto.Data
{
    public class AppDbConfig
    {
        public const string DatabaseName = "AppProdutoDb.db3";

        public const SQLiteOpenFlags Flags = 
            SQLiteOpenFlags.ReadWrite | 
            SQLiteOpenFlags.Create | 
            SQLiteOpenFlags.FullMutex;

        //Cria um Diretorio privado para o banco de dados
        public static string DatabasePath => Path.Combine(FileSystem.AppDataDirectory, DatabaseName);
    }
}
