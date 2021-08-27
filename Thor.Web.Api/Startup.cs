using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using Thor.Business.Abstract;
using Thor.Business.Concrete;
using Thor.Web.Api.Cqrs.Handler.CommandHandler.Customer;
using Thor.Web.Api.Cqrs.Handler.QueryHandler.Customer;

namespace Thor.Web.Api
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddScoped<ICustomerService, CustomerService>();

            services.AddSingleton<CancellationTokenSource>();

            services.AddTransient<CreateCustomerCommandHandler>();
            services.AddTransient<GetAllCustomerQueryHandler>();

            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
