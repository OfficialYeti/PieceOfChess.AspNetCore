using AutoMapper;
using PieceOfChess.Domain;
using PieceOfChess.WebAPI.Dto;

namespace PieceOfChess.WebAPI.Mapper
{
    public class FigureProfile: Profile
    {
        public FigureProfile()
        {
            CreateMap<Figure, FigureDto>()
                .ForMember(s => s.Id, o => o.MapFrom(q => q.Id))
                .ForMember(s => s.Name, o => o.MapFrom(q => q.Name))
                .ForMember(s => s.Position, o => o.MapFrom(q => q.Position))
                .ForAllOtherMembers(o => o.Ignore());
            CreateMap<FigurePosition, FigurePositionDto>()
                .ForMember(s => s.X, o => o.MapFrom(q => q.X))
                .ForMember(s => s.Y, o => o.MapFrom(q => q.Y))
                .ForAllOtherMembers(o => o.Ignore());
        }
    }
}
