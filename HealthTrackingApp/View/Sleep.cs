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

        // =========================
        // PAGE CONTENT
        // =========================

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
            Text = "Track your sleep and rest.",
            FontSize = 16,
            TextColor = Color.FromArgb("#6B7A76")
        };

        Border sleepCard = new Border
        {
            BackgroundColor = Colors.White,
            Stroke = Color.FromArgb("#DED8FF"),
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
            FontAttributes = FontAttributes.Bold
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
            FontSize = 21,
            FontAttributes = FontAttributes.Bold
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
            BackgroundColor = Color.FromArgb("#DED8FF"),
            HeightRequest = 10
        };

        Label sleepHistoryTitle = new Label
        {
            Text = "Recent Sleep",
            FontSize = 21,
            FontAttributes = FontAttributes.Bold
        };

        Label monday = new Label
        {
            Text = "Monday                 7h 42m",
            FontSize = 15
        };

        Label sunday = new Label
        {
            Text = "Sunday                  8h 05m",
            FontSize = 15
        };

        Label saturday = new Label
        {
            Text = "Saturday                7h 30m",
            FontSize = 15
        };

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
            await DisplayAlert(
                "Sleep Recorded",
                "Your sleep information has been recorded.",
                "OK");
        };

        content.Children.Add(title);
        content.Children.Add(subtitle);
        content.Children.Add(sleepCard);
        content.Children.Add(goalTitle);
        content.Children.Add(goalText);
        content.Children.Add(sleepProgress);
        content.Children.Add(sleepHistoryTitle);
        content.Children.Add(monday);
        content.Children.Add(sunday);
        content.Children.Add(saturday);
        content.Children.Add(recordButton);

        scrollView.Content = content;

        mainGrid.Add(scrollView, 0, 0);

        // =========================
        // BOTTOM NAVIGATION
        // =========================

        Grid navigation = new Grid
        {
            ColumnDefinitions =
            {
                new ColumnDefinition(GridLength.Star),
                new ColumnDefinition(GridLength.Star),
                new ColumnDefinition(GridLength.Star),
                new ColumnDefinition(GridLength.Star),
                new ColumnDefinition(GridLength.Star)
            },
            Padding = 5,
            BackgroundColor = Colors.White
        };

        Button homeButton = new Button
        {
            Text = "HOME",
            FontSize = 11,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Colors.Transparent,
            TextColor = Color.FromArgb("#6B7A76"),
            Padding = 0
        };

        homeButton.Clicked += async (sender, e) =>
        {
            await Navigation.PopToRootAsync();
        };

        Button exerciseButton = new Button
        {
            Text = "EXERCISE",
            FontSize = 11,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Colors.Transparent,
            TextColor = Color.FromArgb("#6B7A76"),
            Padding = 0
        };

        exerciseButton.Clicked += async (sender, e) =>
        {
            await Navigation.PushAsync(new Exercise());
        };

        Button progressButton = new Button
        {
            Text = "PROGRESS",
            FontSize = 11,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Colors.Transparent,
            TextColor = Color.FromArgb("#6B7A76"),
            Padding = 0
        };

        progressButton.Clicked += async (sender, e) =>
        {
            await Navigation.PushAsync(new Progress());
        };

        Button sleepButton = new Button
        {
            Text = "SLEEP",
            FontSize = 11,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Colors.Transparent,
            TextColor = Color.FromArgb("#7C5CFC"),
            Padding = 0
        };

        sleepButton.Clicked += async (sender, e) =>
        {
            await Navigation.PushAsync(new Sleep());
        };

        Button heartButton = new Button
        {
            Text = "HEART",
            FontSize = 11,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Colors.Transparent,
            TextColor = Color.FromArgb("#6B7A76"),
            Padding = 0
        };

        heartButton.Clicked += async (sender, e) =>
        {
            await Navigation.PushAsync(new Heart());
        };

        navigation.Add(homeButton, 0, 0);
        navigation.Add(exerciseButton, 1, 0);
        navigation.Add(progressButton, 2, 0);
        navigation.Add(sleepButton, 3, 0);
        navigation.Add(heartButton, 4, 0);

        mainGrid.Add(navigation, 0, 1);

        Content = mainGrid;

        NavigationPage.SetHasNavigationBar(this, false);
    }
}