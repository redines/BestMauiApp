using BestMauiApp.Repository;
using MAUI.Pages;

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
                    fonts.AddFont("Font Awesome 6 Free-Solid-900.otf", "FASolid");
                });


            builder.Services.AddTransient<Excercisetracker>();

            string dbPath = MAUI.FileAccessHelper.GetLocalFilePath("Local.db3");
            builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<ExcerciseRepository>(s, dbPath));


            return builder.Build();
        }
    }
}
