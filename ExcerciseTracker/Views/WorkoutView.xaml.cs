using ExcerciseTracker.ViewModels;

namespace ExcerciseTracker.Views;

public partial class WorkoutView : ContentPage
{
	public WorkoutView(WorkoutViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}