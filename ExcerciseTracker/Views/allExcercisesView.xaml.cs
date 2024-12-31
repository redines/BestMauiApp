using ExcerciseTracker.ViewModels;

namespace ExcerciseTracker.Views;

public partial class allExcercisesView : ContentPage
{
	public allExcercisesView(allExcercisesViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    protected override void OnAppearing()
    {
        if (BindingContext is allExcercisesViewModel viewModel && viewModel.LoadCommand != null)
        {
            viewModel.LoadCommand.Execute(null);
        }
    }
}