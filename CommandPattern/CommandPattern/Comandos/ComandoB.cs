using System;

namespace CommandPattern.Comandos
{
    public class ComandoB : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Comando B executado!");
        }
    }
}
    