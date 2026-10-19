namespace HealthTrackingApp.View;

public class Login : ContentPage
{
    public Login()
    {
        // Pseudocode: Build the login form and provide navigation options.

        Title = "Login";

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
            Text = "Welcome Back",
            FontSize = 32,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#19B89A"),
            HorizontalOptions = LayoutOptions.Center
        };

        Label subtitle = new Label
        {
            Text = "Login to your HealthTrack account",
            FontSize = 15,
            TextColor = Color.FromArgb("#687873"),
            HorizontalOptions = LayoutOptions.Center
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
            Placeholder = "Enter your password",
            IsPassword = true,
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F"),
            PlaceholderColor = Color.FromArgb("#687873")
        };

        Button loginButton = new Button
        {
            Text = "Login",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Color.FromArgb("#19B89A"),
            TextColor = Colors.White,
            CornerRadius = 12,
            HeightRequest = 52,
            Margin = new Thickness(0, 10, 0, 0)
        };

        loginButton.Clicked += async (sender, e) =>
        {
            // Pseudocode: Check the login fields, set the session, and return to the root page.

            if (string.IsNullOrWhiteSpace(emailEntry.Text) ||
                string.IsNullOrWhiteSpace(passwordEntry.Text))
            {
                await DisplayAlert(
                    "Missing Information",
                    "Please enter your email and password.",
                    "OK");

                return;
            }

            UserSession.IsLoggedIn = true;

            await DisplayAlert(
                "Login Successful",
                "Welcome back to HealthTrack!",
                "OK");

            await Navigation.PopToRootAsync();
        };

        Label registerText = new Label
        {
            Text = "Don't have an account?",
            FontSize = 13,
            TextColor = Color.FromArgb("#687873"),
            HorizontalOptions = LayoutOptions.Center,
            Margin = new Thickness(0, 8, 0, -10)
        };

        Button registerButton = new Button
        {
            Text = "Create an Account",
            FontSize = 15,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#19B89A"),
            BorderColor = Color.FromArgb("#19B89A"),
            BorderWidth = 1,
            CornerRadius = 12,
            HeightRequest = 50
        };

        registerButton.Clicked += async (sender, e) =>
        {
            // Pseudocode: Open the registration page.

            await Navigation.PushAsync(new Register());
        };

        Button backButton = new Button
        {
            Text = "Back",
            FontSize = 14,
            BackgroundColor = Colors.Transparent,
            TextColor = Color.FromArgb("#687873"),
            HeightRequest = 45
        };

        backButton.Clicked += async (sender, e) =>
        {
            // Pseudocode: Return to the previous page.

            await Navigation.PopAsync();
        };

        content.Children.Add(title);
        content.Children.Add(subtitle);

        content.Children.Add(emailLabel);
        content.Children.Add(emailEntry);

        content.Children.Add(passwordLabel);
        content.Children.Add(passwordEntry);

        content.Children.Add(loginButton);

        content.Children.Add(registerText);
        content.Children.Add(registerButton);

        content.Children.Add(backButton);

        scrollView.Content = content;

        Content = scrollView;
    }

    private Label CreateLabel(string text)
    {
        // Pseudocode: Create a consistently styled login field label.

        return new Label
        {
            Text = text,
            FontSize = 15,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#19B89A")
        };
    }
}