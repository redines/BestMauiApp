using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Domain.Entities.ExcerciseEntities;
using ExcerciseTracker.sqlite;
using ExcerciseTracker.Views;
using System.Collections.ObjectModel;

namespace ExcerciseTracker.ViewModels
{
    public partial class allExcercisesViewModel : ObservableObject
    {

        SQliteDatabase database;

        public allExcercisesViewModel(SQliteDatabase db)
        {
            database = db;
            allExcercises = new ObservableCollection<Excercise>();
        }

        [ObservableProperty]
        ObservableCollection<Excercise> allExcercises;


        [RelayCommand]
        async Task OnLoad()
        {
            var excList = await database.GetExcercisesAsync();
            foreach (var excercise in excList)
            {
                AllExcercises.Add(excercise);
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
