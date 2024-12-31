using ExcerciseTracker.ViewModels;

namespace ExcerciseTracker.Views;

public partial class WorkoutDetails : ContentPage
{
	public WorkoutDetails(WorkoutDetailsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    private void OnPageLoaded(object sender, EventArgs e)
    {
        if (BindingContext is WorkoutDetailsViewModel viewModel && viewModel.LoadCommand != null)
        {
            viewModel.LoadCommand.Execute(null);
        }
    }
}