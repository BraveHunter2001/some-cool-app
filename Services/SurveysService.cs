namespace Services;

public interface ISurveysService
{
    public int MoveOnNextQuestion(int surveyId, int questionId, int answerId);
}

internal class SurveysService : ISurveysService
{
    public int MoveOnNextQuestion(int surveyId, int questionId, int answerId)
    {
    }
}