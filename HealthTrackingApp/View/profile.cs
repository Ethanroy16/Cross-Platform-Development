using Microsoft.Maui.Controls.Shapes;

namespace HealthTrackingApp.View;

public class profile : ContentPage
{
    public profile()
    {
        Title = "Profile";

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
            BackgroundColor = Color.FromArgb("#E6F7F5")
        };

        Label title = new Label
        {
            Text = "My Profile",
            FontSize = 32,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#00A896")
        };

        Label subtitle = new Label
        {
            Text = "Manage your personal health information.",
            FontSize = 16,
            TextColor = Color.FromArgb("#6B7A76")
        };

        Border profileCard = new Border
        {
            BackgroundColor = Colors.White,
            Stroke = Color.FromArgb("#C9EAE5"),
            StrokeThickness = 1,
            Padding = 20,
            StrokeShape = new RoundRectangle
            {
                CornerRadius = 15
            }
        };

        VerticalStackLayout profileContent = new VerticalStackLayout
        {
            Spacing = 8
        };

        Label name = new Label
        {
            Text = "Alex Morgan",
            FontSize = 25,
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.Center,
            TextColor = Color.FromArgb("#17211F")
        };

        Label email = new Label
        {
            Text = "alex@example.com",
            FontSize = 15,
            HorizontalOptions = LayoutOptions.Center,
            TextColor = Color.FromArgb("#6B7A76")
        };

        profileContent.Children.Add(name);
        profileContent.Children.Add(email);

        profileCard.Content = profileContent;

        Label informationTitle = new Label
        {
            Text = "Personal Information",
            FontSize = 21,
            FontAttributes = FontAttributes.Bold
        };

        Border ageCard = new Border
        {
            BackgroundColor = Colors.White,
            Stroke = Color.FromArgb("#C9EAE5"),
            StrokeThickness = 1,
            Padding = 15,
            StrokeShape = new RoundRectangle
            {
                CornerRadius = 12
            },
            Content = new Label
            {
                Text = "Age: 21",
                FontSize = 16
            }
        };

        Border heightCard = new Border
        {
            BackgroundColor = Colors.White,
            Stroke = Color.FromArgb("#C9EAE5"),
            StrokeThickness = 1,
            Padding = 15,
            StrokeShape = new RoundRectangle
            {
                CornerRadius = 12
            },
            Content = new Label
            {
                Text = "Height: 178 cm",
                FontSize = 16
            }
        };

        Border weightCard = new Border
        {
            BackgroundColor = Colors.White,
            Stroke = Color.FromArgb("#C9EAE5"),
            StrokeThickness = 1,
            Padding = 15,
            StrokeShape = new RoundRectangle
            {
                CornerRadius = 12
            },
            Content = new Label
            {
                Text = "Weight: 72.4 kg",
                FontSize = 16
            }
        };

        Button editButton = new Button
        {
            Text = "Edit Profile",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Color.FromArgb("#00A896"),
            TextColor = Colors.White,
            CornerRadius = 12,
            HeightRequest = 50
        };

        editButton.Clicked += async (sender, e) =>
        {
            await DisplayAlert(
                "Profile",
                "Profile editing would be available here.",
                "OK");
        };

        content.Children.Add(title);
        content.Children.Add(subtitle);
        content.Children.Add(profileCard);
        content.Children.Add(informationTitle);
        content.Children.Add(ageCard);
        content.Children.Add(heightCard);
        content.Children.Add(weightCard);
        content.Children.Add(editButton);

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