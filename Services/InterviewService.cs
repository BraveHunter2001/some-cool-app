using DAL.Entities;
using DAL.Repositories;

namespace Services;

public interface IInterviewService
{
    Interview? GetById(int id);
}

internal class InterviewService(IInterviewRepository interviewRepository) : IInterviewService
{
    public Interview? GetById(int id) => interviewRepository.GetById(id);
}