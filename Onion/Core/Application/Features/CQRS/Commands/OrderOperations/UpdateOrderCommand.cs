using Application.DTO.OrderModel;
using MediatR;

namespace Application.Features.CQRS.Commands.OrderOperations
{
    public class UpdateOrderCommand : IRequest<OrderViewModel>
    {
        public int OrderID { get; set; }

        public int CustomerID { get; set; }

        public int MovieID { get; set; }

        public decimal Price { get; set; }

        public DateTime PurchasedDate { get; set; }
    }
}
