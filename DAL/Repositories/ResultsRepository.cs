using DAL.Context;
using DAL.Entities;


namespace DAL.Repositories;

public interface IResultsRepository
{
    void AddResult(Result result);
    void UpdateResult(Result result);
    Result? GetResult(int surveyId, int interviewId, int questionId);
}

internal class ResultsRepository(SomeCoolContext context) : Repository<Result>(context), IResultsRepository
{
    public void AddResult(Result result) => Create(result);

    public void UpdateResult(Result result) => Insert(result);

    public Result? GetResult(int surveyId, int interviewId, int questionId)
        => context.Results
            .FirstOrDefault(r => r.SurveyId == surveyId
                                 && r.InterviewId == interviewId
                                 && r.QuestionId == questionId
            );
}