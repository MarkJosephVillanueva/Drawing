using Drawing.Contracts.Interfaces;
using Drawing.Exceptions;
using Drawing.Helper;
using Drawing.Main.Models;
using Drawing.Models;
using System;

namespace Drawing.Commands
{
    public class CanvasCommand : CommandBase
	{
		public CanvasCommand(string command, ref Canvas canvas) : base(command, ref canvas)
        {
        }

        public override void Execute()
        {
			base.Execute();

			var cmd = base._command.Split(" ");

			try
			{
				base._canvas.SetHeight(Convert.ToInt32(cmd[2]));
				base._canvas.SetWidth(Convert.ToInt32(cmd[1]));
				base._canvas.SetPixels();
			}
			catch (FormatException)
			{
				throw new InvalidArgumentException("Invalid argument! Please enter numeric value for height and width.");
			}

			DrawingHelper.CanvasDefaultvalue(base._canvas, ' ');
			Draw(base._canvas, cmd);
			DrawingHelper.PresentCanvas(base._canvas);
		}

		public override void Draw(Canvas canvas, string[] command)
		{
			base.Draw(canvas, command);

			try
			{
				int width = canvas.GetWidth();
				int height = canvas.GetHeight();
				DrawingHelper.DrawLine(canvas, 0, 0, width - 1, 0, Constants.H_BORDER);
				DrawingHelper.DrawLine(canvas, 0, height - 1, width - 1, height - 1, Constants.H_BORDER);
				DrawingHelper.DrawLine(canvas, 0, 1, 0, height - 2, Constants.V_BORDER);
				DrawingHelper.DrawLine(canvas, width - 1, 1, width - 1, height - 2, Constants.V_BORDER);
			}
			catch (Exception)
			{
				throw new OutOfCanvasException("Coordinate is out of canvas range.");
			}
		}
	}
}
