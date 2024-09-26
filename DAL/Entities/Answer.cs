namespace DAL.Entities;

public class Answer
{
    public int Id { get; set; }
    public string Message { get; set; }

    public int QuestionId { get; set; }
    public Question Question { get; set; }
}