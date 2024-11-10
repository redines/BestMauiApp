using ExcerciseTracker.ViewModels;

namespace ExcerciseTracker.Views;

public partial class addExcerciseView : ContentPage
{
	public addExcerciseView(addExcerciseViewModel vm)
	{
		BindingContext = vm;
		InitializeComponent();
	}
}