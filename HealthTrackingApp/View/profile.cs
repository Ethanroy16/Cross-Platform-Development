using HealthTrackingApp;
using Microsoft.Maui.Controls.Shapes;

namespace HealthTrackingApp.View;

public class profile : ContentPage
{
    public profile()
    {
        // Pseudocode: Build the profile page and provide edit and sign-out actions.

        Title = "Profile";

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

        profileContent.Children.Add(new Label
        {
            Text = "Alex Morgan",
            FontSize = 25,
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.Center,
            TextColor = Color.FromArgb("#00A896")
        });

        profileContent.Children.Add(new Label
        {
            Text = "alex@example.com",
            FontSize = 15,
            HorizontalOptions = LayoutOptions.Center,
            TextColor = Color.FromArgb("#6B7A76")
        });

        profileCard.Content = profileContent;

        Label informationTitle = new Label
        {
            Text = "Personal Information",
            FontSize = 22,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#00A896")
        };

        Border ageCard = CreateInfoCard("Age", "21");
        Border heightCard = CreateInfoCard("Height", "178 cm");
        Border weightCard = CreateInfoCard("Weight", "72.4 kg");

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
            // Pseudocode: Open the edit-profile page.

            await Navigation.PushAsync(new editProfile(), true);
        };

        Button signOutButton = new Button
        {
            Text = "Sign Out",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#FF4D6D"),
            BorderColor = Color.FromArgb("#FF4D6D"),
            BorderWidth = 1,
            CornerRadius = 12,
            HeightRequest = 50
        };

        signOutButton.Clicked += async (sender, e) =>
        {
            // Pseudocode: Confirm sign-out, clear the session, and open login.

            bool answer = await DisplayAlert(
                "Sign Out",
                "Are you sure you want to sign out?",
                "Yes",
                "No");

            if (!answer)
                return;

            UserSession.IsLoggedIn = false;

            await Navigation.PushAsync(new Login());
        };

        content.Children.Add(title);
        content.Children.Add(subtitle);
        content.Children.Add(profileCard);
        content.Children.Add(informationTitle);
        content.Children.Add(ageCard);
        content.Children.Add(heightCard);
        content.Children.Add(weightCard);
        content.Children.Add(editButton);
        content.Children.Add(signOutButton);

        scrollView.Content = content;

        mainGrid.Add(scrollView, 0, 0);

        mainGrid.Add(new BottomNav(), 0, 1);

        Content = mainGrid;

        NavigationPage.SetHasNavigationBar(this, false);
    }

    private Border CreateInfoCard(string title, string value)
    {
        // Pseudocode: Create a styled profile information card.

        VerticalStackLayout layout = new VerticalStackLayout
        {
            Spacing = 4
        };

        layout.Children.Add(new Label
        {
            Text = title,
            FontSize = 13,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#6B7A76")
        });

        layout.Children.Add(new Label
        {
            Text = value,
            FontSize = 17,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#00A896")
        });

        return new Border
        {
            BackgroundColor = Colors.White,
            Stroke = Color.FromArgb("#C9EAE5"),
            StrokeThickness = 1,
            Padding = 15,
            StrokeShape = new RoundRectangle
            {
                CornerRadius = 12
            },
            Content = layout
        };
    }
}