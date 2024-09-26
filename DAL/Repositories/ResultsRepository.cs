using DAL.Context;
using DAL.Entities;

namespace DAL.Repositories;

public interface IResultsRepository
{
    void AddResult(Result result);
    void UpdateResult(Result result);
    Result? GetResult(int surveyId, int interviewId, int questionId);
}

internal class ResultsRepository : IResultsRepository
{
    public void AddResult(Result result)
    {
        StupidContext.Results.Add(result);
    }

    public void UpdateResult(Result result)
    {
    }

    public Result? GetResult(int surveyId, int interviewId, int questionId)
        => StupidContext.Results
            .FirstOrDefault(r => r.SurveyId == surveyId
                                 && r.InterviewId == interviewId
                                 && r.QuestionId == questionId
            );
}