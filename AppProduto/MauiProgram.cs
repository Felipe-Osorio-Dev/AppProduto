using AppProduto.Data;
using AppProduto.Repository;
using Microsoft.Extensions.Logging;

namespace AppProduto
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            //Database
            builder.Services.AddSingleton<AppDataBase>();

            //Repository
            builder.Services.AddSingleton<IProductRepository, ProductRepository>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
