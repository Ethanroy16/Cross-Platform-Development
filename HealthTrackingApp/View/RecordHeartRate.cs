using HealthTrackingApp;

namespace HealthTrackingApp.View;

public class RecordHeartRate : ContentPage
{
    public RecordHeartRate()
    {
        // Pseudocode: Build the heart-rate recording page and allow the user to save a reading.

        Title = "Record Heart Rate";

        Grid mainGrid = new Grid
        {
            RowDefinitions =
            {
                new RowDefinition(GridLength.Star),
                new RowDefinition(75)
            }
        };

        ScrollView scrollView = new ScrollView();

        VerticalStackLayout content = new VerticalStackLayout
        {
            Padding = 25,
            Spacing = 18,
            BackgroundColor = Color.FromArgb("#FFF0F3")
        };

        Label title = new Label
        {
            Text = "Record Heart Rate",
            FontSize = 32,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#FF4D6D")
        };

        Label subtitle = new Label
        {
            Text = "Enter your heart rate reading.",
            FontSize = 16,
            TextColor = Color.FromArgb("#6B7A76")
        };

        Label heartRateLabel = new Label
        {
            Text = "Heart Rate (bpm)",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#FF4D6D")
        };

        Entry heartRateEntry = new Entry
        {
            Placeholder = "Enter heart rate",
            Keyboard = Keyboard.Numeric,
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F"),
            PlaceholderColor = Color.FromArgb("#687873")
        };

        Label dateLabel = new Label
        {
            Text = "Date",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#FF4D6D")
        };

        DatePicker datePicker = new DatePicker
        {
            Date = DateTime.Today,
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F")
        };

        Label notesLabel = new Label
        {
            Text = "Notes",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#FF4D6D")
        };

        Editor notesEditor = new Editor
        {
            Placeholder = "Add any notes about your reading...",
            HeightRequest = 100,
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F"),
            PlaceholderColor = Color.FromArgb("#687873")
        };

        Button saveButton = new Button
        {
            Text = "Save Heart Rate",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Color.FromArgb("#FF4D6D"),
            TextColor = Colors.White,
            CornerRadius = 12,
            HeightRequest = 50
        };

        saveButton.Clicked += async (sender, e) =>
        {
            // Pseudocode: Check that the user entered a heart-rate reading.

            if (string.IsNullOrWhiteSpace(heartRateEntry.Text))
            {
                await DisplayAlert(
                    "Missing Heart Rate",
                    "Please enter your heart rate.",
                    "OK");

                return;
            }

            // Pseudocode: Confirm that the heart-rate reading was recorded.

            await DisplayAlert(
                "Heart Rate Recorded",
                $"You recorded a heart rate of {heartRateEntry.Text} bpm.",
                "OK");

            await Navigation.PopAsync();
        };

        content.Children.Add(title);
        content.Children.Add(subtitle);

        content.Children.Add(heartRateLabel);
        content.Children.Add(heartRateEntry);

        content.Children.Add(dateLabel);
        content.Children.Add(datePicker);

        content.Children.Add(notesLabel);
        content.Children.Add(notesEditor);

        content.Children.Add(saveButton);

        scrollView.Content = content;

        mainGrid.Add(scrollView, 0, 0);

        // One reusable navigation bar
        mainGrid.Add(new BottomNav(), 0, 1);

        Content = mainGrid;

        NavigationPage.SetHasNavigationBar(this, false);
    }
}
