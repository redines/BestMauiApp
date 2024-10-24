﻿using CommunityToolkit.Mvvm.ComponentModel;
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

        [RelayCommand]
        async Task GoToSettings()
        {
            await Shell.Current.GoToAsync(nameof(SettingsView));
        }

        [RelayCommand]
        async Task GoToTodaysWorkout()
        {
            await Shell.Current.GoToAsync(nameof(TodaysWorkoutView));
        }
    }
}
