using HealthTrackingApp;
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
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#FF4D6D")
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
            FontSize = 22,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#FF4D6D")
        };

        Border todayCard = CreateReading("Today", "58 bpm");
        Border yesterdayCard = CreateReading("Yesterday", "61 bpm");
        Border sundayCard = CreateReading("Sunday", "60 bpm");

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

        // One reusable navigation bar
        mainGrid.Add(new BottomNav(), 0, 1);

        Content = mainGrid;

        NavigationPage.SetHasNavigationBar(this, false);
    }

    private Border CreateReading(string day, string bpm)
    {
        return new Border
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
                Text = $"{day}                         {bpm}",
                FontSize = 15,
                TextColor = Color.FromArgb("#17211F")
            }
        };
    }
}