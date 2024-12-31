using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExcerciseTracker.Entities;
using ExcerciseTracker.sqlite;
using ExcerciseTracker.Views;
using System.Collections.ObjectModel;

namespace ExcerciseTracker.ViewModels
{
    public partial class WorkoutViewModel : ObservableObject
    {
        private SQliteDatabase database;

        public WorkoutViewModel(SQliteDatabase db)
        {
            database = db;
            allWorkouts = new ObservableCollection<Workout>();
            allExercises = new ObservableCollection<Exercise>();
        }

        [ObservableProperty]
        ObservableCollection<Workout> allWorkouts;

        [ObservableProperty]
        ObservableCollection<Exercise> allExercises;

        [RelayCommand]
        async Task OnLoad()
        {
            AllExercises.Clear();
            AllWorkouts.Clear();

            var excList = await database.GetExcercisesAsync();
            var workList = await database.GetWorkoutsAsync();

            foreach (var exercise in excList)
            {
                AllExercises.Add(exercise);
            }
            
            foreach (var workouts in workList)
            {
                AllWorkouts.Add(workouts);
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
        async Task GoToMain()
        {
            await Shell.Current.GoToAsync("///MainPage");
        }

        [RelayCommand]
        async Task GoToAddExcercise()
        {
            await Shell.Current.GoToAsync(nameof(allExcercisesView));
        }

        [RelayCommand]
        async Task GoToAddWorkout()
        {
            await Shell.Current.GoToAsync(nameof(allWorkoutsView));
        }
    }
}
