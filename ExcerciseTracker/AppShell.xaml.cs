using ExcerciseTracker.Views;

namespace ExcerciseTracker
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ProfileView), typeof(ProfileView));
            Routing.RegisterRoute(nameof(SettingsView), typeof(SettingsView));
            Routing.RegisterRoute(nameof(TodaysWorkoutView), typeof(TodaysWorkoutView));
            Routing.RegisterRoute(nameof(WorkoutView), typeof(WorkoutView));
            Routing.RegisterRoute(nameof(allExcercisesView), typeof(allExcercisesView));
            Routing.RegisterRoute(nameof(addExcerciseView), typeof(addExcerciseView));
            Routing.RegisterRoute(nameof(addWorkoutView), typeof(addWorkoutView));
            Routing.RegisterRoute(nameof(allWorkoutsView), typeof(allWorkoutsView));
        }
    }
}
