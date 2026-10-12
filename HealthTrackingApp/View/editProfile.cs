namespace HealthTrackingApp.View;

public class editProfile : ContentPage
{
    public editProfile()
    {
        Title = "Edit Profile";

        ScrollView scrollView = new ScrollView();

        VerticalStackLayout content = new VerticalStackLayout
        {
            Padding = 25,
            Spacing = 18,
            BackgroundColor = Color.FromArgb("#E6F7F5")
        };

        // =========================================
        // TITLE
        // =========================================

        Label title = new Label
        {
            Text = "Edit Profile",
            FontSize = 32,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#00A896")
        };

        Label subtitle = new Label
        {
            Text = "Update your personal information below.",
            FontSize = 16,
            TextColor = Color.FromArgb("#52615D")
        };

        // =========================================
        // NAME
        // =========================================

        Label nameLabel = CreateLabel("Full Name");

        Entry nameEntry = new Entry
        {
            Placeholder = "Enter your name",
            Text = "Alex Morgan",
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F"),
            PlaceholderColor = Color.FromArgb("#687873")
        };

        // =========================================
        // EMAIL
        // =========================================

        Label emailLabel = CreateLabel("Email Address");

        Entry emailEntry = new Entry
        {
            Placeholder = "Enter your email",
            Text = "alex@example.com",
            Keyboard = Keyboard.Email,
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F"),
            PlaceholderColor = Color.FromArgb("#687873")
        };

        // =========================================
        // AGE
        // =========================================

        Label ageLabel = CreateLabel("Age");

        Entry ageEntry = new Entry
        {
            Placeholder = "Enter your age",
            Text = "21",
            Keyboard = Keyboard.Numeric,
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F"),
            PlaceholderColor = Color.FromArgb("#687873")
        };

        // =========================================
        // HEIGHT
        // =========================================

        Label heightLabel = CreateLabel("Height");

        Entry heightEntry = new Entry
        {
            Placeholder = "Enter height in cm",
            Text = "178",
            Keyboard = Keyboard.Numeric,
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F"),
            PlaceholderColor = Color.FromArgb("#687873")
        };

        // =========================================
        // WEIGHT
        // =========================================

        Label weightLabel = CreateLabel("Weight");

        Entry weightEntry = new Entry
        {
            Placeholder = "Enter weight in kg",
            Text = "72.4",
            Keyboard = Keyboard.Numeric,
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F"),
            PlaceholderColor = Color.FromArgb("#687873")
        };

        // =========================================
        // ACTIVITY LEVEL
        // =========================================

        Label activityLabel = CreateLabel("Activity Level");

        Picker activityPicker = new Picker
        {
            Title = "Choose activity level",
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F"),
            TitleColor = Color.FromArgb("#687873")
        };

        activityPicker.Items.Add("Not very active");
        activityPicker.Items.Add("Lightly active");
        activityPicker.Items.Add("Moderately active");
        activityPicker.Items.Add("Very active");
        activityPicker.Items.Add("Extremely active");

        // =========================================
        // DAILY STEP GOAL
        // =========================================

        Label stepsLabel = CreateLabel("Daily Step Goal");

        Entry stepsEntry = new Entry
        {
            Placeholder = "Enter daily step goal",
            Text = "10000",
            Keyboard = Keyboard.Numeric,
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F"),
            PlaceholderColor = Color.FromArgb("#687873")
        };

        // =========================================
        // SAVE BUTTON
        // =========================================

        Button saveButton = new Button
        {
            Text = "Save Changes",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Color.FromArgb("#00A896"),
            TextColor = Colors.White,
            CornerRadius = 12,
            HeightRequest = 52,
            Margin = new Thickness(0, 10, 0, 0)
        };

        saveButton.Clicked += async (sender, e) =>
        {
            await DisplayAlert(
                "Profile Updated",
                "Your profile has been updated successfully.",
                "OK");

            await Navigation.PopAsync();
        };

        // =========================================
        // CANCEL BUTTON
        // =========================================

        Button cancelButton = new Button
        {
            Text = "Cancel",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#00A896"),
            BorderColor = Color.FromArgb("#00A896"),
            BorderWidth = 1,
            CornerRadius = 12,
            HeightRequest = 52
        };

        cancelButton.Clicked += async (sender, e) =>
        {
            await Navigation.PopAsync();
        };

        // =========================================
        // ADD EVERYTHING
        // =========================================

        content.Children.Add(title);
        content.Children.Add(subtitle);

        content.Children.Add(nameLabel);
        content.Children.Add(nameEntry);

        content.Children.Add(emailLabel);
        content.Children.Add(emailEntry);

        content.Children.Add(ageLabel);
        content.Children.Add(ageEntry);

        content.Children.Add(heightLabel);
        content.Children.Add(heightEntry);

        content.Children.Add(weightLabel);
        content.Children.Add(weightEntry);

        content.Children.Add(activityLabel);
        content.Children.Add(activityPicker);

        content.Children.Add(stepsLabel);
        content.Children.Add(stepsEntry);

        content.Children.Add(saveButton);
        content.Children.Add(cancelButton);

        scrollView.Content = content;

        Content = scrollView;

        NavigationPage.SetHasNavigationBar(this, false);
    }

    private Label CreateLabel(string text)
    {
        return new Label
        {
            Text = text,
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#00A896")
        };
    }
}