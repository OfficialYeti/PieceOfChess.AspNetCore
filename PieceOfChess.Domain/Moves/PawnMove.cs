using System;
using System.Collections.Generic;
using System.Text;

namespace PieceOfChess.Domain.Moves
{
    public class PawnMove : Move
    {
        public override IEnumerable<FigurePosition> GetPossibilities(
            FigurePosition actualPosition)
        {
            var result = new List<FigurePosition>();


            if (actualPosition.Y < 8)
                result.Add(FigurePosition.From(actualPosition.X, actualPosition.Y + 1));

            return result;
        }
    }
}
