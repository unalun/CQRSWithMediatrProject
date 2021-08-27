using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Thor.Business.Abstract;
using Thor.Web.Api.Cqrs.Command.Customer.Request;
using Thor.Web.Api.Cqrs.Command.Customer.Response;

namespace Thor.Web.Api.Cqrs.Handler.CommandHandler.Customer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommandRequest, CreateCustomerCommandResponse>
    {
        ICustomerService _customerService;
        CancellationTokenSource _tokenSource;
        public CreateCustomerCommandHandler(ICustomerService customerService, CancellationTokenSource tokenSource)
        {
            _customerService = customerService;
            _tokenSource = tokenSource;
        }

        public Task<CreateCustomerCommandResponse> Handle(CreateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            cancellationToken = _tokenSource.Token;

            if (cancellationToken.IsCancellationRequested)
            {
                return Task.FromCanceled<CreateCustomerCommandResponse>(cancellationToken);
            }
            _customerService.Add(new Entities.Concrete.Customer { FullName = request.FullName, Age = request.Age, Job = request.Job, CreateDateTime = DateTime.Now });

            return Task.FromResult(new CreateCustomerCommandResponse() { Success = true });
        }
    }



    public class CreateCustomerCommandHandler2 : IRequestHandler<CreateCustomerCommandRequest, CreateCustomerCommandResponse>
    {
        public Task<CreateCustomerCommandResponse> Handle(CreateCustomerCommandRequest request, CancellationToken cancellationToken)
        {

        }
    }
}
