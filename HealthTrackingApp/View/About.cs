namespace HealthTrackingApp.View;

public class About : ContentPage
{
    public About()
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
                        Text = "About Health Tracking",
                        FontSize = 30,
                        FontAttributes = FontAttributes.Bold
                    },

                    new Label
                    {
                        Text = "Health Tracking App",
                        FontSize = 22,
                        FontAttributes = FontAttributes.Bold
                    },

                    new Label
                    {
                        Text = "This application is designed to help users monitor their daily health and activity."
                    },

                    new Label
                    {
                        Text = "Features",
                        FontSize = 20,
                        FontAttributes = FontAttributes.Bold
                    },

                    new Label
                    {
                        Text = "• Daily health dashboard\n• Step tracking\n• Water tracking\n• Sleep tracking\n• Heart rate information\n• Weekly progress"
                    },

                    new Label
                    {
                        Text = "The application provides a simple overview of important health information in one place."
                    }
                }
            }
        };
    }
}