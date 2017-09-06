using System;

namespace CW2
{
    public class TimeEventArgs : EventArgs
    {
        public readonly int Hour;
        public readonly int Minute;
        public readonly int Second;

        public TimeEventArgs(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
    }
}