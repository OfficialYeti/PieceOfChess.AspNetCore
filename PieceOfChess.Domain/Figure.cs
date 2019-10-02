using PieceOfChess.Domain.BaseObjects;
using PieceOfChess.Domain.Exceptions;
using PieceOfChess.Domain.Moves;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PieceOfChess.Domain
{
    public class Figure : Enumeration
    {
        public static Figure Queen = new Figure(1, nameof(Queen).ToLowerInvariant(), new QueenMove());
        public static Figure King = new Figure(2, nameof(King).ToLowerInvariant(), new KingMove());
        public static Figure Bishop = new Figure(3, nameof(Bishop).ToLowerInvariant(), new BishopMove());
        public static Figure Knight = new Figure(4, nameof(Knight).ToLowerInvariant(), new KnightMove());
        public static Figure Rook = new Figure(5, nameof(Rook).ToLowerInvariant(), new RookMove());
        public static Figure Pawn = new Figure(6, nameof(Pawn).ToLowerInvariant(), new PawnMove());

        internal Figure(int id, string name, Move move) : base(id, name)
        {
            Move = move;
        }

        public FigurePosition Position { get; internal set; }
        public readonly Move Move;

        public Figure WithPosition(FigurePosition position)
        {
            if (Position != null)
            {
                throw new InvalidOperationException(
                    "Operation only for initialization, use move execute.");
            }
            Position = position;
            return this;
        }

        public static IEnumerable<Figure> List() =>
             new[] { Queen, King, Bishop, Knight, Rook, Pawn };

        public static Figure FromName(string name)
        {
            var state = List()
                .SingleOrDefault(s => String.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (state == null)
            {
                throw new ArgumentException($"Possible values for Figure: {String.Join(",", List().Select(s => s.Name))}");
            }

            return new Figure(state.Id, state.Name, state.Move);
        }

        public static Figure From(int id)
        {
            var state = List().SingleOrDefault(s => s.Id == id);

            if (state == null)
            {
                throw new ArgumentException($"Possible values for Figure: {String.Join(",", List().Select(s => s.Id))}");
            }

            return new Figure(state.Id, state.Name, state.Move);
        }
    }
}
