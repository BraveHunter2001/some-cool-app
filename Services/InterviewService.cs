using DAL.Entities;
using DAL.Repositories;

namespace Services;

public interface IInterviewService
{
    Interview? GetInterviewById(int id);
}

internal class InterviewService(IInterviewRepository interviewRepository) : IInterviewService
{
    public Interview? GetInterviewById(int id) => interviewRepository.GetInterviewById(id);
}