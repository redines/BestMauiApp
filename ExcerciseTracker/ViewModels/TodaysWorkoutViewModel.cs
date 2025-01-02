using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExcerciseTracker.Views;
using ExcerciseTracker.sqlite;
using ExcerciseTracker.Entities;
using System.Collections.ObjectModel;

namespace ExcerciseTracker.ViewModels
{
    [QueryProperty(nameof(Workout), "Workout")]
    public partial class TodaysWorkoutViewModel : ObservableObject
    {
        private SQliteDatabase database;
        private Workout _workout;

        [ObservableProperty]
        bool excerciseDone = false;

        public TodaysWorkoutViewModel(SQliteDatabase db)
        {
            database = db;
            allExcercises = new ObservableCollection<Exercise>();
        }

        public Workout Workout
        {
            get => _workout;
            set
            {
                SetProperty(ref _workout, value);
            }
        }

        [ObservableProperty]
        ObservableCollection<Exercise> allExcercises;

        [RelayCommand]
        async Task OnLoad()
        {
            allExcercises.Clear();
            var x = await database.GetExercisesByWorkoutIdAsync(_workout.Id);
            if (x != null)
            {
                foreach (var ex in x)
                {
                    allExcercises.Add(ex);
                }
            }
        }

        [RelayCommand]
        async Task GoToMain()
        {
            await Shell.Current.GoToAsync("///MainPage");
        }

        [RelayCommand]
        async Task GoToWorkouts()
        {
            await Shell.Current.GoToAsync(nameof(WorkoutView));
        }
    }
}
