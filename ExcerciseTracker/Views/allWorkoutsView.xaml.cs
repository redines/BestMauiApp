using ExcerciseTracker.ViewModels;

namespace ExcerciseTracker.Views;

public partial class allWorkoutsView : ContentPage
{
	public allWorkoutsView(AllWorkoutsViewModel vm)
	{
        BindingContext = vm;
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        if (BindingContext is AllWorkoutsViewModel viewModel && viewModel.LoadCommand != null)
        {
            viewModel.LoadCommand.Execute(null);
        }
    }
}