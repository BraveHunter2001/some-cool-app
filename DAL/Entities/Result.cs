namespace DAL.Entities;

public class Result
{
    public int Id { get; set; }
    public int SurveyId { get; set; }
    public int QuestionId { get; set; }
    public int SelectedAnswerId { get; set; }

    public Result()
    {
    }

    public Result(int surveyId, int questionId, int selectedAnswerId)
    {
        SurveyId = surveyId;
        QuestionId = questionId;
        SelectedAnswerId = selectedAnswerId;
    }
}