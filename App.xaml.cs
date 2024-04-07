using BestMauiApp.Repository;

namespace BestMauiApp
{
    public partial class App : Application
    {
        public static ExcerciseRepository ExcerciseRepo { get; private set; }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
