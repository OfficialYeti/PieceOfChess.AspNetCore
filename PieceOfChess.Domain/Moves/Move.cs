using System.Collections.Generic;
using System.Linq;
using System;

namespace PieceOfChess.Domain.Moves
{
    public abstract class Move
    {
        public bool Execute(Figure target, FigurePosition destination)
        {
            if (target.Position == null)
            {
                target.Position = destination;
                return true;
            }
            if (GetPossibilities(target.Position).Contains(destination))
            {
                target.Position = FigurePosition.From(destination.X, destination.Y);
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual IEnumerable<FigurePosition> GetPossibilities(FigurePosition actualPosition)
        {
            return null;
        }
    }
}
