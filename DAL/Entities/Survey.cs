namespace DAL.Entities;

public class Survey
{
    public int Id { get; set; }

    public List<Question> Questions { get; set; }

    public Dictionary<int, Question>? QuestionsByNumber => Questions?.Count > 0
        ? Questions.ToDictionary(k => k.NumberInSurvey, q => q)
        : null;
}