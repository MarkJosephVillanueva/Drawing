using Drawing.Commands;
using Drawing.Exceptions;
using Drawing.Main.Models;
using Drawing.Models;

namespace Drawing
{
    public class DrawingService
    {
		private Canvas _canvas;

		public DrawingService()
        {
			_canvas = new Canvas();
        }

		public CommandBase GetCommand(string userCommand) 
		{
			CommandBase command;

			switch (userCommand[0])
            {
                case Constants.Canvas_Command:
					command = new CanvasCommand(userCommand, ref _canvas);
					break;
				case Constants.Line_Command:
					command = new LineCommand(userCommand, ref _canvas);
					break;
				case Constants.Quit_Command:
					command = new QuitCommand(userCommand, ref _canvas);
					break;
				default:
					throw new CommandNotFoundException("Command not found!");
			}

			return command;
		}
		
	}
}
