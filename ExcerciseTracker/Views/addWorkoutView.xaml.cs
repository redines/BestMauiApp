using ExcerciseTracker.ViewModels;

namespace ExcerciseTracker.Views;

public partial class addWorkoutView : ContentPage
{
	public addWorkoutView(AddWorkoutViewModel vm)
	{
		BindingContext = vm;
		InitializeComponent();
	}
}