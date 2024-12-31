using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExcerciseTracker.sqlite;
using ExcerciseTracker.Views;
using System.Collections.ObjectModel;
using ExcerciseTracker.Entities;

namespace ExcerciseTracker.ViewModels
{
    public partial class allExcercisesViewModel : ObservableObject
    {

        SQliteDatabase database;

        public allExcercisesViewModel(SQliteDatabase db)
        {
            database = db;
            allExcercises = new ObservableCollection<Exercise>();
        }

        [ObservableProperty]
        ObservableCollection<Exercise> allExcercises;


        [RelayCommand]
        async Task OnLoad()
        {
            AllExcercises.Clear();
            var excList = await database.GetExcercisesAsync();
            foreach (var exercise in excList)
            {
                AllExcercises.Add(exercise);
            }
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
    }
}
