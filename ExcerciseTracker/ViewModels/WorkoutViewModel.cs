using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExcerciseTracker.Views;
using System.ComponentModel;

namespace ExcerciseTracker.ViewModels
{
    public partial class WorkoutViewModel : ObservableObject
    {

        [RelayCommand]
        async Task GoToProfile()
        {
            await Shell.Current.GoToAsync(nameof(ProfileView));
        }

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
        async Task GoToAddExcercise()
        {
            await Shell.Current.GoToAsync(nameof(allExcercisesView));
        }

        [RelayCommand]
        async Task GoToAddWorkout()
        {
            await Shell.Current.GoToAsync(nameof(allWorkoutsView));
        }
    }
}
