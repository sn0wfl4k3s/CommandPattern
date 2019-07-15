using CommandPattern.Comandos;
using System.Collections.Generic;

namespace CommandPattern
{
    public class Invoker
    {
        private static readonly IDictionary<string, ICommand> comandos = new Dictionary<string, ICommand>
        {
            {"A", new ComandoA() },
            {"B", new ComandoB() },
        };

        public static void Invoke (string comando)
        {
            comandos[comando].Execute();
        }
    }
}
