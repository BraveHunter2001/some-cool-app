using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using SomeCoolContext = DAL.Context.SomeCoolContext;

namespace DAL.Repositories;

public interface IQuestionsRepository
{
    Question? GetQuestionById(int questionId);
}

internal class QuestionsRepository(SomeCoolContext context) : Repository<Question>(context), IQuestionsRepository
{
    public Question? GetQuestionById(int questionId) =>
        context.Questions
            .Include(q => q.Answers)
            .Include(q => q.NextQuestion)
            .FirstOrDefault(q => q.Id == questionId);
}