using DAL.Entities;

namespace some_cool_app.ViewModels;

public class QuestionViewModel
{
    public string Message { get; set; }
    public List<AnswerViewModel> Answers { get; set; }

    public QuestionViewModel(Question question)
    {
        Message = question.Message;
        Answers = question.Answers.ConvertAll(a => new AnswerViewModel(a));
    }
}