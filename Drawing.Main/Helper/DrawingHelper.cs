using Drawing.Main.Models;
using System;

namespace Drawing.Helper
{
    public static class DrawingHelper
    {
		public static void CanvasDefaultvalue(Canvas canvas, char px)
		{
			for (int i = 0; i <= canvas.GetHeight() - 2; i++)
			{
				for (int j = 0; j <= canvas.GetWidth() - 2; j++)
				{
					canvas.AddPixel(i, j, px);
				}
			}
		}

		public static void DrawLine(Canvas canvas, int x1, int y1, int x2, int y2, char px)
		{
			for (int i = y1; i <= y2; i++)
			{
				for (int j = x1; j <= x2; j++)
				{
					canvas.AddPixel(i, j, px);
				}
			}
		}

		public static void PresentCanvas(Canvas canvas)
		{
			var items = canvas.GetPixels();
			for (int vline = 0; vline < canvas.GetHeight(); vline++)
			{
				for (int hline = 0; hline < canvas.GetWidth(); hline++)
				{
					Console.Write(items[vline, hline]);
				}
				Console.WriteLine();
			}
		}
	}
}
