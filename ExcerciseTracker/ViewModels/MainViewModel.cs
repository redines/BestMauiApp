using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExcerciseTracker.Views;
using System.Collections.ObjectModel;
using ExcerciseTracker.sqlite;
using ExcerciseTracker.Entities;

namespace ExcerciseTracker.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private SQliteDatabase database;

        public MainViewModel(SQliteDatabase db)
        {
            database = db;
            allWorkouts = new ObservableCollection<Workout>();
        }

        [ObservableProperty]
        ObservableCollection<Workout> allWorkouts;


        [ObservableProperty]
        string? todaysDay;

        [RelayCommand]
        async Task OnLoad()
        {
            DateTime today = DateTime.Today;
            TodaysDay = today.DayOfWeek.ToString();

            AllWorkouts.Clear();
            var workoutList = await database.GetWorkoutsAsync();
            foreach (var workout in workoutList)
            {
                AllWorkouts.Add(workout);
            }
        }

        [RelayCommand]
        async Task Tap(Workout workout)
        {
            await Shell.Current.GoToAsync(nameof(TodaysWorkoutView), new Dictionary<string, object> {
                { "Workout", workout }
            });
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
        async Task GoToTodaysWorkout()
        {
            await Shell.Current.GoToAsync(nameof(TodaysWorkoutView));
        }

        [RelayCommand]
        async Task GoToWorkout()
        {
            await Shell.Current.GoToAsync(nameof(WorkoutView));
        }
    }
}
