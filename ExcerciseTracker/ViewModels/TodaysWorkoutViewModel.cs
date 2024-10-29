using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExcerciseTracker.Views;

namespace ExcerciseTracker.ViewModels
{
    public partial class TodaysWorkoutViewModel : ObservableObject
    {

        [RelayCommand]
        async Task GoToMain()
        {
            await Shell.Current.GoToAsync("///MainPage");
        }

        [RelayCommand]
        async Task GoToWorkouts()
        {
            await Shell.Current.GoToAsync(nameof(WorkoutView));
        }
    }
}
