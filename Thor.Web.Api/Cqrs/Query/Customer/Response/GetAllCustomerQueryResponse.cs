using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Thor.Web.Api.Cqrs.Query.Customer.Response
{
    public class GetAllCustomerQueryResponse
    {
        public long Id { get; set; }
        public DateTime CreateDateTime { get; set; }

        public string FullName { get; set; }
        public string Job { get; set; }
        public int Age { get; set; }
    }
}
