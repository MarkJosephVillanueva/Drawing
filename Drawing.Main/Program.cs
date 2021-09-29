using Drawing.Contracts.Interfaces;
using System;

namespace Drawing.Main
{
    class Program
    {
        static void Main(string[] args)
        {
			var service = new DrawingService();

			while (true)
			{
				Console.WriteLine("Enter Command[C,L,Q]:");
				var input = Console.ReadLine();
				IDrawingCommand command = service.GetCommand(input);
				try
				{
					if (command == null)
					{
						Console.WriteLine("Bad command. Try again!!\n");
						continue;
					}
					command.Execute();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					Environment.Exit(1);
				}
			}
		}
    }
}
