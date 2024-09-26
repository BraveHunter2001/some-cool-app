using DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DAL;

public static class DI
{
    public static void AddDAL(this IServiceCollection services)
    {
        services.AddScoped<IQuestionsRepository, QuestionsRepository>();
    }
}
