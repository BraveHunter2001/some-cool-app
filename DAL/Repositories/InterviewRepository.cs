using DAL.Entities;
using SomeCoolContext = DAL.Context.SomeCoolContext;

namespace DAL.Repositories;

public interface IInterviewRepository
{
    Interview? GetInterviewById(int id);
    void Update(Interview interview);
}

internal class InterviewRepository(SomeCoolContext context) : Repository<Interview>(context), IInterviewRepository
{
    public Interview? GetInterviewById(int id) => GetById(id);

    public void Update(Interview interview) => Insert(interview);
}