using Arthes_2022.Models.Entities;
using Arthes_2022.Models.ViewModels;

using AutoMapper;

namespace Arthes_2022.Data.Mappings
{
    public class CadastraRevistaMappingProfile : Profile
    {
        public CadastraRevistaMappingProfile()
        {
            CreateMap<CadastraRevistaViewModel, Revista>()
                .ForMember(d => d.DataCriacao, o => o.MapFrom(x => DateTime.Now))
                .ReverseMap();
        }
    }
}
