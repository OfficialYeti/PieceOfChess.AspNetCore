using PieceOfChess.Domain.Exceptions;

namespace PieceOfChess.Domain
{
    public class FigurePosition
    {
        public uint X { get; }
        public uint Y { get; }

        private FigurePosition(uint x, uint y)
        {
            X = x;
            Y = y;
        }

        public static FigurePosition From(uint x, uint y)
        {
            if (x > 8 || x == 0 || y == 0 || y >8)
            {
                throw new IllegalFigurePositionException();
            }
            return new FigurePosition(x, y);
        }

        public override bool Equals(object obj)
        {
            var position = obj as FigurePosition;
            return this.X == position.X && this.Y == position.Y;
        }
    }
}
