using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExcerciseTracker.Views;
using System.Collections.ObjectModel;
using ExcerciseTracker.sqlite;
using ExcerciseTracker.Entities;
using ExcerciseTracker.Services;
using System.Globalization;

namespace ExcerciseTracker.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private SQliteDatabase database;

        public MainViewModel(SQliteDatabase db)
        {
            database = db;
            allWorkouts = new ObservableCollection<Workout>();
            currentWeek = GetCurrentWeek();
        }

        [ObservableProperty]
        ObservableCollection<Workout> allWorkouts;

        [ObservableProperty]
        string currentWeek;


        [ObservableProperty]
        string? todaysDay;

        public static string GetCurrentWeek()
        {
            //for now, take the the current executing thread's Culture
            var cultureInfo = Thread.CurrentThread.CurrentCulture;

            var year = DateTime.Now.Year;
            var month = DateTime.Now.Month;
            var day = DateTime.Now.Day;

            DateTime dd = new(year, month, day);

            DayOfWeek firstDay = cultureInfo.DateTimeFormat.FirstDayOfWeek;
            CalendarWeekRule weekRule = cultureInfo.DateTimeFormat.CalendarWeekRule;
            Calendar cal = cultureInfo.Calendar;
            var week = cal.GetWeekOfYear(dd, weekRule, firstDay);

            return week.ToString();
        }

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
