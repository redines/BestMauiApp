using BestMauiApp.ViewModels;

namespace MAUI.Pages;

public partial class Excercisetracker : ContentPage
{
	public Excercisetracker()
	{
		InitializeComponent();
        BindingContext = new ExcerciseViewModel();
    }
}