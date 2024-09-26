namespace DAL.Entities;

public class Survey
{
    public int Id { get; set; }

    public List<Question> Questions { get; set; }
}