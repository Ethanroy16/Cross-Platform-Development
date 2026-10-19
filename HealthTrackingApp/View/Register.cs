namespace HealthTrackingApp.View;

public class Register : ContentPage
{
    public Register()
    {
        // Pseudocode: Build the registration form and provide navigation to login.

        Title = "Register";

        NavigationPage.SetHasNavigationBar(this, false);

        ScrollView scrollView = new ScrollView();

        VerticalStackLayout content = new VerticalStackLayout
        {
            Padding = 30,
            Spacing = 18,
            BackgroundColor = Color.FromArgb("#F4F8F6")
        };

        Label title = new Label
        {
            Text = "Create Account",
            FontSize = 32,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#19B89A"),
            HorizontalOptions = LayoutOptions.Center
        };

        Label subtitle = new Label
        {
            Text = "Create your HealthTrack account",
            FontSize = 15,
            TextColor = Color.FromArgb("#687873"),
            HorizontalOptions = LayoutOptions.Center
        };

        Label nameLabel = CreateLabel("Full Name");

        Entry nameEntry = new Entry
        {
            Placeholder = "Enter your full name",
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F"),
            PlaceholderColor = Color.FromArgb("#687873")
        };

        Label emailLabel = CreateLabel("Email Address");

        Entry emailEntry = new Entry
        {
            Placeholder = "Enter your email",
            Keyboard = Keyboard.Email,
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F"),
            PlaceholderColor = Color.FromArgb("#687873")
        };

        Label passwordLabel = CreateLabel("Password");

        Entry passwordEntry = new Entry
        {
            Placeholder = "Create a password",
            IsPassword = true,
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F"),
            PlaceholderColor = Color.FromArgb("#687873")
        };

        Label confirmPasswordLabel = CreateLabel("Confirm Password");

        Entry confirmPasswordEntry = new Entry
        {
            Placeholder = "Confirm your password",
            IsPassword = true,
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F"),
            PlaceholderColor = Color.FromArgb("#687873")
        };

        Button registerButton = new Button
        {
            Text = "Register",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Color.FromArgb("#19B89A"),
            TextColor = Colors.White,
            CornerRadius = 12,
            HeightRequest = 52,
            Margin = new Thickness(0, 10, 0, 0)
        };

        registerButton.Clicked += async (sender, e) =>
        {
            // Pseudocode: Validate fields, check passwords, create the session, and return home.

            if (string.IsNullOrWhiteSpace(nameEntry.Text) ||
                string.IsNullOrWhiteSpace(emailEntry.Text) ||
                string.IsNullOrWhiteSpace(passwordEntry.Text) ||
                string.IsNullOrWhiteSpace(confirmPasswordEntry.Text))
            {
                await DisplayAlert(
                    "Missing Information",
                    "Please complete all fields.",
                    "OK");

                return;
            }

            if (passwordEntry.Text != confirmPasswordEntry.Text)
            {
                await DisplayAlert(
                    "Password Error",
                    "The passwords do not match.",
                    "OK");

                return;
            }

            UserSession.IsLoggedIn = true;

            await DisplayAlert(
                "Account Created",
                "Your account has been created successfully.",
                "OK");

            await Navigation.PopToRootAsync();
        };

        Label loginText = new Label
        {
            Text = "Already have an account?",
            FontSize = 13,
            TextColor = Color.FromArgb("#687873"),
            HorizontalOptions = LayoutOptions.Center,
            Margin = new Thickness(0, 8, 0, -10)
        };

        Button loginButton = new Button
        {
            Text = "Back to Login",
            FontSize = 15,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#19B89A"),
            BorderColor = Color.FromArgb("#19B89A"),
            BorderWidth = 1,
            CornerRadius = 12,
            HeightRequest = 50
        };

        loginButton.Clicked += async (sender, e) =>
        {
            // Pseudocode: Return to the login page.

            await Navigation.PopAsync();
        };

        content.Children.Add(title);
        content.Children.Add(subtitle);

        content.Children.Add(nameLabel);
        content.Children.Add(nameEntry);

        content.Children.Add(emailLabel);
        content.Children.Add(emailEntry);

        content.Children.Add(passwordLabel);
        content.Children.Add(passwordEntry);

        content.Children.Add(confirmPasswordLabel);
        content.Children.Add(confirmPasswordEntry);

        content.Children.Add(registerButton);

        content.Children.Add(loginText);
        content.Children.Add(loginButton);

        scrollView.Content = content;

        Content = scrollView;
    }

    private Label CreateLabel(string text)
    {
        // Pseudocode: Create a consistently styled registration field label.

        return new Label
        {
            Text = text,
            FontSize = 15,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#19B89A")
        };
    }
}