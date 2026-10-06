namespace HealthTrackingApp.View;

public class Settings : ContentPage
{
    public Settings()
    {
        Content = new ScrollView
        {
            Content = new VerticalStackLayout
            {
                Padding = 20,
                Spacing = 15,

                Children =
                {
                    new Label
                    {
                        Text = "Settings",
                        FontSize = 30,
                        FontAttributes = FontAttributes.Bold
                    },

                    new Label
                    {
                        Text = "Personal Settings",
                        FontSize = 20,
                        FontAttributes = FontAttributes.Bold
                    },

                    new Label
                    {
                        Text = "Daily Step Goal"
                    },

                    new Entry
                    {
                        Placeholder = "10000",
                        Keyboard = Keyboard.Numeric
                    },

                    new Label
                    {
                        Text = "Daily Water Goal"
                    },

                    new Entry
                    {
                        Placeholder = "2.0 litres"
                    },

                    new Label
                    {
                        Text = "Sleep Goal"
                    },

                    new Entry
                    {
                        Placeholder = "8 hours"
                    },

                    new Button
                    {
                        Text = "Save Settings"
                    }
                }
            }
        };
    }
}