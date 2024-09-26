namespace DAL.Entities;

public class Result
{
    public int Id { get; set; }
    public int SurveyId { get; set; }
    public int QuestionId { get; set; }
    public int SelectedAnswerId { get; set; }
}