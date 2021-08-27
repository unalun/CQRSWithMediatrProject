using MediatR;
using Thor.Web.Api.Cqrs.Command.Customer.Response;

namespace Thor.Web.Api.Cqrs.Command.Customer.Request
{
    public class CreateCustomerCommandRequest : IRequest<CreateCustomerCommandResponse>
    {
        public string FullName { get; set; }
        public string Job { get; set; }
        public int Age { get; set; }
    }
}
