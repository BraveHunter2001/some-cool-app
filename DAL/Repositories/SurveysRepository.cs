using DAL.Context;
using DAL.Entities;

namespace DAL.Repositories;

public interface ISurveysRepository
{
    Survey? GetSurveyById(int id);
}

internal class SurveysRepository : ISurveysRepository
{
    public Survey? GetSurveyById(int id)
    {
        return StupidContext.Surveys.FirstOrDefault(s => s.Id == id);
    }
}