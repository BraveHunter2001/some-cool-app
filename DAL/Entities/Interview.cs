namespace DAL.Entities;

public class Interview
{
    public int Id { get; set; }
    public int SurveyId { get; set; }
    public int? LastSelectedQuestionId { get; set; }

    public Question? LastSelectedQuestion { get; set; }
}