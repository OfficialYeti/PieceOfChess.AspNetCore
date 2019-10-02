using System;
using System.Collections.Generic;
using System.Text;

namespace PieceOfChess.Domain.Moves
{
    public class KnightMove : Move
    {
        public override IEnumerable<FigurePosition> GetPossibilities(
            FigurePosition actualPosition)
        {
            var result = new List<FigurePosition>();

            if (actualPosition.X < 8 && actualPosition.Y < 7)
                result.Add(FigurePosition.From(actualPosition.X + 1, actualPosition.Y + 2));
            if (actualPosition.X > 1 && actualPosition.Y > 2)
                result.Add(FigurePosition.From(actualPosition.X - 1, actualPosition.Y - 2));
            if (actualPosition.X < 7 && actualPosition.Y < 8)
                result.Add(FigurePosition.From(actualPosition.X + 2, actualPosition.Y + 1));
            if (actualPosition.X > 2 && actualPosition.Y > 1)
                result.Add(FigurePosition.From(actualPosition.X - 2, actualPosition.Y - 1));
            if (actualPosition.X < 8 && actualPosition.Y > 2)
                result.Add(FigurePosition.From(actualPosition.X + 1, actualPosition.Y - 2));
            if (actualPosition.X > 1 && actualPosition.Y < 7)
                result.Add(FigurePosition.From(actualPosition.X - 1, actualPosition.Y + 2));
            if (actualPosition.X > 2 && actualPosition.Y < 8)
                result.Add(FigurePosition.From(actualPosition.X - 2, actualPosition.Y + 1));
            if (actualPosition.X < 7 && actualPosition.Y > 1)
                result.Add(FigurePosition.From(actualPosition.X + 2, actualPosition.Y - 1));


            return result;
        }
    }
}
