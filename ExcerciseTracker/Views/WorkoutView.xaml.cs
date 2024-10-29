using ExcerciseTracker.ViewModels;

namespace ExcerciseTracker.Views;

public partial class WorkoutView : ContentPage
{
	public WorkoutView( TodaysWorkoutViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}