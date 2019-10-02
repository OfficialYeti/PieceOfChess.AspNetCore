using System;
using System.Collections.Generic;
using System.Text;

namespace PieceOfChess.Domain.Moves
{
    public class RookMove : Move
    {
        public override IEnumerable<FigurePosition> GetPossibilities(
            FigurePosition actualPosition)
        {
            var result = new List<FigurePosition>();

            for (var i = (actualPosition.X + 1); i < 9; i++)
            {
                result.Add(FigurePosition.From(i, actualPosition.Y));
            }
            for (var i = (actualPosition.X - 1); i > 0; i--)
            {
                result.Add(FigurePosition.From(i, actualPosition.Y));
            }
            for (var j = (actualPosition.Y + 1); j < 9; j++)
            {
                result.Add(FigurePosition.From(actualPosition.X, j));
            }
            for (var j = (actualPosition.Y - 1); j > 0; j--)
            {
                result.Add(FigurePosition.From(actualPosition.X, j));
            }
            return result;
        }
    }
}
