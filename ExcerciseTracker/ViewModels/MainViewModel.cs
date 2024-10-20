using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExcerciseTracker.Views;

namespace ExcerciseTracker.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {

        public MainViewModel()
        {
        }

        [RelayCommand]
        async Task GoToProfile()
        {
            await Shell.Current.GoToAsync(nameof(ProfileView));
        }
    }
}
