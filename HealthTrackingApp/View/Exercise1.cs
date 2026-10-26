using HealthTrackingApp;
using Microsoft.Maui.Controls.Shapes;

namespace HealthTrackingApp.View;

public class Exercise1 : ContentPage
{
    public Exercise1()
    {
        // Pseudocode: Build the exercise list page, show sample exercise records, and allow new exercises to be added.

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

        Grid titleGrid = new Grid
        {
            ColumnDefinitions =
            {
                new ColumnDefinition(GridLength.Star),
                new ColumnDefinition(GridLength.Auto)
            }
        };

        Label title = new Label
        {
            Text = "Exercise",
            FontSize = 32,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#FF8A3D"),
            VerticalOptions = LayoutOptions.Center
        };

        Button addButton = new Button
        {
            Text = "+",
            FontSize = 28,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Color.FromArgb("#FF8A3D"),
            TextColor = Colors.White,
            CornerRadius = 25,
            WidthRequest = 50,
            HeightRequest = 50,
            Padding = 0
        };

        addButton.Clicked += async (sender, e) =>
        {
            // Pseudocode: Open the exercise page so the user can add a new exercise.

            await Navigation.PushAsync(new Exercise());
        };

        titleGrid.Add(title, 0, 0);
        titleGrid.Add(addButton, 1, 0);

        Label subtitle = new Label
        {
            Text = "View your recorded exercise activities.",
            FontSize = 16,
            TextColor = Color.FromArgb("#6B7A76")
        };

        content.Children.Add(titleGrid);
        content.Children.Add(subtitle);

        Border walkingCard = CreateExerciseCard(
            "Walking",
            "walking.png",
            "24/10/2026",
            "45 minutes",
            "180 kcal",
            "Low",
            "Morning walk around the local area.");

        Border runningCard = CreateExerciseCard(
            "Running",
            "running.png",
            "23/10/2026",
            "30 minutes",
            "320 kcal",
            "High",
            "Morning run around the park.");

        Border cyclingCard = CreateExerciseCard(
            "Cycling",
            "cycling.png",
            "22/10/2026",
            "60 minutes",
            "450 kcal",
            "Medium",
            "Cycling around the countryside.");

        Border swimmingCard = CreateExerciseCard(
            "Swimming",
            "swimming.png",
            "21/10/2026",
            "40 minutes",
            "350 kcal",
            "Medium",
            "Swimming session at the local pool.");

        Border gymCard = CreateExerciseCard(
            "Gym",
            "gym.png",
            "20/10/2026",
            "75 minutes",
            "520 kcal",
            "High",
            "Upper body and strength training session.");

        Border footballCard = CreateExerciseCard(
            "Football",
            "football.png",
            "19/10/2026",
            "90 minutes",
            "680 kcal",
            "High",
            "Competitive five-a-side football match.");

        content.Children.Add(walkingCard);
        content.Children.Add(runningCard);
        content.Children.Add(cyclingCard);
        content.Children.Add(swimmingCard);
        content.Children.Add(gymCard);
        content.Children.Add(footballCard);

        scrollView.Content = content;

        mainGrid.Add(scrollView, 0, 0);

        // One reusable navigation bar
        mainGrid.Add(new BottomNav(), 0, 1);

        Content = mainGrid;

        NavigationPage.SetHasNavigationBar(this, false);
    }

    private Border CreateExerciseCard(
    string exerciseName,
    string imageName,
    string date,
    string duration,
    string calories,
    string intensity,
    string notes)
    {
        // Pseudocode: Create one exercise box with a circular image and recorded exercise information.

        Image exerciseImage = new Image
        {
            Source = imageName,
            WidthRequest = 75,
            HeightRequest = 75,
            Aspect = Aspect.AspectFill
        };

        Border imageCircle = new Border
        {
            WidthRequest = 75,
            HeightRequest = 75,
            StrokeShape = new RoundRectangle
            {
                CornerRadius = 38
            },
            StrokeThickness = 0,
            Content = exerciseImage
        };

        Label nameLabel = new Label
        {
            Text = exerciseName,
            FontSize = 21,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#FF8A3D")
        };

        Label dateLabel = new Label
        {
            Text = $"Date: {date}",
            FontSize = 14,
            TextColor = Color.FromArgb("#17211F")
        };

        Label durationLabel = new Label
        {
            Text = $"Duration: {duration}",
            FontSize = 14,
            TextColor = Color.FromArgb("#17211F")
        };

        Label caloriesLabel = new Label
        {
            Text = $"Calories: {calories}",
            FontSize = 14,
            TextColor = Color.FromArgb("#17211F")
        };

        Label intensityLabel = new Label
        {
            Text = $"Intensity: {intensity}",
            FontSize = 14,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#FF8A3D")
        };

        Label notesLabel = new Label
        {
            Text = $"Notes: {notes}",
            FontSize = 14,
            TextColor = Color.FromArgb("#6B7A76")
        };

        VerticalStackLayout exerciseDetails = new VerticalStackLayout
        {
            Spacing = 4,
            VerticalOptions = LayoutOptions.Center
        };

        exerciseDetails.Children.Add(nameLabel);
        exerciseDetails.Children.Add(dateLabel);
        exerciseDetails.Children.Add(durationLabel);
        exerciseDetails.Children.Add(caloriesLabel);
        exerciseDetails.Children.Add(intensityLabel);

        Grid topSection = new Grid
        {
            ColumnDefinitions =
        {
            new ColumnDefinition(GridLength.Auto),
            new ColumnDefinition(GridLength.Star)
        },
            ColumnSpacing = 15
        };

        topSection.Add(imageCircle, 0, 0);
        topSection.Add(exerciseDetails, 1, 0);

        VerticalStackLayout cardContent = new VerticalStackLayout
        {
            Spacing = 10
        };

        cardContent.Children.Add(topSection);
        cardContent.Children.Add(notesLabel);

        Border card = new Border
        {
            BackgroundColor = Colors.White,
            Stroke = Color.FromArgb("#FFD2B8"),
            StrokeThickness = 1,
            Padding = 15,
            StrokeShape = new RoundRectangle
            {
                CornerRadius = 15
            },
            Content = cardContent
        };

        return card;
    }
}