using iLearning.SimpleChat.Infrastructure.Persistence;
using iLearning.SimpleChat.Infrastructure.Persistence.Repositories;
using iLearning.SimpleChat.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace iLearning.SimpleChat.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("Default")));

        services.AddScoped<IUsersRepository, UsersRepository>();
        services.AddScoped<IMessagesRepository, MessagesRepository>();

        return services;
    }
}
