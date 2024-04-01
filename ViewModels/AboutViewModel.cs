using BestMauiApp.Models;
using BestMauiApp.Utils;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace BestMauiApp.ViewModels;

internal class AboutViewModel : ObservableObject
{
    //TODO: change class to fit more with the current app
    private Models.ExcerciseModel _excercise;

    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://aka.ms/maui";
    public string Message => "This app is written in XAML and C# with .NET MAUI.";
    public ICommand ShowMoreInfoCommand { get; }
    public ICommand GetWeek { get; }
    public string CurrentWeek => _excercise.CurrentWeek;

    public AboutViewModel()
    {
        ShowMoreInfoCommand = new AsyncRelayCommand(ShowMoreInfo);
        _excercise = new ExcerciseModel();
    }

    async Task ShowMoreInfo() =>
        await Launcher.Default.OpenAsync(MoreInfoUrl);

}