namespace HealthTrackingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            StepsChart.Drawable = new StepsChartDrawable();
        }

        private async void OnProfileClicked(object? sender, EventArgs e)
        {
            if (UserSession.IsLoggedIn)
            {
                await Navigation.PushAsync(new View.profile());
            }
            else
            {
                await Navigation.PushAsync(new View.Login());
            }
        }

        private async void OnStepsCardTapped(object? sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new View.Progress());
        }

        private async void OnWaterCardTapped(object? sender, TappedEventArgs e)
        {
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


    public class StepsChartDrawable : IDrawable
    {
        private readonly float[] steps =
        {
            6200, 8100, 7350, 9200, 8450, 10200, 7930
        };

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            if (dirtyRect.Width <= 0 || dirtyRect.Height <= 0)
                return;

            const float left = 25;
            const float right = 15;
            const float top = 25;
            const float bottom = 20;
            const float minSteps = 5000;
            const float maxSteps = 11000;

            float chartWidth = dirtyRect.Width - left - right;
            float chartHeight = dirtyRect.Height - top - bottom;

            // Grid lines
            canvas.StrokeSize = 1;
            canvas.StrokeColor = Color.FromArgb("#E7EEEB");

            for (int i = 0; i < 4; i++)
            {
                float y = top + chartHeight / 3 * i;
                canvas.DrawLine(left, y, dirtyRect.Width - right, y);
            }

            // Calculate points
            PointF[] points = new PointF[steps.Length];

            for (int i = 0; i < steps.Length; i++)
            {
                float x = left + chartWidth / (steps.Length - 1) * i;
                float y = top + chartHeight -
                          (steps[i] - minSteps) /
                          (maxSteps - minSteps) * chartHeight;

                points[i] = new PointF(x, y);
            }

            // Line
            canvas.StrokeColor = Color.FromArgb("#19B89A");
            canvas.StrokeSize = 3;

            for (int i = 0; i < points.Length - 1; i++)
                canvas.DrawLine(points[i], points[i + 1]);

            // Points and values
            canvas.FontColor = Color.FromArgb("#17211F");
            canvas.FontSize = 10;

            foreach (PointF point in points)
            {
                canvas.FillColor = Color.FromArgb("#19B89A");
                canvas.FillCircle(point.X, point.Y, 6);

                canvas.FillColor = Colors.White;
                canvas.FillCircle(point.X, point.Y, 2.5f);
            }

            // Step values
            for (int i = 0; i < steps.Length; i++)
            {
                canvas.DrawString(
                    steps[i].ToString("N0"),
                    points[i].X - 20,
                    points[i].Y - 25,
                    40,
                    18,
                    HorizontalAlignment.Center,
                    VerticalAlignment.Center);
            }
        }
    }
}