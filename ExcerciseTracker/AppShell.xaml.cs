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
            Routing.RegisterRoute(nameof(CrudView), typeof(CrudView));
        }
    }
}
