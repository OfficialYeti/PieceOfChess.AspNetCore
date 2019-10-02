namespace PieceOfChess.WebAPI.Dto
{
    public class FigureDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FigurePositionDto Position { get; set; }
    }
}
