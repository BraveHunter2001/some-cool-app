using DAL.Context;
using DAL.Entities;

namespace DAL.Repositories;

public interface IResultsRepository
{
    void AddResult(Result result);
}

internal class ResultsRepository : IResultsRepository
{
    public void AddResult(Result result)
    {
        StupidContext.Results.Add(result);
    }
}