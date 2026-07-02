using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuizifydBackend.Application.IRepositories;
using QuizifydBackend.Infrastructure.Data;
using QuizifydBackend.Infrastructure.Repostiories;

namespace QuizifydBackend.Infrastructure
{
    public static class InfraServiceCollection
    {

        public static IServiceCollection AddDIInfra(this IServiceCollection service)
        {

            service.AddScoped<IBlogRepo, BlogRepo>();

            return service;
        }

        public static IServiceCollection AddDbContextInfra(this IServiceCollection service, IConfiguration configuration)
        {

            service.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"))
            );

            return service;
        }
    }
}
