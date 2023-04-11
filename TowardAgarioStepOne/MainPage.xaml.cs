using System.Diagnostics;

namespace TowardAgarioStepOne
{
    public partial class MainPage : ContentPage
    {
        private WorldModel circle;
        private bool isInitialized;
        private IDispatcherTimer timer;
        private int seconds;
        private double totalTime;

        public MainPage()
        {
            InitializeComponent();
            circle = new WorldModel(10, 500, 500);
            isInitialized = false;
            timer = Dispatcher.CreateTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += (s, e) => GameStep();
            timer.Start();
        }

        /// <summary>
        ///    Called when the window is resized.  
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            Debug.WriteLine($"OnSizeAllocated {width} {height}");

            if (!isInitialized)
            {
                isInitialized = true;
                InitializeGameLogic();
            }
        }

        public void InitializeGameLogic()
        {
            PlaySurface.Drawable = new WorldDrawable(circle, PlaySurface);
        }

        public void GameStep()
        {
            circle.AdvanceGameOneStep();
            PlaySurface.Invalidate();
            circleCenter.Text = $"({circle.x}, {circle.y})";
            direction.Text = $"({circle.direction})";

            totalTime += timer.Interval.TotalMilliseconds;
            Debug.WriteLine($"Total time in milliseconds {totalTime}");
            FPS.Text = (totalTime / seconds).ToString();
            seconds++;
        }
    }
}