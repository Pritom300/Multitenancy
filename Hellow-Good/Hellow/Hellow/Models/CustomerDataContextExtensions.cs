using Hellow.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hellow.Models
{
    public static class CustomerDataContextExtensions
    {
        public static void AddCustomerDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(provider =>
            {
                var httpContext = provider.GetService<IHttpContextAccessor>();

                // In this sample we are using a customer identifier as the firs segment in the url request
                // Ex: http://localhost:5000/clienta/contacts
                //     http://localhost:5000/clientb/contacts
                //var clientSlug = httpContext.HttpContext.Request.Path.Value.Split("/", StringSplitOptions.RemoveEmptyEntries)[0];

                //mine
                var fullAddress =httpContext.HttpContext?.Request?
                .Headers?["Host"].ToString()?.Split('.');

                var clientSlug= fullAddress[0];
                // If you need to perform any validation like if the customer exists
                // or if it has a valid subscription you can request a master context
                // and perform validations
                //var masterContext = provider.GetService<MasterDataContext>();

                var connString = configuration.GetConnectionString("TemplateConnection").Replace("__DBNAME__", $"MultiTenant_{clientSlug}");
                var opts = new DbContextOptionsBuilder<ApplicationDbContext>();
                //opts.UseSqlServer(connString, s => s.EnableRetryOnFailure());
                opts.UseSqlServer(connString,s=>s.EnableRetryOnFailure());
                opts.EnableSensitiveDataLogging();

                return new ApplicationDbContext(opts.Options);
            });
        }
    }
}
