namespace HealthTrackingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Home button
        private async void OnHomeClicked(object? sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        // Exercise button
        private async void OnExerciseClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Exercise());
        }

        // Progress button
        private async void OnProgressClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Progress());
        }

        // Sleep button
        private async void OnSleepClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Sleep());
        }

        // Heart button
        private async void OnHeartClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Heart());
        }

        // Profile button
        private async void OnProfileClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.profile());
        }
    }
}