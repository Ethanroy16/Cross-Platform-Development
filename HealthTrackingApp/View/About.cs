namespace HealthTrackingApp.View;

public class About : ContentPage
{
    public About()
    {
        Title = "About";

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
            Text = "About Health Tracking",
            FontSize = 30,
            FontAttributes = FontAttributes.Bold
        });


        content.Children.Add(new Label
        {
            Text = "Health Tracking App",
            FontSize = 22,
            FontAttributes = FontAttributes.Bold
        });


        content.Children.Add(new Label
        {
            Text = "This application is designed to help users monitor their daily health and activity."
        });


        content.Children.Add(new Label
        {
            Text = "Features",
            FontSize = 20,
            FontAttributes = FontAttributes.Bold
        });


        content.Children.Add(new Label
        {
            Text = "• Daily health dashboard\n• Step tracking\n• Water tracking\n• Sleep tracking\n• Heart rate information\n• Weekly progress"
        });


        content.Children.Add(new Label
        {
            Text = "The application provides a simple overview of important health information in one place."
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

        settingsButton.Clicked += async (sender, e) =>
        {
            await Navigation.PushAsync(new Settings());
        };


        Button aboutButton = new Button
        {
            Text = "About"
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