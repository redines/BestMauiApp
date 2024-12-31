using ExcerciseTracker.ViewModels;

namespace ExcerciseTracker.Views;

public partial class WorkoutView : ContentPage
{
	public WorkoutView(WorkoutViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    protected override void OnAppearing()
    {
        if (BindingContext is WorkoutViewModel viewModel && viewModel.LoadCommand != null)
        {
            viewModel.LoadCommand.Execute(null);
        }
    }
}