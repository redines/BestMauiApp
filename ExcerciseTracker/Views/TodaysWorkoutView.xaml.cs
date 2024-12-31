using ExcerciseTracker.ViewModels;

namespace ExcerciseTracker.Views;

public partial class TodaysWorkoutView : ContentPage
{
	public TodaysWorkoutView(TodaysWorkoutViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    protected override void OnAppearing()
    {
        if (BindingContext is TodaysWorkoutViewModel viewModel && viewModel.LoadCommand != null)
        {
            viewModel.LoadCommand.Execute(null);
        }
    }
}