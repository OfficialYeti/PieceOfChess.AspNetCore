using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PieceOfChess.Domain;
using PieceOfChess.WebAPI.Dto;
using System.Collections.Generic;

// NOTE: Consider Application Layer if controller logic gets bigger
// NOTE: Consider Fluent API validation

namespace PieceOfChess.WebAPI.Controllers
{
    [EnableCors("public")]
    [Route("api/figures")]
    public class FiguresController : Controller
    {
        private readonly IMapper _mapper;

        public FiguresController(IMapper mapper)
        {
            _mapper = mapper;
        }

        // GET api/figures
        [HttpGet]
        [EnableCors("public")]
        public ActionResult<IEnumerable<FigureDto>> GetFigures()
        {
            var figures = Figure.List();
            return Ok(_mapper.Map<IEnumerable<FigureDto>>(figures));
        }

        // POST api/figures/id/moves
        [HttpPost("{id}/moves")]
        public ActionResult<IEnumerable<FigurePositionDto>> GetPossibleMoves(
            [FromRoute]int id,
            [FromBody]FigurePositionDto figurePosition)
        {
            var position = FigurePosition.From(figurePosition.X, figurePosition.Y);
            var posibilities = Figure.From(id)
                .WithPosition(position)
                .Move.GetPossibilities(position);
            return Ok(_mapper.Map<IEnumerable<FigurePositionDto>>(posibilities));
        }

        // POST api/figures/id/move
        [HttpPost("{id}/move")]
        public IActionResult PostMove(
            [FromRoute]int id,
            [FromBody]PostMoveApiRequest request)
        {
            var actualPosition = FigurePosition.From(request.From.X, request.From.Y);
            var desiredPosition = FigurePosition.From(request.To.X, request.To.Y);
            var figure = Figure.From(id).WithPosition(actualPosition);
            var result = figure.Move.Execute(figure, desiredPosition);
            if (result) return Ok();
            return BadRequest();
        }
    }
}
