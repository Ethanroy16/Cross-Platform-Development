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

        // =========================
        // PAGE CONTENT
        // =========================

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

        // Stats

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
            Stroke = Color.FromArgb("#D7E5FF"),
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
            FontAttributes = FontAttributes.Bold
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
            Stroke = Color.FromArgb("#D7E5FF"),
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
            FontAttributes = FontAttributes.Bold
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

        // Weekly summary

        Label weeklyTitle = new Label
        {
            Text = "Weekly Summary",
            FontSize = 21,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#17211F")
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
            BackgroundColor = Color.FromArgb("#D7E5FF"),
            HeightRequest = 10
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
        content.Children.Add(profileButton);

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
            TextColor = Color.FromArgb("#3B82F6"),
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