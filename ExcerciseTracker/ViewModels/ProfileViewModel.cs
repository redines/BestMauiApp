using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExcerciseTracker.Views;

namespace ExcerciseTracker.ViewModels
{
    public partial class ProfileViewModel : ObservableObject
    {
        [RelayCommand]
        async Task GoToSettings()
        {
            await Shell.Current.GoToAsync(nameof(SettingsView));
        }
        
        [RelayCommand]
        async Task GoToMain()
        {
            await Shell.Current.GoToAsync("///MainPage");
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
