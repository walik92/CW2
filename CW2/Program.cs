using System;
using CW2.Czesc2;

namespace CW2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //aby przetestowac czesc zadania nalezy zakomentowac lub odkomentowac metodę
            //RunCzesc1();
            RunCzesc2();
        }

        private static void RunCzesc1()
        {
            var zegar = new Zegar();

            var sluchacz1 = new Sluchacz("Piewrszy");
            sluchacz1.Subskrybuj(zegar);

            var sluchacz2 = new Sluchacz("Drugi");
            sluchacz2.Subskrybuj(zegar);

            var sluchacz3 = new Sluchacz("Trzeci");
            sluchacz3.Subskrybuj(zegar);

            var sluchacz4 = new Sluchacz("Czwarty");
            sluchacz4.Subskrybuj(zegar);

            zegar.Run();
        }

        private static void RunCzesc2()
        {
            var asynchroniczna = new Asynchroniczna();

            asynchroniczna.DodajDelegata(DlugotrwalaOpercja.Get);
            asynchroniczna.DodajDelegata(DlugotrwalaOpercja.Get);
            asynchroniczna.DodajDelegata(DlugotrwalaOpercja.Get);
            asynchroniczna.DodajDelegata(DlugotrwalaOpercja.Get);
            asynchroniczna.DodajDelegata(DlugotrwalaOpercja.Get);
            asynchroniczna.DodajDelegata(DlugotrwalaOpercja.Get);
            asynchroniczna.DodajDelegata(DlugotrwalaOpercja.Get);
            asynchroniczna.DodajDelegata(DlugotrwalaOpercja.Get);

            asynchroniczna.Run();
            Console.ReadLine();
        }
    }
}