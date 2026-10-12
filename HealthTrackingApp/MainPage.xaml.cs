namespace HealthTrackingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
<<<<<<< HEAD
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
=======
            InitializeComponent();
        }

        // =========================================
        // BOTTOM NAVIGATION
        // =========================================

        private async void OnHomeClicked(object? sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private async void OnExerciseClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Exercise());
        }

        private async void OnProgressClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Progress());
        }

        private async void OnSleepClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Sleep());
        }

        private async void OnHeartClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Heart());
        }

        private async void OnProfileClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.profile());
        }


        // =========================================
        // DASHBOARD CARDS
        // =========================================

        private async void OnStepsCardTapped(object? sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new View.Progress());
        }

        private async void OnWaterCardTapped(object? sender, TappedEventArgs e)
        {
            // There is currently no separate Water page,
            // so send the user to Progress for now.
            await Navigation.PushAsync(new View.Progress());
        }

        private async void OnSleepCardTapped(object? sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new View.Sleep());
        }

        private async void OnHeartCardTapped(object? sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new View.Heart());
        }
    }


    // =============================================
    // STEPS CHART
    // =============================================

    public class StepsChartDrawable : IDrawable
    {
        private readonly float[] steps =
        {
            6200,
            8100,
            7350,
            9200,
            8450,
            10200,
            7930
        };

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            float width = dirtyRect.Width;
            float height = dirtyRect.Height;

            if (width <= 0 || height <= 0)
                return;

            float leftPadding = 25;
            float rightPadding = 15;
            float topPadding = 25;
            float bottomPadding = 20;

            float chartWidth = width - leftPadding - rightPadding;
            float chartHeight = height - topPadding - bottomPadding;

            float minValue = 5000;
            float maxValue = 11000;

            // -----------------------------------------
            // Horizontal guide lines
            // -----------------------------------------

            canvas.StrokeSize = 1;
            canvas.StrokeColor = Color.FromArgb("#E7EEEB");

            for (int i = 0; i < 4; i++)
            {
                float y = topPadding + (chartHeight / 3 * i);

                canvas.DrawLine(
                    leftPadding,
                    y,
                    width - rightPadding,
                    y);
            }

            // -----------------------------------------
            // Calculate points
            // -----------------------------------------

            PointF[] points = new PointF[steps.Length];

            for (int i = 0; i < steps.Length; i++)
            {
                float x = leftPadding +
                          (chartWidth / (steps.Length - 1)) * i;

                float percentage =
                    (steps[i] - minValue) /
                    (maxValue - minValue);

                float y =
                    topPadding +
                    chartHeight -
                    (percentage * chartHeight);

                points[i] = new PointF(x, y);
            }

            // -----------------------------------------
            // Draw connecting line
            // -----------------------------------------

            canvas.StrokeColor = Color.FromArgb("#19B89A");
            canvas.StrokeSize = 3;

            for (int i = 0; i < points.Length - 1; i++)
            {
                canvas.DrawLine(
                    points[i],
                    points[i + 1]);
            }

            // -----------------------------------------
            // Draw points and values
            // -----------------------------------------

            for (int i = 0; i < points.Length; i++)
            {
                PointF point = points[i];

                // Outer circle
                canvas.FillColor = Color.FromArgb("#19B89A");

                canvas.FillCircle(
                    point.X,
                    point.Y,
                    6);

                // Inner circle
                canvas.FillColor = Colors.White;

                canvas.FillCircle(
                    point.X,
                    point.Y,
                    2.5f);

                // Step value
                canvas.FontColor = Color.FromArgb("#17211F");
                canvas.FontSize = 10;

                string value = steps[i].ToString("N0");

                canvas.DrawString(
                    value,
                    point.X - 20,
                    point.Y - 25,
                    40,
                    18,
                    HorizontalAlignment.Center,
                    VerticalAlignment.Center);
            }
        }
    }
}