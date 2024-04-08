using BestMauiApp.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace BestMauiApp.ViewModels;

internal class ExcerciseViewModel : INotifyPropertyChanged
{
    //TODO: change class to fit more with the current app
    private ExcerciseModel _excercise;
    public string CurrentWeek { get; set; }
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

    public ExcerciseViewModel()
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