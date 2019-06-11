using AutoMapper;
using Entity = Library.Domain.Entities;
using Dto = Library.Domain.DTO;

namespace Library.Api.Helpers.AutoMapperProfiles
{
    public class CommonProfile : Profile
    {
        public CommonProfile()
        {
            CreateMap<Entity.Artist, Dto.ArtistDTO>().ReverseMap();
            CreateMap<Entity.Category, Dto.CategoryDTO>().ReverseMap();
        }
    }
}