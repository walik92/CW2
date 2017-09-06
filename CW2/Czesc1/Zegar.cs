using System;

namespace CW2
{
    public delegate void DelZgloszenieZegara(Zegar zegar, TimeEventArgs e);

    public class Zegar
    {
        private int _lastSecond;
        public DelZgloszenieZegara ZgloszenieZegara;

        public void Run()
        {
            while (true)
            {
                var date = DateTime.Now;
                if (date.Second != _lastSecond)
                {
                    _lastSecond = date.Second;
                    if (ZgloszenieZegara != null)
                    {
                        ZgloszenieZegara(this, new TimeEventArgs(date.Hour, date.Minute, date.Second));
                    }
                }
            }
        }
    }
}