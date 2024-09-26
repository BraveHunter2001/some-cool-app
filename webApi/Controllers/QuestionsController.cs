using Microsoft.AspNetCore.Mvc;
using Services;
using some_cool_app.ViewModels;

namespace some_cool_app.Controllers;

[Route("api/[controller]")]
[ApiController]
public class QuestionsController(IQuestionsService questionsService) : ControllerBase
{
    [HttpGet("{surveyId}/{questionId}")]
    public IActionResult GetQuestion([FromRoute] int questionId)
    {
        var question = questionsService.GetQuestionById(questionId);

        if (question is null)
            return NotFound("This question doesn't exist");

        return Ok(new QuestionViewModel(question));
    }
}