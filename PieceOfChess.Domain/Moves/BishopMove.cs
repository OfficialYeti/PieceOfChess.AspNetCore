using System.Collections.Generic;

namespace PieceOfChess.Domain.Moves
{
    public class BishopMove : Move
    {
        public override IEnumerable<FigurePosition> GetPossibilities(FigurePosition actualPosition)
        {
            var result = new List<FigurePosition>();
            for (var (i, j) = (actualPosition.X+1, actualPosition.Y+1); i < 9 && j < 9; i++, j++)
            {
                result.Add(FigurePosition.From(i, j));
            }
            for (var (i, j) = (actualPosition.X-1, actualPosition.Y-1); i > 0 && j > 0; i--, j--)
            {
                result.Add(FigurePosition.From(i, j));
            }
            for (var (i, j) = (actualPosition.X-1, actualPosition.Y+1); i > 0 && j < 9; i--, j++)
            {
                result.Add(FigurePosition.From(i, j));
            }
            for (var (i, j) = (actualPosition.X+1, actualPosition.Y-1); i < 9 && j > 0; i++, j--)
            {
                result.Add(FigurePosition.From(i, j));
            }

            return result;
        }
    }
}
