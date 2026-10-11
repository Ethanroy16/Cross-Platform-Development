namespace HealthTrackingApp.View;

public class Progress : ContentPage
{
    public Progress()
    {
        Title = "Progress";

        Grid mainGrid = new Grid
        {
            RowDefinitions =
            {
                new RowDefinition(GridLength.Star),
                new RowDefinition(75)
            }
        };

        VerticalStackLayout content = new VerticalStackLayout
        {
            Padding = 20,
            Spacing = 20
        };

        Label title = new Label
        {
            Text = " ",
            FontSize = 30,
            FontAttributes = FontAttributes.Bold
        };

        content.Children.Add(title);

        mainGrid.Add(content);
        Grid.SetRow(content, 0);


        // Bottom Navigation

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

        mainGrid.Add(navigation);
        Grid.SetRow(navigation, 1);


        Content = mainGrid;

        NavigationPage.SetHasNavigationBar(this, false);
    }
}