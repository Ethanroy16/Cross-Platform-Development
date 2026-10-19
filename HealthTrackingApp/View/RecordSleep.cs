using HealthTrackingApp;

namespace HealthTrackingApp.View;

public class RecordSleep : ContentPage
{
    public RecordSleep()
    {
        // Pseudocode: Build the sleep-record form and display the page.

        Title = "Record Sleep";

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
            Spacing = 17,
            BackgroundColor = Color.FromArgb("#F1EDFF")
        };

        Label title = new Label
        {
            Text = "Record Sleep",
            FontSize = 32,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#7C5CFC")
        };

        Label subtitle = new Label
        {
            Text = "Enter the details of your night's sleep.",
            FontSize = 16,
            TextColor = Color.FromArgb("#6B7A76")
        };

        Label dateLabel = new Label
        {
            Text = "Sleep Date",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#7C5CFC")
        };

        DatePicker datePicker = new DatePicker
        {
            Date = DateTime.Today,
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F")
        };

        Label bedtimeLabel = new Label
        {
            Text = "Bedtime",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#7C5CFC")
        };

        TimePicker bedtimePicker = new TimePicker
        {
            Time = new TimeSpan(23, 0, 0),
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F")
        };

        Label wakeLabel = new Label
        {
            Text = "Wake-up Time",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#7C5CFC")
        };

        TimePicker wakePicker = new TimePicker
        {
            Time = new TimeSpan(7, 0, 0),
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F")
        };

        Label qualityLabel = new Label
        {
            Text = "Sleep Quality",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#7C5CFC")
        };

        Picker qualityPicker = new Picker
        {
            Title = "Select sleep quality",
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F")
        };

        qualityPicker.Items.Add("Excellent");
        qualityPicker.Items.Add("Good");
        qualityPicker.Items.Add("Average");
        qualityPicker.Items.Add("Poor");
        qualityPicker.Items.Add("Very Poor");

        Label interruptionsLabel = new Label
        {
            Text = "Night-time Awakenings",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#7C5CFC")
        };

        Stepper interruptionsStepper = new Stepper
        {
            Minimum = 0,
            Maximum = 10,
            Increment = 1,
            Value = 0
        };

        Label interruptionsValue = new Label
        {
            Text = "0 times",
            FontSize = 15,
            TextColor = Color.FromArgb("#6B7A76")
        };

        interruptionsStepper.ValueChanged += (sender, e) =>
        {
            // Pseudocode: Update the number of night-time awakenings.

            interruptionsValue.Text = $"{(int)e.NewValue} times";
        };

        Label napLabel = new Label
        {
            Text = "Did you have a nap?",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#7C5CFC")
        };

        Switch napSwitch = new Switch
        {
            OnColor = Color.FromArgb("#7C5CFC")
        };

        Label caffeineLabel = new Label
        {
            Text = "Caffeine Before Bed",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#7C5CFC")
        };

        Picker caffeinePicker = new Picker
        {
            Title = "Select amount",
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F")
        };

        caffeinePicker.Items.Add("None");
        caffeinePicker.Items.Add("1 drink");
        caffeinePicker.Items.Add("2 drinks");
        caffeinePicker.Items.Add("3+ drinks");

        Label notesLabel = new Label
        {
            Text = "Notes",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#7C5CFC")
        };

        Editor notesEditor = new Editor
        {
            Placeholder = "How did you sleep? Add any notes here...",
            HeightRequest = 110,
            BackgroundColor = Colors.White,
            TextColor = Color.FromArgb("#17211F")
        };

        Button saveButton = new Button
        {
            Text = "Save Sleep Record",
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            BackgroundColor = Color.FromArgb("#7C5CFC"),
            TextColor = Colors.White,
            CornerRadius = 12,
            HeightRequest = 52
        };

        saveButton.Clicked += async (sender, e) =>
        {
            // Pseudocode: Confirm the sleep record and return to the previous page.

            await DisplayAlert(
                "Sleep Saved",
                "Your sleep record has been saved successfully.",
                "OK");

            await Navigation.PopAsync();
        };

        content.Children.Add(title);
        content.Children.Add(subtitle);

        content.Children.Add(dateLabel);
        content.Children.Add(datePicker);

        content.Children.Add(bedtimeLabel);
        content.Children.Add(bedtimePicker);

        content.Children.Add(wakeLabel);
        content.Children.Add(wakePicker);

        content.Children.Add(qualityLabel);
        content.Children.Add(qualityPicker);

        content.Children.Add(interruptionsLabel);
        content.Children.Add(interruptionsStepper);
        content.Children.Add(interruptionsValue);

        content.Children.Add(napLabel);
        content.Children.Add(napSwitch);

        content.Children.Add(caffeineLabel);
        content.Children.Add(caffeinePicker);

        content.Children.Add(notesLabel);
        content.Children.Add(notesEditor);

        content.Children.Add(saveButton);

        scrollView.Content = content;

        mainGrid.Add(scrollView, 0, 0);

        // One reusable navigation bar
        mainGrid.Add(new BottomNav(), 0, 1);

        Content = mainGrid;

        NavigationPage.SetHasNavigationBar(this, false);
    }
}