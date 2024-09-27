namespace DAL.Entities;

public class Question
{
    public int Id { get; set; }
    public string Message { get; set; }
    public List<Answer> Answers { get; set; }

    public int? NextQuestionId { get; set; }
    public Question? NextQuestion { get; set; }

    public int SurveyId { get; set; }
    public Survey Survey { get; set; }

}