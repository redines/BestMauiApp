using BestMauiApp.Repository;
using Microsoft.Extensions.Logging;

namespace BestMauiApp
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            string dbPath = FileAccessHelper.GetLocalFilePath("LocalDb.db3");
            builder.Services.AddSingleton<ExcerciseRepository>(s => ActivatorUtilities.CreateInstance<ExcerciseRepository>(s, dbPath));


            return builder.Build();
        }
    }
}
