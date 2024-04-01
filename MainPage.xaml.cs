namespace BestMauiApp
{
    public partial class MainPage : ContentPage
    {
        private bool IsClicked = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnBtnClicked(object sender, EventArgs e)
        {
            // Do something when any of the buttons is clicked
            Button clickedButton = (Button)sender;
            IsClicked = !IsClicked;
            clickedButton.BackgroundColor = IsClicked ? Color.FromRgb(93, 252, 120) : Color.FromRgb(254, 55, 54);
        }
    }

}
