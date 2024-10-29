using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExcerciseTracker.Views;

namespace ExcerciseTracker.ViewModels
{
    public partial class SettingsViewModel : ObservableObject
    {

        [RelayCommand]
        async Task GoToMain()
        {
            await Shell.Current.GoToAsync("///MainPage");
        }

        [RelayCommand]
        async Task GoToProfile()
        {
            await Shell.Current.GoToAsync(nameof(ProfileView));
        }

        [RelayCommand]
        async Task GoToTodaysWorkout()
        {
            await Shell.Current.GoToAsync(nameof(TodaysWorkoutView));
        }

        [RelayCommand]
        async Task GoToWorkout()
        {
            await Shell.Current.GoToAsync(nameof(WorkoutView));
        }
    }
}
