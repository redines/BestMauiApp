using ExcerciseTracker.ViewModels;

namespace ExcerciseTracker.Views;

public partial class SettingsView : ContentPage
{
	public SettingsView(SettingsViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}