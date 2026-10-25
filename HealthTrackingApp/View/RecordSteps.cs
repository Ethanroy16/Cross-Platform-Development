using HealthTrackingApp;
using Microsoft.Maui.Controls.Shapes;

namespace HealthTrackingApp.View;

public class RecordSteps : ContentPage
{
    public RecordSteps()
    {
        // Pseudocode: Build the steps recording page and allow the user to save a steps entry.

        Title = "Record Steps";

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
            BackgroundColor = Color.FromArgb("#E6F7F5")
        };

        Label title = new Label
        {
            Text = "Record Steps",
            FontSize = 32,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#14B8A6")
        };

        Label subtitle = new Label
        {
            Text = "Record the number of steps you have taken.",
            FontSize = 16,
            TextColor = Color.FromArgb("#6B7A76")
        };

        Label stepsLabel = new Label
        {
            Text = "Number of Steps",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#14B8A6")
        };

        Entry stepsEntry = new Entry
        {
            Placeholder = "Enter number of steps",
            Keyboard = Keyboard.Numeric,
            BackgroundColor = Colors.White,
            TextColor = Colors.Black
        };

        Label dateLabel = new Label
        {
            Text = "Date",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#14B8A6")
        };

        DatePicker datePicker = new DatePicker
        {
            Date = DateTime.Today,
            BackgroundColor = Colors.White,
            TextColor = Colors.Black
        };

        Label notesLabel = new Label
        {
            Text = "Notes",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#14B8A6")
        };

        Editor notesEditor = new Editor
        {
            Placeholder = "Add any notes...",
            AutoSize = EditorAutoSizeOption.TextChanges,
            BackgroundColor = Colors.White,
            TextColor = Colors.Black,
            HeightRequest = 100
        };

        Button saveButton = new Button
        {
            Text = "Save Steps",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Color.FromArgb("#14B8A6"),
            TextColor = Colors.White,
            CornerRadius = 12,
            HeightRequest = 50
        };

        saveButton.Clicked += async (sender, e) =>
        {
            // Pseudocode: Check that the user entered a number of steps.

            if (string.IsNullOrWhiteSpace(stepsEntry.Text))
            {
                await DisplayAlert("Missing Steps", "Please enter the number of steps.", "OK");
                return;
            }

            // Pseudocode: Confirm that the steps entry was recorded.

            await DisplayAlert(
                "Steps Recorded",
                $"You recorded {stepsEntry.Text} steps.",
                "OK");

            await Navigation.PopAsync();
        };

        content.Children.Add(title);
        content.Children.Add(subtitle);
        content.Children.Add(stepsLabel);
        content.Children.Add(stepsEntry);
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