using HealthTrackingApp;
using Microsoft.Maui.Controls.Shapes;

namespace HealthTrackingApp.View;

public class Progress : ContentPage
{
    public Progress()
    {
        Title = "Progress";

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
            Text = "Progress",
            FontSize = 32,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#3B82F6")
        };

        Label subtitle = new Label
        {
            Text = "See how you are progressing each week.",
            FontSize = 16,
            TextColor = Color.FromArgb("#6B7A76")
        };

        Grid statsGrid = new Grid
        {
            ColumnDefinitions =
            {
                new ColumnDefinition(GridLength.Star),
                new ColumnDefinition(GridLength.Star)
            },
            ColumnSpacing = 12
        };

        Border stepsCard = new Border
        {
            BackgroundColor = Colors.White,
            Stroke = Color.FromArgb("#CFE0FF"),
            StrokeThickness = 1,
            Padding = 15,
            StrokeShape = new RoundRectangle
            {
                CornerRadius = 15
            }
        };

        VerticalStackLayout stepsContent = new VerticalStackLayout
        {
            Spacing = 5
        };

        stepsContent.Children.Add(new Label
        {
            Text = "Steps",
            FontSize = 15,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#3B82F6")
        });

        stepsContent.Children.Add(new Label
        {
            Text = "8,420",
            FontSize = 25,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#3B82F6")
        });

        stepsContent.Children.Add(new Label
        {
            Text = "This week",
            FontSize = 13,
            TextColor = Color.FromArgb("#6B7A76")
        });

        stepsCard.Content = stepsContent;

        Border exerciseCard = new Border
        {
            BackgroundColor = Colors.White,
            Stroke = Color.FromArgb("#CFE0FF"),
            StrokeThickness = 1,
            Padding = 15,
            StrokeShape = new RoundRectangle
            {
                CornerRadius = 15
            }
        };

        VerticalStackLayout exerciseContent = new VerticalStackLayout
        {
            Spacing = 5
        };

        exerciseContent.Children.Add(new Label
        {
            Text = "Exercise",
            FontSize = 15,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#3B82F6")
        });

        exerciseContent.Children.Add(new Label
        {
            Text = "3h 25m",
            FontSize = 25,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#3B82F6")
        });

        exerciseContent.Children.Add(new Label
        {
            Text = "This week",
            FontSize = 13,
            TextColor = Color.FromArgb("#6B7A76")
        });

        exerciseCard.Content = exerciseContent;

        statsGrid.Add(stepsCard, 0, 0);
        statsGrid.Add(exerciseCard, 1, 0);

        Label weeklyTitle = new Label
        {
            Text = "Weekly Activity",
            FontSize = 22,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#3B82F6")
        };

        Label weeklyText = new Label
        {
            Text = "You have completed 78% of your weekly activity goal.",
            FontSize = 15,
            TextColor = Color.FromArgb("#6B7A76")
        };

        ProgressBar progressBar = new ProgressBar
        {
            Progress = 0.78,
            ProgressColor = Color.FromArgb("#3B82F6"),
            BackgroundColor = Color.FromArgb("#CFE0FF"),
            HeightRequest = 10
        };

        Label goalLabel = new Label
        {
            Text = "Weekly Goal: 10,000 steps per day",
            FontSize = 15,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#3B82F6")
        };

        Button profileButton = new Button
        {
            Text = "View Profile",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Color.FromArgb("#3B82F6"),
            TextColor = Colors.White,
            CornerRadius = 12,
            HeightRequest = 50
        };

        profileButton.Clicked += async (sender, e) =>
        {
            await Navigation.PushAsync(new profile());
        };

        content.Children.Add(title);
        content.Children.Add(subtitle);
        content.Children.Add(statsGrid);
        content.Children.Add(weeklyTitle);
        content.Children.Add(weeklyText);
        content.Children.Add(progressBar);
        content.Children.Add(goalLabel);
        content.Children.Add(profileButton);

        scrollView.Content = content;

        mainGrid.Add(scrollView, 0, 0);

        // One reusable navigation bar
        mainGrid.Add(new BottomNav(), 0, 1);

        Content = mainGrid;

        NavigationPage.SetHasNavigationBar(this, false);
    }
}