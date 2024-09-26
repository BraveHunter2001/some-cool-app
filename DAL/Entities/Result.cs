namespace DAL.Entities;

public class Result
{
    public int Id { get; set; }
    public int SurveyId { get; set; }
    public int InterviewId { get; set; }
    public int QuestionId { get; set; }
    public int SelectedAnswerId { get; set; }

    public Result()
    {
    }

    public Result(int surveyId, int interviewId, int questionId, int selectedAnswerId)
    {
        SurveyId = surveyId;
        InterviewId = interviewId;
        QuestionId = questionId;
        SelectedAnswerId = selectedAnswerId;
    }
}