using System;
using System.Threading;

namespace CW2.Czesc2
{
    public class DlugotrwalaOpercja
    {
        private static readonly Random Random = new Random();

        public static int Get()
        {
            //losuj czas uspienia watku 1-10s
            var timeOut = Random.Next(1000, 10000);
            Thread.Sleep(timeOut);
            return timeOut;
        }
    }
}