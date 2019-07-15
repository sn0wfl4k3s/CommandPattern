using System;

namespace CommandPattern.Comandos
{
    public class ComandoA : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Comando A executado!");
        }
    }
}
