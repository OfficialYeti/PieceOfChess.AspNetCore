using PieceOfChess.Domain;
using System.Linq;
using Xunit;

namespace PieceOfChess.UnitTest
{
    public class FigureMoveTests
    {
        // Bishop
        [Fact]
        public void ShouldGetNinePossibilitiesWhenBishopOnB4()
        {
            var bishop = Figure.Bishop;
            var result = bishop.Move.GetPossibilities(FigurePosition.From(2, 4));
            Assert.Equal(9, result.Count());
        }
        // King
        [Fact]
        public void ShouldGetEightPossibilitiesWhenKingOnB4()
        {
            var king = Figure.King;
            var result = king.Move.GetPossibilities(FigurePosition.From(2, 4));
            Assert.Equal(8, result.Count());
        }
        // Knight
        [Fact]
        public void ShouldGetSixPossibilitiesWhenKnightOnB4()
        {
            var knight = Figure.Knight;
            var result = knight.Move.GetPossibilities(FigurePosition.From(2, 4));
            Assert.Equal(6, result.Count());
        }
        // Pawn
        [Fact]
        public void ShouldGetOnePossibilitiesWhenPawnOnB4()
        {
            var pawn = Figure.Pawn;
            var result = pawn.Move.GetPossibilities(FigurePosition.From(2, 4));
            Assert.Single(result);
        }
        // Queen
        [Fact]
        public void ShouldGetTwentyThreePossibilitiesWhenQueenOnB4()
        {
            var queen = Figure.Queen;
            var result = queen.Move.GetPossibilities(FigurePosition.From(2, 4));
            Assert.Equal(23, result.Count());
        }
        // Rook
        [Fact]
        public void ShouldGetFourteenPossibilitiesWhenRookOnB4()
        {
            var rook = Figure.Rook;
            var result = rook.Move.GetPossibilities(FigurePosition.From(2, 4));
            Assert.Equal(14, result.Count());
        }

        // Common
        [Fact]
        public void GivenPositionShouldAlwaysBeSetWhenFigurePositionIsNull()
        {
            var bishop = Figure.Bishop;
            var position = FigurePosition.From(1, 2);
            bishop.Move.Execute(bishop, position);
            Assert.Equal(position, bishop.Position);
        }

        [Fact]
        public void ShouldReturnFalseWhenExecuteInvalidMove()
        {
            var bishop = Figure.Bishop.WithPosition(FigurePosition.From(1,2));
            var result = bishop.Move.Execute(bishop, FigurePosition.From(1, 1));
            Assert.False(result);
        }

    }
}
