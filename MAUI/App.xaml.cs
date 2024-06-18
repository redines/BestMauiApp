using BestMauiApp.Repository;
namespace BestMauiApp
{
    public partial class App : Application
    {
        public static ExcerciseRepository ExcerciseRepository { get; private set; }

        public App(ExcerciseRepository repo)
        {
            InitializeComponent();

            MainPage = new AppShell();

            ExcerciseRepository = repo;
        }
    }
}
