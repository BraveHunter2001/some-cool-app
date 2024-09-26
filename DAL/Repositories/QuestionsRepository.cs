using DAL.Context;
using DAL.Entities;

namespace DAL.Repositories;

public interface IQuestionsRepository
{
    Question GetQuestionByNumberInSurvey(int surveyId, int number);
}

internal class QuestionsRepository : IQuestionsRepository
{
    public Question GetQuestionByNumberInSurvey(int surveyId, int number)
    {
        var question = StupidContext.Questions.FirstOrDefault(q => q.SurveyId == surveyId && q.NumberInServery == number);

        return question;
    }
}