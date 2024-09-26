using DAL.Entities;
using DAL.Repositories;

namespace Services;

public interface IQuestionsService
{
    Question? GetQuestionById(int questionId);
}

internal class QuestionsService(IQuestionsRepository questionsRepository) : IQuestionsService
{
    public Question? GetQuestionById(int questionId) => questionsRepository.GetQuestionById(questionId);
}