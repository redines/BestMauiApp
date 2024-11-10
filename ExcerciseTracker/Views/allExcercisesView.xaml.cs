using ExcerciseTracker.ViewModels;

namespace ExcerciseTracker.Views;

public partial class allExcercisesView : ContentPage
{
	public allExcercisesView(allExcercisesViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
	private void OnPageLoaded(object sender, EventArgs e)
	{
		if (BindingContext is allExcercisesViewModel viewModel && viewModel.LoadCommand != null) { 
			viewModel.LoadCommand.Execute(null); 
		}
	}
}