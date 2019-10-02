using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieceOfChess.WebAPI.Dto
{
    public class PostMoveApiRequest
    {
        public FigurePositionDto From { get; set; }
        public FigurePositionDto To { get; set; }
    }
}
