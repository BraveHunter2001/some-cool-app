using Microsoft.Extensions.DependencyInjection;

namespace Services;

public static class DI
{
    public static void AddService(this IServiceCollection services)
    {
        services.AddScoped<IQuestionsService, QuestionsService>();
        services.AddScoped<ISurveysService, SurveysService>();
        services.AddScoped<IInterviewService, InterviewService>();
    }
}