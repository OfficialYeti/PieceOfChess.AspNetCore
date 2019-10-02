using System;
using System.Collections.Generic;
using System.Text;

namespace PieceOfChess.Domain.Moves
{
    public class KingMove : Move
    {
        public override IEnumerable<FigurePosition> GetPossibilities(
            FigurePosition actualPosition)
        {
            var result = new List<FigurePosition>();


            if (actualPosition.X < 8 && actualPosition.Y < 8)
                result.Add(FigurePosition.From(actualPosition.X + 1, actualPosition.Y + 1));

            if (actualPosition.X > 1 && actualPosition.Y > 1)
                result.Add(FigurePosition.From(actualPosition.X - 1, actualPosition.Y - 1));

            if (actualPosition.X > 1 && actualPosition.Y < 8)
                result.Add(FigurePosition.From(actualPosition.X - 1, actualPosition.Y + 1));

            if (actualPosition.X < 8 && actualPosition.Y > 1)
                result.Add(FigurePosition.From(actualPosition.X + 1, actualPosition.Y - 1));

            if (actualPosition.Y < 8)
                result.Add(FigurePosition.From(actualPosition.X, actualPosition.Y + 1));

            if (actualPosition.Y > 1)
                result.Add(FigurePosition.From(actualPosition.X, actualPosition.Y - 1));

            if (actualPosition.X > 1)
                result.Add(FigurePosition.From(actualPosition.X - 1, actualPosition.Y));

            if (actualPosition.X < 8)
                result.Add(FigurePosition.From(actualPosition.X + 1, actualPosition.Y));
            return result;
        }
    }
}
