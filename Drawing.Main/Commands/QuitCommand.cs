using Drawing.Main.Models;
using System;

namespace Drawing.Commands
{
    public class QuitCommand : CommandBase
    {
        public QuitCommand(string command, ref Canvas canvas) : base(command, ref canvas)
        {
        }

        public override void Execute()
        {
            Console.WriteLine("Exiting Drawing Application!");
            Environment.Exit(0);
        }
    }
}
