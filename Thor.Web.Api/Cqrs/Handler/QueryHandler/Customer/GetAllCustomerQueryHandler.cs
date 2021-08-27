using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Thor.Business.Abstract;
using Thor.Web.Api.Cqrs.Query.Customer.Request;
using Thor.Web.Api.Cqrs.Query.Customer.Response;

namespace Thor.Web.Api.Cqrs.Handler.QueryHandler.Customer
{
    public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerQueryRequest, List<GetAllCustomerQueryResponse>>
    {
        ICustomerService _customerService;
        CancellationTokenSource _tokenSource;
        public GetAllCustomerQueryHandler(ICustomerService customerService, CancellationTokenSource tokenSource)
        {
            _customerService = customerService;
            _tokenSource = tokenSource;
        }

        public async Task<List<GetAllCustomerQueryResponse>> Handle(GetAllCustomerQueryRequest request, CancellationToken cancellationToken)
        {
            cancellationToken = _tokenSource.Token;

            if (cancellationToken.IsCancellationRequested)
            {
                return await Task.FromCanceled<List<GetAllCustomerQueryResponse>>(cancellationToken);
            }

            var response = await _customerService.GetCustomer();

            return response.Select(customer => new GetAllCustomerQueryResponse()
            {
                Id = customer.Id,
                FullName = customer.FullName,
                Age = customer.Age,
                Job = customer.Job,
                CreateDateTime = customer.CreateDateTime

            }).ToList();
        }
    }



    public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerQueryRequest, List<GetAllCustomerQueryResponse>>
    {

        public async Task<List<GetAllCustomerQueryResponse>> Handle(GetAllCustomerQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _customerService.GetCustomer();

            return response.Select(customer => new GetAllCustomerQueryResponse()
            {
                Id = customer.Id,
                FullName = customer.FullName,
                Age = customer.Age,
                Job = customer.Job,
                CreateDateTime = customer.CreateDateTime

            }).ToList();
        }
    }
}
