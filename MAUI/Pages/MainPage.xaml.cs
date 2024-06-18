using BestMauiApp;
using Domain.Entities;

namespace MAUI.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void onLight()
        {

        }

        void onDark()
        {

        }

        public async void OnNewButtonClicked(object sender, EventArgs args)
        {

            await App.ExcerciseRepository.AddNewExcerciseWeek(new Excercise{
                Id = Guid.NewGuid(),
                User = "pontus"
            });

        }

        public async void OnGetButtonClicked(object sender, EventArgs args)
        {

            List<Excercise> people = await App.ExcerciseRepository.GetAllExcerciseWeeks();
        }
    }
}
