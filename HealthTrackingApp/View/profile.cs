namespace HealthTrackingApp.View;

public class profile : ContentPage
{
	public profile()
	{

        Title = "Profile";

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
                new ColumnDefinition(GridLength.Star),
                new ColumnDefinition(GridLength.Star)
            },
            Padding = 5
        };


        Button homeButton = new Button
        {
            ImageSource = "home.png",
        };

        homeButton.Clicked += async (sender, e) =>
        {
            await Navigation.PopToRootAsync();
        };

        Button exerciseButton = new Button
        {
            ImageSource = "exercise.png",
        };

        exerciseButton.Clicked += async (sender, e) =>
        {
            await Navigation.PushAsync(new Exercise());
        };

        Button progressButton = new Button
        {
            ImageSource = "progress.png",
        };

        progressButton.Clicked += async (sender, e) =>
        {
            await Navigation.PushAsync(new Progress());
        };

        Button sleepButton = new Button
        {
            ImageSource = "sleep.png",
        };

        sleepButton.Clicked += async (sender, e) =>
        {
            await Navigation.PushAsync(new Sleep());
        };

        Button heartButton = new Button
        {
            ImageSource = "heart.png",
        };

        heartButton.Clicked += async (sender, e) =>
        {
            await Navigation.PushAsync(new Heart());
        };


        navigation.Add(homeButton);
        navigation.Add(exerciseButton);
        navigation.Add(progressButton);
        navigation.Add(sleepButton);
        navigation.Add(heartButton);

        Grid.SetColumn(homeButton, 0);
        Grid.SetColumn(exerciseButton, 1);
        Grid.SetColumn(progressButton, 2);
        Grid.SetColumn(sleepButton, 3);
        Grid.SetColumn(heartButton, 4);

        mainGrid.Add(navigation);
        Grid.SetRow(navigation, 1);


        Content = mainGrid;

        NavigationPage.SetHasNavigationBar(this, false);
    }
}
