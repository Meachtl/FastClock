using System;
using System.Windows.Threading;

namespace EventsDemo.FastClock
{
    public class FastClock
    {
        #region Properties
        public int Factor { get; set; }

        public int Instance { get; set; }

        public bool IsRunning { get; set; }

        public DateTime Time { get; set; }
        #endregion


    }
}
