using ExcerciseTracker.ViewModels;
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

        protected override void OnAppearing()
        {
            if (BindingContext is MainViewModel viewModel && viewModel.LoadCommand != null)
            {
                viewModel.LoadCommand.Execute(null);
            }
        }
    }
}
