using DAL.Entities;
using DAL.Repositories;

namespace Services;

public interface IQuestionsService
{
    Question GetQuestionByNumberInSurvey(int surveyId, int number);
}

internal class QuestionsService(IQuestionsRepository questionsRepository) : IQuestionsService
{
    public Question GetQuestionByNumberInSurvey(int surveyId, int number) => questionsRepository.GetQuestionByNumberInSurvey(surveyId, number);
}