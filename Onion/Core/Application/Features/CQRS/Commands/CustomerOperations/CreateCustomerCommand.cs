using Application.DTO.CustomerDTOModel;
using MediatR;

namespace Application.Features.CQRS.Commands.CustomerOperations
{
    public class CreateCustomerCommand : IRequest<CustomerViewModel>
    {
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    }
}
