using System;
using System.Windows;

namespace EventsDemo.FastClockWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            FastClock.FastClock.Instance.OneMinuteIsOver += FastClockOneMinuteIsOver;

        }

        private void MetroWindow_Initialized(object sender, EventArgs e)
        {
            DatePickerDate.SelectedDate = DateTime.Today;
            TextBoxTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void ButtonSetTime_Click(object sender, RoutedEventArgs e)
        {
            

            //DatePickerDate.SelectedDate = new DateTime(2015, 07, 17);
            //TextBoxTime.Text = (new DateTime(2015, 07, 17, 12, 34, 00).ToShortTimeString());

            SetFastClockStartDateAndTime();
        }

        private void SetFastClockStartDateAndTime()
        {
            //DateTime date = (DateTime)(DatePickerDate.SelectedDate);
            //DateTime time = DateTime.Parse(TextBlockTime.Text);

            TextBlockDate.Text = DatePickerDate.Text;
            TextBlockTime.Text = TextBoxTime.Text;
            FastClock.FastClock.Instance.Time = DateTime.Parse(DatePickerDate.Text + " " + TextBoxTime.Text);

        }

        private void FastClockOneMinuteIsOver(object sender, DateTime fastClockTime)
        {
            TextBlockDate.Text = FastClock.FastClock.Instance.Time.ToShortDateString();
            TextBlockTime.Text = FastClock.FastClock.Instance.Time.ToShortTimeString();
        }

        private void CheckBoxClockRuns_Click(object sender, RoutedEventArgs e)
        {
            SliderFactor.IsEnabled = !CheckBoxClockRuns.IsChecked.Value;
            TextBoxFactor.IsEnabled = !CheckBoxClockRuns.IsChecked.Value;
            ButtonSetTime.IsEnabled = !CheckBoxClockRuns.IsChecked.Value;


            if (CheckBoxClockRuns.IsChecked.Value)
            {
                //SliderFactor.IsEnabled = false;

                int.TryParse(TextBoxFactor.Text, out int factor);
                FastClock.FastClock.Instance.Factor = factor;

                FastClock.FastClock.Instance.IsRunning = true;
            }
            else
            {
                FastClock.FastClock.Instance.IsRunning = false;                
            }
        }

        private void ButtonCreateView_Click(object sender, RoutedEventArgs e)
        {
            DigitalClock digitalClock = new DigitalClock();
            digitalClock.Owner = this;
            digitalClock.Show();
        }

       
    }
}
