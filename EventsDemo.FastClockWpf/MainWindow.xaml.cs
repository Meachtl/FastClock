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
        }

        private void MetroWindow_Initialized(object sender, EventArgs e)
        {
            DatePickerDate.SelectedDate = DateTime.Today;
            TextBoxTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void ButtonSetTime_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = (DateTime)(DatePickerDate.SelectedDate);
            DateTime time = DateTime.Parse(TextBlockTime.Text);



            DatePickerDate.SelectedDate = new DateTime(2015, 07, 17);
            TextBoxTime.Text = (new DateTime(2015, 07, 17, 12, 34, 00).ToShortTimeString());

            SetFastClockStartDateAndTime();
        }

        private void SetFastClockStartDateAndTime()
        {

        }

        private void FastClockOneMinuteIsOver(object sender, DateTime fastClockTime)
        {
        }

        private void CheckBoxClockRuns_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ButtonCreateView_Click(object sender, RoutedEventArgs e)
        {
            DigitalClock digitalClock = new DigitalClock();
            digitalClock.Owner = this;
            digitalClock.Show();
        }
    }
}
