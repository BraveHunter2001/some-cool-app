namespace DAL.Entities;

public class Interview
{
    public int Id { get; set; }
    public int SurveyId { get; set; }
    public int? CurrentQuestionId { get; set; }
    public Question? CurrentQuestion { get; set; }

    public List<Result> Results { get; set; }
}