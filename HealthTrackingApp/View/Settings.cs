using HealthTrackingApp;
using Microsoft.Maui.Controls.Shapes;

namespace HealthTrackingApp.View;

public class Settings : ContentPage
{
    public Settings()
    {
        // Pseudocode: Build the settings page and allow the user to change preferences.

        Title = "Settings";

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
            BackgroundColor = Color.FromArgb("#F4F8F6")
        };

        // Title

        content.Children.Add(new Label
        {
            Text = "Settings",
            FontSize = 32,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#17211F")
        });

        content.Children.Add(new Label
        {
            Text = "Manage your health goals and app preferences.",
            FontSize = 15,
            TextColor = Color.FromArgb("#687873")
        });

        // Personal Goals

        content.Children.Add(new Label
        {
            Text = "Personal Goals",
            FontSize = 21,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#19B89A"),
            Margin = new Thickness(0, 8, 0, 0)
        });

        // Step Goal

        content.Children.Add(CreateSettingLabel("Daily Step Goal"));

        Entry stepsEntry = new Entry
        {
            Placeholder = "10000",
            Text = "10000",
            Keyboard = Keyboard.Numeric,
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F"),
            PlaceholderColor = Color.FromArgb("#687873")
        };

        content.Children.Add(stepsEntry);

        // Water Goal

        content.Children.Add(CreateSettingLabel("Daily Water Goal"));

        Entry waterEntry = new Entry
        {
            Placeholder = "2.0 litres",
            Text = "2.0",
            Keyboard = Keyboard.Numeric,
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F"),
            PlaceholderColor = Color.FromArgb("#687873")
        };

        content.Children.Add(waterEntry);

        // Sleep Goal

        content.Children.Add(CreateSettingLabel("Sleep Goal"));

        Entry sleepEntry = new Entry
        {
            Placeholder = "8 hours",
            Text = "8",
            Keyboard = Keyboard.Numeric,
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F"),
            PlaceholderColor = Color.FromArgb("#687873")
        };

        content.Children.Add(sleepEntry);

        // App Settings

        content.Children.Add(new Label
        {
            Text = "App Settings",
            FontSize = 21,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#19B89A"),
            Margin = new Thickness(0, 8, 0, 0)
        });

        // Notifications

        Border notificationsCard = new Border
        {
            BackgroundColor = Colors.White,
            Stroke = Color.FromArgb("#E3EBE8"),
            StrokeThickness = 1,
            Padding = 15,
            StrokeShape = new RoundRectangle
            {
                CornerRadius = 12
            }
        };

        Grid notificationsGrid = new Grid
        {
            ColumnDefinitions =
            {
                new ColumnDefinition(GridLength.Star),
                new ColumnDefinition(GridLength.Auto)
            }
        };

        VerticalStackLayout notificationsText = new VerticalStackLayout
        {
            Spacing = 3
        };

        notificationsText.Children.Add(new Label
        {
            Text = "Notifications",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#17211F")
        });

        notificationsText.Children.Add(new Label
        {
            Text = "Receive health reminders",
            FontSize = 13,
            TextColor = Color.FromArgb("#687873")
        });

        Switch notificationsSwitch = new Switch
        {
            IsToggled = true,
            OnColor = Color.FromArgb("#19B89A")
        };

        notificationsGrid.Add(notificationsText, 0, 0);
        notificationsGrid.Add(notificationsSwitch, 1, 0);

        notificationsCard.Content = notificationsGrid;

        content.Children.Add(notificationsCard);

        // Dark Mode

        Border darkModeCard = new Border
        {
            BackgroundColor = Colors.White,
            Stroke = Color.FromArgb("#E3EBE8"),
            StrokeThickness = 1,
            Padding = 15,
            StrokeShape = new RoundRectangle
            {
                CornerRadius = 12
            }
        };

        Grid darkModeGrid = new Grid
        {
            ColumnDefinitions =
            {
                new ColumnDefinition(GridLength.Star),
                new ColumnDefinition(GridLength.Auto)
            }
        };

        VerticalStackLayout darkModeText = new VerticalStackLayout
        {
            Spacing = 3
        };

        darkModeText.Children.Add(new Label
        {
            Text = "Dark Mode",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#17211F")
        });

        darkModeText.Children.Add(new Label
        {
            Text = "Change the app appearance",
            FontSize = 13,
            TextColor = Color.FromArgb("#687873")
        });

        Switch darkModeSwitch = new Switch
        {
            IsToggled = false,
            OnColor = Color.FromArgb("#19B89A")
        };

        darkModeGrid.Add(darkModeText, 0, 0);
        darkModeGrid.Add(darkModeSwitch, 1, 0);

        darkModeCard.Content = darkModeGrid;

        content.Children.Add(darkModeCard);

        // Save Button

        Button saveButton = new Button
        {
            Text = "Save Settings",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Color.FromArgb("#19B89A"),
            TextColor = Colors.White,
            CornerRadius = 12,
            HeightRequest = 52,
            Margin = new Thickness(0, 8, 0, 15)
        };

        saveButton.Clicked += async (sender, e) =>
        {
            // Pseudocode: Confirm that the current settings were saved.

            await DisplayAlert(
                "Settings Saved",
                "Your settings have been saved successfully.",
                "OK");
        };

        content.Children.Add(saveButton);

        scrollView.Content = content;

        mainGrid.Add(scrollView, 0, 0);

        // Shared bottom navigation
        mainGrid.Add(new BottomNav(), 0, 1);

        Content = mainGrid;

        NavigationPage.SetHasNavigationBar(this, false);
    }

    private Label CreateSettingLabel(string text)
    {
        // Pseudocode: Create a consistently styled settings label.

        return new Label
        {
            Text = text,
            FontSize = 15,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#17211F")
        };
    }
}