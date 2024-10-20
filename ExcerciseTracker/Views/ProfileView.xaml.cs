using ExcerciseTracker.ViewModels;

namespace ExcerciseTracker.Views;

public partial class ProfileView : ContentPage
{
	public ProfileView(ProfileViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}