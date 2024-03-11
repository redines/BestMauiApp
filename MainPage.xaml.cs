using BestMauiApp.Utils;
using System.Globalization;

namespace BestMauiApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            title.Text = $"Week: {Utils.Utils.GetCurrentWeek()}";
        }

        private void OnBtnClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
