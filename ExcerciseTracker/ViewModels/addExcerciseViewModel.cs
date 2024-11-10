using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Domain.Entities.ExcerciseEntities;
using ExcerciseTracker.sqlite;
using ExcerciseTracker.Views;

namespace ExcerciseTracker.ViewModels
{
    public partial class addExcerciseViewModel : ObservableObject
    {
        [ObservableProperty]
        string? excercisename;

        [ObservableProperty]
        string? reps;

        [ObservableProperty]
        string? weights;

        [ObservableProperty]
        string? sets;

        SQliteDatabase database;

        public addExcerciseViewModel(SQliteDatabase db)
        {
            database = db;
        }

        [RelayCommand]
        async Task GoToProfile()
        {
            await Shell.Current.GoToAsync(nameof(ProfileView));
        }

        [RelayCommand]
        async Task GoToSettings()
        {
            await Shell.Current.GoToAsync(nameof(SettingsView));
        }

        [RelayCommand]
        async Task GoToAddExcercise()
        {
            await Shell.Current.GoToAsync(nameof(addExcerciseView));
        }

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("../");
        }

        [RelayCommand]
        async Task<int> SaveExcercise()
        {
            int result = 0;

            if (string.IsNullOrWhiteSpace(Excercisename) ||
                string.IsNullOrWhiteSpace(Reps) ||
                string.IsNullOrWhiteSpace(Sets) ||
                string.IsNullOrWhiteSpace(Weights)
                )
            {
                return result;
            }

            Excercise newExcercise = new Excercise
            {
                Name = Excercisename,
                Reps = int.Parse(Reps),
                Sets = int.Parse(Sets),
                Weight = int.Parse(Weights)
            };

            result = await database.SaveItemAsync(newExcercise);

            return result;
        }
    }
}
