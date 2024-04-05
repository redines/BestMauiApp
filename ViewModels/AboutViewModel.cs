using BestMauiApp.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace BestMauiApp.ViewModels;

internal class AboutViewModel : INotifyPropertyChanged
{
    //TODO: change class to fit more with the current app
    private ExcerciseModel _excercise;

    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string CurrentWeek => _excercise.CurrentWeek;
    public string clickedBtn = string.Empty;
    public ICommand ButtonClickCommand { get; }

    private bool _buttonClicked = false;
    public bool ButtonClicked
    {
        get => _buttonClicked;
        set
        {
            _buttonClicked = value;
            OnPropertyChanged(nameof(ButtonClicked));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public AboutViewModel()
    {
        _excercise = new ExcerciseModel();
        ButtonClickCommand = new Command<string>(OnButtonClicked);
    }

    public void OnButtonClicked(string day)
    {
        clickedBtn = day;
        ButtonClicked = true;
    }

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}