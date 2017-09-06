using System;
using System.Runtime.Remoting.Messaging;

namespace CW2.Czesc2
{
    public delegate int AsyncMethodHandler();

    public class Asynchroniczna
    {
        public event AsyncMethodHandler Event;

        public void DodajDelegata(AsyncMethodHandler handler)
        {
            Event += handler;
        }

        public void Run()
        {
            if (Event != null)
            {
                Console.WriteLine("Uruchomiono " + Event.GetInvocationList().Length + " długotrwałych operacji");
                foreach (var handler in Event.GetInvocationList())
                {
                    var value = (AsyncMethodHandler) handler;
                    value.BeginInvoke(EndAsyncEvent, null);
                }
            }
        }

        private void EndAsyncEvent(IAsyncResult result)
        {
            var asyncResult = (AsyncResult) result;
            var invokedMethod = (AsyncMethodHandler) asyncResult.AsyncDelegate;
            var value = invokedMethod.EndInvoke(asyncResult);
            Console.WriteLine("Zakończono operacje, czas przetwarzania " + value + " ms");
        }
    }
}