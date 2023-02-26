using Application.DTO.OrderModel;
using Application.Features.CQRS.Commands.OrderOperations;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class OrderProfile : Profile
    {

        public OrderProfile()
        {
            CreateMap<Order, OrderViewModel>()
                .ForMember(dest => dest.CustomerID, opt => opt.MapFrom(src => src.Customer.CustomerID))
                .ForMember(dest => dest.MovieID, opt => opt.MapFrom(src => src.PurchasedMovie.First().MovieID));

            CreateMap<CreateOrderModel, CreateOrderCommand>()
                .ForMember(dest => dest.MovieID, opt => opt.MapFrom(src => src.MovieID))
                .ForMember(dest => dest.CustomerID, opt => opt.MapFrom(src => src.CustomerID))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.PurchasedDate, opt => opt.MapFrom(src => src.PurchasedDate));

            CreateMap<UpdateOrderModel, UpdateOrderCommand>()
                .ForMember(dest => dest.OrderID, opt => opt.MapFrom(src => src.OrderID))
                .ForMember(dest => dest.MovieID, opt => opt.MapFrom(src => src.MovieID))
                .ForMember(dest => dest.CustomerID, opt => opt.MapFrom(src => src.CustomerID))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.PurchasedDate, opt => opt.MapFrom(src => src.PurchasedDate));
        }
    }



}