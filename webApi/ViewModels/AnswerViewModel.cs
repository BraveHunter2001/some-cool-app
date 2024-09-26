using DAL.Entities;

namespace some_cool_app.ViewModels;

public class AnswerViewModel
{
    public int Id { get; set; }
    public string Message { get; set; }

    public AnswerViewModel(Answer answer)
    {
        Id = answer.Id;
        Message = answer.Message;
    }
}