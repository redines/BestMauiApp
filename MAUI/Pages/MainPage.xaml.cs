using BestMauiApp;
using Domain.Entities.ExcerciseEntities;

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

        //public async void onnewbuttonclicked(object sender, eventargs args)
        //{

        //    await app.excerciserepository.addnewexcerciseweek(new excercise{
        //        id = guid.newguid(),
        //        user = "pontus"
        //    });

        //}

        public async void OnGetButtonClicked(object sender, EventArgs args)
        {

            List<Excercise> people = await App.ExcerciseRepository.GetAllExcerciseWeeks();
        }
    }
}
