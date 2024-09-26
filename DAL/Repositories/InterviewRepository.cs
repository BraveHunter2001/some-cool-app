using DAL.Context;
using DAL.Entities;

namespace DAL.Repositories;

public interface IInterviewRepository
{
    Interview? GetById(int id);
}

internal class InterviewRepository : IInterviewRepository
{
    public Interview? GetById(int id)
    {
        var interview = StupidContext.Interviews.FirstOrDefault(i => i.Id == id);

        return interview;
    }

}