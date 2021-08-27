using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thor.Web.Api.Cqrs.Query.Customer.Response;

namespace Thor.Web.Api.Cqrs.Query.Customer.Request
{
    public class GetAllCustomerQueryRequest : IRequest<List<GetAllCustomerQueryResponse>>
    {
    }
}
