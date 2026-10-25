using HealthTrackingApp;
using Microsoft.Maui.Controls.Shapes;

namespace HealthTrackingApp.View;

public class RecordWater : ContentPage
{
    public RecordWater()
    {
        // Pseudocode: Build the water recording page and allow the user to save a water entry.

        Title = "Record Water";

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
            BackgroundColor = Color.FromArgb("#EAF2FF")
        };

        Label title = new Label
        {
            Text = "Record Water",
            FontSize = 32,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#3B82F6")
        };

        Label subtitle = new Label
        {
            Text = "Record how much water you have had.",
            FontSize = 16,
            TextColor = Color.FromArgb("#6B7A76")
        };

        Label amountLabel = new Label
        {
            Text = "Water Amount (ml)",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#3B82F6")
        };

        Entry amountEntry = new Entry
        {
            Placeholder = "Enter amount in ml",
            Keyboard = Keyboard.Numeric,
            BackgroundColor = Colors.White,
            TextColor = Colors.Black
        };

        Label dateLabel = new Label
        {
            Text = "Date",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#3B82F6")
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
            TextColor = Color.FromArgb("#3B82F6")
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
            Text = "Save Water",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Color.FromArgb("#3B82F6"),
            TextColor = Colors.White,
            CornerRadius = 12,
            HeightRequest = 50
        };

        saveButton.Clicked += async (sender, e) =>
        {
            // Pseudocode: Check that the user entered a water amount.

            if (string.IsNullOrWhiteSpace(amountEntry.Text))
            {
                await DisplayAlert("Missing Amount", "Please enter the amount of water.", "OK");
                return;
            }

            // Pseudocode: Confirm that the water entry was recorded.

            await DisplayAlert(
                "Water Recorded",
                $"You recorded {amountEntry.Text} ml of water.",
                "OK");

            await Navigation.PopAsync();
        };

        content.Children.Add(title);
        content.Children.Add(subtitle);
        content.Children.Add(amountLabel);
        content.Children.Add(amountEntry);
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