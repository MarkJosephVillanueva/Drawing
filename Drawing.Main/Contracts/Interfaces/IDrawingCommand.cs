using Drawing.Main.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Drawing.Contracts.Interfaces
{
    public interface IDrawingCommand
    {
        void Execute();
        void Draw(Canvas canvas, string[] command);
    }
}
