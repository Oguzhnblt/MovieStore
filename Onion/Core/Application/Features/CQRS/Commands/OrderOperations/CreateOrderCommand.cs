using Application.DTO.OrderModel;
using MediatR;

namespace Application.Features.CQRS.Commands.OrderOperations
{
    public class CreateOrderCommand : IRequest<OrderViewModel>
    {
        public int CustomerID { get; set; }

        public int MovieID { get; set; }

        public decimal Price { get; set; }

        public DateTime PurchasedDate { get; set; }
    }
}
