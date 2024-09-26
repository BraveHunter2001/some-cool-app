using DAL.Entities;
using DAL.Repositories;

namespace Services;

public interface ISurveysService
{
    public int? MoveOnNextQuestion(Survey survey, Interview interview, int questionId, int selectedAnswerId);
    public Survey? GetSurveyById(int id);
}

internal class SurveysService(
    IResultsRepository resultsRepository,
    ISurveysRepository surveysRepository
) : ISurveysService
{
    public int? MoveOnNextQuestion(Survey survey, Interview interview, int questionId, int selectedAnswerId)
    {
        // сохраняем ответ
        resultsRepository.AddResult(new Result(survey.Id, questionId, selectedAnswerId));

        var numberInSurvey = interview.LastSelectedQuestion?.NumberInSurvey ?? 1;

        var questionDictionary = survey.QuestionsByNumber;
        if (questionDictionary?.TryGetValue(numberInSurvey + 1, out var nextQuestion) ?? false)
        {
            interview.LastSelectedQuestion = nextQuestion;
            return nextQuestion.Id;
        }

        return null;
    }

    public Survey? GetSurveyById(int id) => surveysRepository.GetSurveyById(id);
}