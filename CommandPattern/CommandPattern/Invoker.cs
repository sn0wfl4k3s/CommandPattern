using System;
using System.Collections.Generic;
using CommandPattern.Comandos;

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
            try
            {
                comandos[comando].Execute();
            }
            catch
            {
                throw new Exception($"Comando {comando} não encontrado!");
            }
        }
    }
}
