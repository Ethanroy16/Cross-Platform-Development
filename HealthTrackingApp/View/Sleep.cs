using HealthTrackingApp;
using Microsoft.Maui.Controls.Shapes;

namespace HealthTrackingApp.View;

public class Sleep : ContentPage
{
    public Sleep()
    {
        Title = "Sleep";

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
            BackgroundColor = Color.FromArgb("#F1EDFF")
        };

        Label title = new Label
        {
            Text = "Sleep",
            FontSize = 32,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#7C5CFC")
        };

        Label subtitle = new Label
        {
            Text = "Track your sleep and recovery.",
            FontSize = 16,
            TextColor = Color.FromArgb("#6B7A76")
        };

        Border sleepCard = new Border
        {
            BackgroundColor = Colors.White,
            Stroke = Color.FromArgb("#DDD6FF"),
            StrokeThickness = 1,
            Padding = 20,
            StrokeShape = new RoundRectangle
            {
                CornerRadius = 15
            }
        };

        VerticalStackLayout sleepContent = new VerticalStackLayout
        {
            Spacing = 7
        };

        sleepContent.Children.Add(new Label
        {
            Text = "Last Night",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#7C5CFC")
        });

        sleepContent.Children.Add(new Label
        {
            Text = "7h 42m",
            FontSize = 32,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#7C5CFC")
        });

        sleepContent.Children.Add(new Label
        {
            Text = "Good sleep",
            FontSize = 15,
            TextColor = Color.FromArgb("#6B7A76")
        });

        sleepCard.Content = sleepContent;

        Label goalTitle = new Label
        {
            Text = "Sleep Goal",
            FontSize = 22,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#7C5CFC")
        };

        Label goalText = new Label
        {
            Text = "Your target is 8 hours per night.",
            FontSize = 15,
            TextColor = Color.FromArgb("#6B7A76")
        };

        ProgressBar sleepProgress = new ProgressBar
        {
            Progress = 0.96,
            ProgressColor = Color.FromArgb("#7C5CFC"),
            BackgroundColor = Color.FromArgb("#DDD6FF"),
            HeightRequest = 10
        };

        Label recentTitle = new Label
        {
            Text = "Recent Sleep",
            FontSize = 22,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#7C5CFC")
        };

        Border mondayCard = CreateSleepRecord("Monday", "7h 42m");
        Border sundayCard = CreateSleepRecord("Sunday", "8h 05m");
        Border saturdayCard = CreateSleepRecord("Saturday", "7h 30m");

        Button recordButton = new Button
        {
            Text = "Record Sleep",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Color.FromArgb("#7C5CFC"),
            TextColor = Colors.White,
            CornerRadius = 12,
            HeightRequest = 50
        };

        recordButton.Clicked += async (sender, e) =>
        {
            await Navigation.PushAsync(new RecordSleep());
        };

        content.Children.Add(title);
        content.Children.Add(subtitle);
        content.Children.Add(sleepCard);
        content.Children.Add(goalTitle);
        content.Children.Add(goalText);
        content.Children.Add(sleepProgress);
        content.Children.Add(recentTitle);
        content.Children.Add(mondayCard);
        content.Children.Add(sundayCard);
        content.Children.Add(saturdayCard);
        content.Children.Add(recordButton);

        scrollView.Content = content;

        mainGrid.Add(scrollView, 0, 0);

        // One reusable navigation bar
        mainGrid.Add(new BottomNav(), 0, 1);

        Content = mainGrid;

        NavigationPage.SetHasNavigationBar(this, false);
    }

    private Border CreateSleepRecord(string day, string duration)
    {
        return new Border
        {
            BackgroundColor = Colors.White,
            Stroke = Color.FromArgb("#DDD6FF"),
            StrokeThickness = 1,
            Padding = 15,
            StrokeShape = new RoundRectangle
            {
                CornerRadius = 12
            },
            Content = new Label
            {
                Text = $"{day}                         {duration}",
                FontSize = 15,
                TextColor = Color.FromArgb("#17211F")
            }
        };
    }
}