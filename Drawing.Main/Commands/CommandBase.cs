using Drawing.Contracts.Interfaces;
using Drawing.Exceptions;
using Drawing.Main.Models;

namespace Drawing.Commands
{
    public abstract class CommandBase : IDrawingCommand
    {
        protected readonly string _command;
        protected Canvas _canvas;

        public CommandBase(string command, ref Canvas canvas)
        {
            _command = command;
            _canvas = canvas;
        }

        public virtual void Execute() 
        {
            if (_command == null)
                throw new InvalidArgumentException("Invalid argument passed to Canvas command!");
        }
        public virtual void Draw(Canvas canvas, string[] command)
        {
            if (canvas == null)
            {
                throw new CanvasNotFoundException("Canvas not found!");
            }
            if (command == null || command.Length <= 0)
            {
                throw new InvalidArgumentException("Please pass a valid command argument");
            }
        }
    }
}
