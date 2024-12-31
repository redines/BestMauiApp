using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExcerciseTracker.sqlite;
using System.Collections.ObjectModel;
using ExcerciseTracker.Entities;

namespace ExcerciseTracker.ViewModels
{
    [QueryProperty(nameof(Workout), "Workout")]
    public partial class WorkoutDetailsViewModel : ObservableObject
    {
        private SQliteDatabase database;
        private Workout _workout;

        [ObservableProperty]
        ObservableCollection<Exercise> allExcercises;

        [ObservableProperty]
        Exercise selectedExcercise;

        public WorkoutDetailsViewModel(SQliteDatabase db)
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

        [RelayCommand]
        async Task OnLoad()
        {
            AllExcercises.Clear();
            var excerciseList = await database.GetExcercisesAsync();
            foreach (var exercise in excerciseList)
            {
                AllExcercises.Add(exercise);
            }
        }

        [RelayCommand]
        async Task AddExerciseToWorkout(Exercise excercise)
        {
            if (excercise != null)
            {
                var we = new WorkoutExercise
                {
                    WorkoutId = _workout.Id,
                    ExerciseId = excercise.Id,
                };

                await database.SaveExerciseToWorkout(we);
            }

            await database.GetExercisesByWorkoutIdAsync(_workout.Id);
        }
    }
}
