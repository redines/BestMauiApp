
using BestMauiApp.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Domain.Entities;
using MAUI.Data;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace BestMauiApp.ViewModels;

public partial class ExcerciseViewModel : ObservableObject
{

    [ObservableProperty]
    ObservableCollection<Excercise> _excercise;

    [ObservableProperty]
    bool _isRefreshing = false;


    [ObservableProperty]
    bool _isBusy = false;

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
        _excercise = new ObservableCollection<Excercise>();
        WeakReferenceMessenger.Default.Register<RefreshMessage>(this, async (r, m) =>
        {
            await LoadData();
        });

        Task.Run(LoadData);
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

    [RelayCommand]
    async Task LoadData()
    {
        if (IsBusy)
            return;

        try
        {
            IsRefreshing = true;
            IsBusy = true;

            var ExcerciseCollection = await Datamanager.GetAll();

            MainThread.BeginInvokeOnMainThread(() =>
            {
                Excercise.Clear();

                foreach (Excercise excercise in ExcerciseCollection)
                {
                    ExcerciseCollection.Add(excercise);
                }
            });
        }
        finally
        {
            IsRefreshing = false;
            IsBusy = false;
        }
    }
}