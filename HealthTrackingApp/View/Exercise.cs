using HealthTrackingApp;
using Microsoft.Maui.Controls.Shapes;

namespace HealthTrackingApp.View;

public class Exercise : ContentPage
{
    public Exercise()
    {
        Title = "Exercise";

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
            BackgroundColor = Color.FromArgb("#FFF1E7")
        };

        Label title = new Label
        {
            Text = "Exercise",
            FontSize = 32,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#FF8A3D")
        };

        Label subtitle = new Label
        {
            Text = "Record and track your daily activity.",
            FontSize = 16,
            TextColor = Color.FromArgb("#6B7A76")
        };

        Label exerciseLabel = new Label
        {
            Text = "Exercise Type",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#17211F")
        };

        Picker exercisePicker = new Picker
        {
            Title = "Choose exercise",
            BackgroundColor = Colors.White
        };

        exercisePicker.Items.Add("Walking");
        exercisePicker.Items.Add("Running");
        exercisePicker.Items.Add("Cycling");
        exercisePicker.Items.Add("Swimming");
        exercisePicker.Items.Add("Gym");
        exercisePicker.Items.Add("Football");

        Label durationLabel = new Label
        {
            Text = "Duration",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#17211F")
        };

        Entry durationEntry = new Entry
        {
            Placeholder = "Enter minutes",
            Keyboard = Keyboard.Numeric,
            BackgroundColor = Colors.White
        };

        Label notesLabel = new Label
        {
            Text = "Notes",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#17211F")
        };

        Editor notesEditor = new Editor
        {
            Placeholder = "Add any notes about your exercise...",
            HeightRequest = 100,
            BackgroundColor = Colors.White
        };

        Button saveButton = new Button
        {
            Text = "Save Exercise",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Color.FromArgb("#FF8A3D"),
            TextColor = Colors.White,
            CornerRadius = 12,
            HeightRequest = 50
        };

        saveButton.Clicked += async (sender, e) =>
        {
            await DisplayAlert(
                "Exercise Saved",
                "Your exercise has been recorded successfully.",
                "OK");
        };

        content.Children.Add(title);
        content.Children.Add(subtitle);
        content.Children.Add(exerciseLabel);
        content.Children.Add(exercisePicker);
        content.Children.Add(durationLabel);
        content.Children.Add(durationEntry);
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