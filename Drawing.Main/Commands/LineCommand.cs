using Drawing.Exceptions;
using Drawing.Helper;
using Drawing.Main.Models;
using Drawing.Models;
using System;

namespace Drawing.Commands
{
    public class LineCommand : CommandBase
    {
		public LineCommand(string command, ref Canvas canvas) : base(command, ref canvas)
		{
		}

        public override void Execute()
        {
            base.Execute();

            Draw(base._canvas, base._command.Split(" "));
			DrawingHelper.PresentCanvas(base._canvas);
		}

		public override void Draw(Canvas canvas, string[] command)
		{
			base.Draw(canvas, command);

			try
			{
				int x1 = Convert.ToInt32(command[1]);
				int y1 = Convert.ToInt32(command[2]);
				int x2 = Convert.ToInt32(command[3]);
				int y2 = Convert.ToInt32(command[4]);
				if ((x1 == x2 && y1 < y2) || (y1 == y2 && x1 < x2))
				{
					DrawingHelper.DrawLine(canvas, x1, y1, x2, y2, Constants.LINE);
				}
				else
				{
					throw new InvalidArgumentException("Invalid argument. Should be either x1 = x2 and y1 < y2 Or y1= y2 and x1 < x2.");
				}
			}
			catch (FormatException)
			{
				throw new InvalidArgumentException("Invalid argument. Please enter numeric values for x1, y1, x2 and y2.");
			}
			catch (IndexOutOfRangeException)
			{
				throw new OutOfCanvasException("Coordinate is out of canvas range.");
			}
		}
	}
}
