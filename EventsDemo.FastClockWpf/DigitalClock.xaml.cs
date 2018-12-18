using System;

namespace EventsDemo.FastClockWpf
{
    /// <summary>
    /// Interaction logic for DigitalClock.xaml
    /// </summary>
    public partial class DigitalClock
    {
        private void UpdateTime(object sender, DateTime time)
        {

            TextBlockClock.Text = FastClock.FastClock.Instance.Time.ToShortTimeString();
        }

        public DigitalClock()
        {
            InitializeComponent();
            
            FastClock.FastClock.Instance.OneMinuteIsOver += UpdateTime;

            UpdateTime(this, FastClock.FastClock.Instance.Time);
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
        }

    }
}
