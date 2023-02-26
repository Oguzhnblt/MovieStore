using Application.DTO.CustomerDTOModel;
using Application.Features.CQRS.Commands.CustomerOperations;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerViewModel>()
                .ForMember(dest => dest.CustomerID, opt => opt.MapFrom(src => src.CustomerID))
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.CustomerName))
                .ForMember(dest => dest.CustomerSurname, opt => opt.MapFrom(src => src.CustomerSurname))
                .ForMember(dest => dest.PurchasedMovies, opt => opt.MapFrom(src => src.PurchasedMovies))
                .ForMember(dest => dest.FavoriteGenres, opt => opt.MapFrom(src => src.FavoriteGenres))
                .ReverseMap();

            CreateMap<CreateCustomerCommand, Customer>()
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.CustomerName))
                .ForMember(dest => dest.CustomerSurname, opt => opt.MapFrom(src => src.CustomerSurname))
                .ReverseMap();

            CreateMap<UpdateCustomerCommand, Customer>()
                .ForMember(dest => dest.CustomerID, opt => opt.MapFrom(src => src.CustomerID))
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.CustomerName))
                .ForMember(dest => dest.CustomerSurname, opt => opt.MapFrom(src => src.CustomerSurname))
                .ReverseMap();
        }
    }

}