using DAL.Context;
using DAL.Entities;

namespace DAL.Repositories;

public interface IQuestionsRepository
{
    Question GetQuestionById(int questionId);
}

internal class QuestionsRepository : IQuestionsRepository
{
    public Question GetQuestionById(int questionId)
    {
        var question = StupidContext.Questions.FirstOrDefault(q => q.Id == questionId);
        return question;
    }
}