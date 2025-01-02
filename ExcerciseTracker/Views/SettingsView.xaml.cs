using ExcerciseTracker.ViewModels;

namespace ExcerciseTracker.Views;

public partial class SettingsView : ContentPage
{
	public SettingsView(SettingsViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }

    private void OnThemeToggled(object sender, ToggledEventArgs e)
    {
        if (e.Value) // Dark mode is enabled
        {
            Application.Current.Resources.MergedDictionaries.Clear();
            //Application.Current.Resources.MergedDictionaries.Add(new Dark());
        }
        else // Light mode is enabled
        {
            Application.Current.Resources.MergedDictionaries.Clear();
            //Application.Current.Resources.MergedDictionaries.Add(new LightTheme());
        }
    }
}