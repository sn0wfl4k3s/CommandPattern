using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Invoker.Invoke("A");
                Invoker.Invoke("B");
                Invoker.Invoke("C");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
