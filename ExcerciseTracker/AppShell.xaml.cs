using ExcerciseTracker.Views;

namespace ExcerciseTracker
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ProfileView), typeof(ProfileView));
        }
    }
}
