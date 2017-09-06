using System;

namespace CW2
{
    public class Sluchacz
    {
        private readonly string _name;

        public Sluchacz(string name)
        {
            _name = name;
        }

        public void Subskrybuj(Zegar zegar)
        {
            zegar.ZgloszenieZegara += zegar_TimeChanged;
        }

        private void zegar_TimeChanged(object sender, TimeEventArgs e)
        {
            Console.WriteLine("Słuchacz: " + _name + ", godzina "
                              + e.Hour.ToString().PadLeft(2, '0') + ":"
                              + e.Minute.ToString().PadLeft(2, '0') + ":"
                              + e.Second.ToString().PadLeft(2, '0'));
        }
    }
}