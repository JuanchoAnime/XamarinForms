using SkiaSharp;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PruebaUI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClockPage : ContentPage
    {
        private SKPath Path { get; }


        public ClockPage()
        {
            this.Path = new SKPath();
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1 / 60f), () =>
            {
                CanvasView.InvalidateSurface();
                return true;
            });

            Device.StartTimer(TimeSpan.FromMilliseconds(1000), () =>
            {
                Slider.TranslationX = -80;
                Slider.TranslateTo(80, 0, 800, Easing.Linear);

                return true;
            });
        }

        private SKPaint GetPaintColor(SKPaintStyle style, string hexColor, float strokeWidth = 0, SKStrokeCap cap = SKStrokeCap.Round, bool IsAntialias = true)
        {
            return new SKPaint
            {
                Style = style,
                StrokeWidth = strokeWidth,
                Color = string.IsNullOrWhiteSpace(hexColor) ? SKColors.White : SKColor.Parse(hexColor),
                StrokeCap = cap,
                IsAntialias = IsAntialias
            };
        }

        private static DateTime GetNextAlarm()
        {
            DateTime today = DateTime.Today;
            DateTime possibleDate = new DateTime(today.Year, today.Month, today.Day, 20, 15, 00);
            if (DateTime.Now > possibleDate)
                return possibleDate.AddDays(1);
            return possibleDate;
        }

        private void CanvasView_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKCanvas canvas = e.Surface.Canvas;

            SKPaint strokePaint = GetPaintColor(SKPaintStyle.Stroke, null, 10, SKStrokeCap.Square);
            SKPaint dotPaint = GetPaintColor(SKPaintStyle.Fill, "#DE0469");

            canvas.Clear();

            SKRect arcRect = new SKRect(10, 10, info.Width - 10, info.Height - 10);
            canvas.DrawOval(new SKRect(25, 25, info.Width - 25, info.Height - 25), GetPaintColor(SKPaintStyle.Fill, "#FFFFFF"));

            strokePaint.Shader = SKShader.CreateLinearGradient(
                               new SKPoint(arcRect.Left, arcRect.Top),
                               new SKPoint(arcRect.Right, arcRect.Bottom),
                               new SKColor[] { SKColor.Parse("#DE0469"), SKColors.Transparent },
                               new float[] { 0, 1 },
                               SKShaderTileMode.Repeat);

            Path.ArcTo(arcRect, 45, 105, true);
            canvas.DrawPath(Path, strokePaint);

            canvas.Translate(info.Width / 2, info.Height / 2);
            canvas.Scale(info.Width / 200f);

            canvas.Save();
            canvas.RotateDegrees(240);
            canvas.DrawCircle(0, -75, 2, dotPaint);
            canvas.Restore();

            DateTime dateTime = DateTime.Now;

            //Draw hour hand
            canvas.Save();
            canvas.RotateDegrees(30 * dateTime.Hour + dateTime.Minute / 2f);
            canvas.DrawLine(0, 5, 0, -60, GetPaintColor(SKPaintStyle.Stroke, "#262626", 4, SKStrokeCap.Square));
            canvas.Restore();

            //Draw minute hand
            canvas.Save();
            canvas.RotateDegrees(6 * dateTime.Minute + dateTime.Second / 10f);
            canvas.DrawLine(0, 10, 0, -90, GetPaintColor(SKPaintStyle.Stroke, "#DE0469", 2, SKStrokeCap.Square));
            canvas.Restore();

            canvas.DrawCircle(0, 0, 5, dotPaint);

            SecondsTxt.Text = dateTime.Second.ToString("00");
            TimeTxt.Text = dateTime.ToString("hh:mm");
            PeriodTxt.Text = dateTime.Hour >= 12 ? "PM" : "AM";

            var alarmDiff = GetNextAlarm() - dateTime;
            AlarmTxt.Text = $"{alarmDiff.Hours}h {alarmDiff.Minutes}m until next alarm";
        }
    }
}