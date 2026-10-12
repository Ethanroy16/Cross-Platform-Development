using Microsoft.Maui.Controls.Shapes;

namespace HealthTrackingApp.View;

public class Heart : ContentPage
{
    public Heart()
    {
        Title = "Heart Monitoring";

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
            BackgroundColor = Color.FromArgb("#FFF0F3")
        };

        Label title = new Label
        {
            Text = "Heart Monitoring",
            FontSize = 32,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#FF4D6D")
        };

        Label subtitle = new Label
        {
            Text = "View your recent heart rate information.",
            FontSize = 16,
            TextColor = Color.FromArgb("#6B7A76")
        };

        Border heartCard = new Border
        {
            BackgroundColor = Colors.White,
            Stroke = Color.FromArgb("#FFD6DE"),
            StrokeThickness = 1,
            Padding = 20,
            StrokeShape = new RoundRectangle
            {
                CornerRadius = 15
            }
        };

        VerticalStackLayout heartContent = new VerticalStackLayout
        {
            Spacing = 7
        };

        heartContent.Children.Add(new Label
        {
            Text = "Resting Heart Rate",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold
        });

        heartContent.Children.Add(new Label
        {
            Text = "58 bpm",
            FontSize = 32,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#FF4D6D")
        });

        heartContent.Children.Add(new Label
        {
            Text = "Within your normal range",
            FontSize = 15,
            TextColor = Color.FromArgb("#6B7A76")
        });

        heartCard.Content = heartContent;

        Label recentTitle = new Label
        {
            Text = "Recent Readings",
            FontSize = 21,
            FontAttributes = FontAttributes.Bold
        };

        Border todayCard = new Border
        {
            BackgroundColor = Colors.White,
            Stroke = Color.FromArgb("#FFD6DE"),
            StrokeThickness = 1,
            Padding = 15,
            StrokeShape = new RoundRectangle
            {
                CornerRadius = 12
            },
            Content = new Label
            {
                Text = "Today                         58 bpm",
                FontSize = 15
            }
        };

        Border yesterdayCard = new Border
        {
            BackgroundColor = Colors.White,
            Stroke = Color.FromArgb("#FFD6DE"),
            StrokeThickness = 1,
            Padding = 15,
            StrokeShape = new RoundRectangle
            {
                CornerRadius = 12
            },
            Content = new Label
            {
                Text = "Yesterday                    61 bpm",
                FontSize = 15
            }
        };

        Border sundayCard = new Border
        {
            BackgroundColor = Colors.White,
            Stroke = Color.FromArgb("#FFD6DE"),
            StrokeThickness = 1,
            Padding = 15,
            StrokeShape = new RoundRectangle
            {
                CornerRadius = 12
            },
            Content = new Label
            {
                Text = "Sunday                       60 bpm",
                FontSize = 15
            }
        };

        Button recordButton = new Button
        {
            Text = "Record Heart Rate",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Color.FromArgb("#FF4D6D"),
            TextColor = Colors.White,
            CornerRadius = 12,
            HeightRequest = 50
        };

        recordButton.Clicked += async (sender, e) =>
        {
            await DisplayAlert(
                "Heart Rate",
                "Heart rate reading recorded.",
                "OK");
        };

        content.Children.Add(title);
        content.Children.Add(subtitle);
        content.Children.Add(heartCard);
        content.Children.Add(recentTitle);
        content.Children.Add(todayCard);
        content.Children.Add(yesterdayCard);
        content.Children.Add(sundayCard);
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
            TextColor = Color.FromArgb("#6B7A76"),
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
            TextColor = Color.FromArgb("#FF4D6D"),
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