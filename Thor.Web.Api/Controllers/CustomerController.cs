using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Thor.Web.Api.Cqrs.Command.Customer.Request;
using Thor.Web.Api.Cqrs.Command.Customer.Response;
using Thor.Web.Api.Cqrs.Query.Customer.Request;
using Thor.Web.Api.Cqrs.Query.Customer.Response;

namespace Thor.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult>  Get(GetAllCustomerQueryRequest request)
        {
            List<GetAllCustomerQueryResponse> response = await _mediator.Send(request);

            return Ok(response);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCustomerCommandRequest request)
        {
            CreateCustomerCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
