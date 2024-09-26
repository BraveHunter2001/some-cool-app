using DAL.Entities;
using DAL.Repositories;

namespace Services;

public interface ISurveysService
{
    public int? MoveOnNextQuestion(Survey survey, Interview interview, Question question, int selectedAnswerId);
    public Survey? GetSurveyById(int id);
}

internal class SurveysService(
    IResultsRepository resultsRepository,
    ISurveysRepository surveysRepository,
    IInterviewRepository interviewRepository
) : ISurveysService
{
    public int? MoveOnNextQuestion(Survey survey, Interview interview, Question question, int selectedAnswerId)
    {
        var result = resultsRepository.GetResult(survey.Id, interview.Id, question.Id);
        if (result == null)
            resultsRepository.AddResult(new Result(survey.Id, interview.Id, question.Id, selectedAnswerId));
        else
        {
            result.SelectedAnswerId = selectedAnswerId;
            resultsRepository.UpdateResult(result);
        }

        int? nextQuestionId = question.NextQuestionId;

        interview.CurrentQuestionId = nextQuestionId;
        interviewRepository.Update(interview);

        return nextQuestionId;
    }

    public Survey? GetSurveyById(int id) => surveysRepository.GetSurveyById(id);
}