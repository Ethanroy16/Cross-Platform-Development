namespace HealthTrackingApp.View;

public class Exercise : ContentPage
{
    public Exercise()
    {
        Title = "Exercise";

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
            BackgroundColor = Color.FromArgb("#FFF1E7")
        };

        Label title = new Label
        {
            Text = "Exercise",
            FontSize = 32,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#FF8A3D")
        };

        Label subtitle = new Label
        {
            Text = "Record and track your daily activity.",
            FontSize = 16,
            TextColor = Color.FromArgb("#6B7A76")
        };

        // Exercise type

        Label exerciseLabel = new Label
        {
            Text = "Exercise Type",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#17211F")
        };

        Picker exercisePicker = new Picker
        {
            Title = "Choose exercise",
            BackgroundColor = Colors.White
        };

        exercisePicker.Items.Add("Walking");
        exercisePicker.Items.Add("Running");
        exercisePicker.Items.Add("Cycling");
        exercisePicker.Items.Add("Swimming");
        exercisePicker.Items.Add("Gym");
        exercisePicker.Items.Add("Football");

        // Duration

        Label durationLabel = new Label
        {
            Text = "Duration",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#17211F")
        };

        Entry durationEntry = new Entry
        {
            Placeholder = "Enter minutes",
            Keyboard = Keyboard.Numeric,
            BackgroundColor = Colors.White
        };

        // Notes

        Label notesLabel = new Label
        {
            Text = "Notes",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#17211F")
        };

        Editor notesEditor = new Editor
        {
            Placeholder = "Add any notes about your exercise...",
            HeightRequest = 100,
            BackgroundColor = Colors.White
        };

        // Save button

        Button saveButton = new Button
        {
            Text = "Save Exercise",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Color.FromArgb("#FF8A3D"),
            TextColor = Colors.White,
            CornerRadius = 12,
            HeightRequest = 50
        };

        saveButton.Clicked += async (sender, e) =>
        {
            await DisplayAlert(
                "Exercise Saved",
                "Your exercise has been recorded successfully.",
                "OK");
        };

        content.Children.Add(title);
        content.Children.Add(subtitle);
        content.Children.Add(exerciseLabel);
        content.Children.Add(exercisePicker);
        content.Children.Add(durationLabel);
        content.Children.Add(durationEntry);
        content.Children.Add(notesLabel);
        content.Children.Add(notesEditor);
        content.Children.Add(saveButton);

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
            TextColor = Color.FromArgb("#FF8A3D"),
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