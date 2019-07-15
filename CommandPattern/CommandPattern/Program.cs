using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker.Invoke("A");
            Invoker.Invoke("B");
        }
    }
}
