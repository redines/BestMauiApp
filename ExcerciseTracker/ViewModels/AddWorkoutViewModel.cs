using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExcerciseTracker.sqlite;
using ExcerciseTracker.Views;
using ExcerciseTracker.Entities;

namespace ExcerciseTracker.ViewModels
{
    public partial class AddWorkoutViewModel : ObservableObject
    {
        [ObservableProperty]
        string? workoutName;

        [ObservableProperty]
        string? workoutDay;


        SQliteDatabase database;

        public AddWorkoutViewModel(SQliteDatabase db)
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
        async Task<int> SaveWorkout()
        {
            int result = 0;

            if (string.IsNullOrWhiteSpace(WorkoutName))
            {
                return result;
            }

            Workout newWorkout = new Workout
            {
                Name = WorkoutName,
                Day = WorkoutDay
            };

            result = await database.SaveWorkoutAsync(newWorkout);

            WorkoutName = "";
            WorkoutDay = "";

            return result;
        }
    }
}
