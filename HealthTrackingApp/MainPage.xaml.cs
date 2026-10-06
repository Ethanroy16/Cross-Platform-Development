namespace HealthTrackingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnProgressClicked(object? sender, EventArgs e)
        {
            await DisplayAlert(
                "Progress",
                "Your weekly activity is currently at 78%.",
                "OK");
        }
    }
}

