namespace HealthTrackingApp.View;

public class Settings : ContentPage
{
    public Settings()
    {
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
            Padding = 20,
            Spacing = 15
        };


        content.Children.Add(new Label
        {
            Text = "Settings",
            FontSize = 30,
            FontAttributes = FontAttributes.Bold
        });


        content.Children.Add(new Label
        {
            Text = "Personal Settings",
            FontSize = 20,
            FontAttributes = FontAttributes.Bold
        });


        content.Children.Add(new Label
        {
            Text = "Daily Step Goal"
        });


        content.Children.Add(new Entry
        {
            Placeholder = "10000",
            Keyboard = Keyboard.Numeric
        });


        content.Children.Add(new Label
        {
            Text = "Daily Water Goal"
        });


        content.Children.Add(new Entry
        {
            Placeholder = "2.0 litres"
        });


        content.Children.Add(new Label
        {
            Text = "Sleep Goal"
        });


        content.Children.Add(new Entry
        {
            Placeholder = "8 hours"
        });


        content.Children.Add(new Button
        {
            Text = "Save Settings"
        });


        scrollView.Content = content;

        mainGrid.Add(scrollView);
        Grid.SetRow(scrollView, 0);


        // Bottom Navigation

        Grid navigation = CreateNavigation();

        mainGrid.Add(navigation);
        Grid.SetRow(navigation, 1);


        Content = mainGrid;

        NavigationPage.SetHasNavigationBar(this, false);
    }


    private Grid CreateNavigation()
    {
        Grid navigation = new Grid
        {
            ColumnDefinitions =
            {
                new ColumnDefinition(GridLength.Star),
                new ColumnDefinition(GridLength.Star),
                new ColumnDefinition(GridLength.Star),
                new ColumnDefinition(GridLength.Star)
            },
            Padding = 5
        };


        Button homeButton = new Button
        {
            Text = "Home"
        };

        homeButton.Clicked += async (sender, e) =>
        {
            await Navigation.PopToRootAsync();
        };


        Button progressButton = new Button
        {
            Text = "Progress"
        };

        progressButton.Clicked += async (sender, e) =>
        {
            await Navigation.PushAsync(new Progress());
        };


        Button settingsButton = new Button
        {
            Text = "Settings"
        };


        Button aboutButton = new Button
        {
            Text = "About"
        };

        aboutButton.Clicked += async (sender, e) =>
        {
            await Navigation.PushAsync(new About());
        };


        navigation.Add(homeButton);
        navigation.Add(progressButton);
        navigation.Add(settingsButton);
        navigation.Add(aboutButton);

        Grid.SetColumn(homeButton, 0);
        Grid.SetColumn(progressButton, 1);
        Grid.SetColumn(settingsButton, 2);
        Grid.SetColumn(aboutButton, 3);


        return navigation;
    }
}