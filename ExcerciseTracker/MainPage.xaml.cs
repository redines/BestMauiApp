using ExcerciseTracker.ViewModels;
using ExcerciseTracker.Views;
using MauiIcons.Core;

namespace ExcerciseTracker
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
            _ = new MauiIcon();
        }
    }

}
