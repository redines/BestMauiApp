using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExcerciseTracker.sqlite;
using ExcerciseTracker.Views;
using System.Collections.ObjectModel;
using ExcerciseTracker.Entities;

namespace ExcerciseTracker.ViewModels
{
    public partial class AllWorkoutsViewModel : ObservableObject
    {
        private SQliteDatabase database;

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
            AllWorkouts.Clear();
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

        [RelayCommand]
        async Task Tap(Workout workout)
        {
            await Shell.Current.GoToAsync(nameof(WorkoutDetails), new Dictionary<string, object> { 
                { "Workout", workout } 
            });
        }
    }
}
