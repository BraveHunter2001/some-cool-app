using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DAL;

public static class DI
{
    public static void AddDAL(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<Context.SomeCoolContext>(
            opt => opt.UseNpgsql(connectionString)
        );

        services.AddScoped<IQuestionsRepository, QuestionsRepository>();
        services.AddScoped<IResultsRepository, ResultsRepository>();
        services.AddScoped<IInterviewRepository, InterviewRepository>();
        services.AddScoped<ISurveysRepository, SurveysRepository>();
    }
}