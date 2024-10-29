using ExcerciseTracker.ViewModels;

namespace ExcerciseTracker.Views;

public partial class CrudView : ContentPage
{
	public CrudView(CrudViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}