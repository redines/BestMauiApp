using ExcerciseTracker.sqlite;
using ExcerciseTracker.ViewModels;
using ExcerciseTracker.Views;
using MauiIcons.FontAwesome;
using MauiIcons.FontAwesome.Brand;
using MauiIcons.FontAwesome.Solid;
using Microsoft.Extensions.Logging;

namespace ExcerciseTracker
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseFontAwesomeBrandMauiIcons()
                .UseFontAwesomeMauiIcons()
                .UseFontAwesomeSolidMauiIcons()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

            builder.Services.AddTransient<ProfileView>();
            builder.Services.AddTransient<ProfileViewModel>();
            builder.Services.AddTransient<SettingsView>();
            builder.Services.AddTransient<SettingsViewModel>();
            builder.Services.AddTransient<TodaysWorkoutView>();
            builder.Services.AddTransient<TodaysWorkoutViewModel>();
            builder.Services.AddTransient<WorkoutView>();
            builder.Services.AddTransient<WorkoutViewModel>();
            builder.Services.AddTransient<allExcercisesView>();
            builder.Services.AddTransient<allExcercisesViewModel>();
            builder.Services.AddTransient<addExcerciseView>();
            builder.Services.AddTransient<addExcerciseViewModel>();
            builder.Services.AddTransient<addWorkoutView>();
            builder.Services.AddTransient<AddWorkoutViewModel>();
            builder.Services.AddTransient<allWorkoutsView>();
            builder.Services.AddTransient<AllWorkoutsViewModel>();
            builder.Services.AddTransient<WorkoutDetails>();
            builder.Services.AddTransient<WorkoutDetailsViewModel>();

            builder.Services.AddSingleton<SQliteDatabase>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
