namespace HealthTrackingApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        StepsChart.Drawable = new StepsChartDrawable();
    }


    private void OnHomeClicked(object sender, EventArgs e)
    {
        // Already on Home
    }


    private async void OnProgressClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new View.Progress());
    }


    private async void OnSettingsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new View.Settings());
    }


    private async void OnAboutClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new View.About());
    }
}


// Steps line chart

public class StepsChartDrawable : IDrawable
{
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        // Sample data for Monday - Sunday

        float[] steps =
        {
            6200,
            8450,
            7100,
            9200,
            7800,
            10500,
            6800
        };


        float width = dirtyRect.Width;
        float height = dirtyRect.Height;

        float highestValue = 12000;


        // Chart settings

        canvas.StrokeColor = Colors.Red;
        canvas.FillColor = Colors.Blue;
        canvas.FontColor = Colors.White;

        canvas.StrokeSize = 3;
        canvas.FontSize = 11;


        // Space around the chart

        float leftPadding = 45;
        float rightPadding = 45;

        float topPadding = 30;
        float bottomPadding = 10;


        float chartWidth =
            width - leftPadding - rightPadding;

        float chartHeight =
            height - topPadding - bottomPadding;


        // Create points

        PointF[] points = new PointF[steps.Length];


        for (int i = 0; i < steps.Length; i++)
        {
            // Spread points from left to right
            // keeps them away from the edges

            float x =
                leftPadding +
                (chartWidth / 6) * i;


            float y =
                topPadding +
                chartHeight -
                ((steps[i] / highestValue) * chartHeight);


            points[i] = new PointF(x, y);
        }


        // Draw the line

        for (int i = 0; i < points.Length - 1; i++)
        {
            canvas.DrawLine(
                points[i],
                points[i + 1]);
        }


        // Draw dots and numbers

        for (int i = 0; i < points.Length; i++)
        {
            // Draw dot

            canvas.FillCircle(
                points[i].X,
                points[i].Y,
                5);


            // Draw number above dot

            string stepText =
                steps[i].ToString("N0");


            canvas.DrawString(
                stepText,
                points[i].X - 30,
                points[i].Y - 25,
                60,
                18,
                HorizontalAlignment.Center,
                VerticalAlignment.Center);
        }
    }
}