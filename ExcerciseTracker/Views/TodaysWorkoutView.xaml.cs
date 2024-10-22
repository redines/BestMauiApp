using ExcerciseTracker.ViewModels;

namespace ExcerciseTracker.Views;

public partial class TodaysWorkoutView : ContentPage
{
	public TodaysWorkoutView(TodaysWorkoutViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}