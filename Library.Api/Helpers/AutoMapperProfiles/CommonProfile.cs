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
            CreateMap<Entity.PublishHouse, Dto.PublishHouseDTO>().ReverseMap();
            CreateMap<Entity.Category, Dto.CategoryDTO>().ReverseMap();
            CreateMap<Entity.Book, Dto.BookDTO>();
            CreateMap<Dto.BookSaveDTO, Entity.Book>().ReverseMap();
            CreateMap<Entity.Rent, Dto.RentDTO>().ReverseMap();
        }
    }
}