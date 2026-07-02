using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using QuizifydBackend.Application.IServices;
using QuizifydBackend.Application.Services;

namespace QuizifydBackend.Application
{
    public static class AppServiceCollection
    {

        public static IServiceCollection AddDIApp(this IServiceCollection service)
        {

            service.AddScoped<IBlogService, BlogService>();

            return service;
        }
    }
}
