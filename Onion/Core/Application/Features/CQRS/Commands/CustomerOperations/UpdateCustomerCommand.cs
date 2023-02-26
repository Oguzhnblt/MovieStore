using Application.DTO.CustomerDTOModel;
using MediatR;

namespace Application.Features.CQRS.Commands.CustomerOperations
{
    public class UpdateCustomerCommand : IRequest<CustomerViewModel>
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    }
}
