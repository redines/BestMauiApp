using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Domain.Entities.ExcerciseEntities;
using ExcerciseTracker.sqlite;
using ExcerciseTracker.Views;
using System.Collections.ObjectModel;

namespace ExcerciseTracker.ViewModels
{
    public partial class AllWorkoutsViewModel : ObservableObject
    {
        SQliteDatabase database;

        public AllWorkoutsViewModel(SQliteDatabase db)
        {
            database = db;
            allWorkouts = new ObservableCollection<Workout>();
        }

        [ObservableProperty]
        ObservableCollection<Workout> allWorkouts;

        [RelayCommand]
        async Task OnLoad()
        {
            var workoutList = await database.GetWorkoutsAsync();
            foreach (var workout in workoutList)
            {
                AllWorkouts.Add(workout);
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
        async Task GoToAddWorkout()
        {
            await Shell.Current.GoToAsync(nameof(addWorkoutView));
        }

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("../");
        }
    }
}
