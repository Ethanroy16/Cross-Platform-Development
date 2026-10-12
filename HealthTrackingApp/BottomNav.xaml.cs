namespace HealthTrackingApp;

public partial class BottomNav : ContentView
{
    public BottomNav()
    {
        InitializeComponent();
    }

    private async void OnHomeClicked(object sender, TappedEventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    private async void OnExerciseClicked(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new View.Exercise());
    }

    private async void OnProgressClicked(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new View.Progress());
    }

    private async void OnSleepClicked(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new View.Sleep());
    }

    private async void OnHeartClicked(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new View.Heart());
    }
}