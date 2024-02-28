using Application.Services.BookServices.Interface;
using Application.Services.BookServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
namespace Application
{
    public static class DI
    {

        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
            services.AddTransient(typeof(IBookService),typeof(BookServices));
            services.AddMediatR(a => a.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            return services;

        }
    }
}
