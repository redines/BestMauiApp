using BestMauiApp.Repository;

namespace BestMauiApp
{
    public partial class App : Application
    {
        public static ExcerciseRepository ExcerciseRepo { get; set; }
        public App(ExcerciseRepository repo)
        {
            InitializeComponent();

            MainPage = new AppShell();

            ExcerciseRepo = repo;
        }
    }
}
