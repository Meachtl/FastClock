using System;
using System.Windows.Threading;

namespace EventsDemo.FastClock
{
    public class FastClock
    {
        #region Fields
        private DispatcherTimer _dispatcherTimer;
        private static FastClock _instance;
        #endregion

        #region Properties
        public int Factor
        {
            set
            {
                if (0 < value && value <= 60000)
                {
                    _dispatcherTimer.Interval = TimeSpan.FromMilliseconds(60000 / value);
                }                
            }
        }

        static public FastClock Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FastClock();
                }
                return _instance;
            }
        }

        public bool IsRunning
        {
            set
            {
                _dispatcherTimer.IsEnabled = value;
            }
            get
            {
                return _dispatcherTimer.IsEnabled;
            }
        }

        public DateTime Time { get; set; }
        #endregion

        #region Constructor
        private FastClock()
        {
            _dispatcherTimer = new DispatcherTimer();

            _dispatcherTimer.Tick += Timer_Tick;
            //_instance.OneMinuteIsOver += OnOneMinuteIsOver;
        }


        #endregion

        //private void OnOneMinuteIsOver(object sender, DateTime time)
        //{
        //    //while (IsRunning)
        //    //{
        //    //    OneMinuteIsOver?.Invoke(this, time);
        //    //}
        //}

        private void Timer_Tick(object sender, EventArgs args)
        {
            Time = Time.AddMinutes(1);
            OneMinuteIsOver?.Invoke(this, Time);

            //_dispatcherTimer.Interval = new TimeSpan(0, 0, Factor);
            //_dispatcherTimer.Start();
        }

        public event EventHandler<DateTime> OneMinuteIsOver;

    }
}
