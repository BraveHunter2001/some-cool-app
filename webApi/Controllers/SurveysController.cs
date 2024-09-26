using Microsoft.AspNetCore.Mvc;
using Services;
using some_cool_app.Models;
using some_cool_app.ViewModels;

namespace some_cool_app.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SurveysController(IQuestionsService questionsService) : ControllerBase
{
    [HttpGet("{surveyId}/{number?}")]
    public IActionResult GetQuestion(int surveyId, int? number)
    {
        var question = questionsService.GetQuestionByNumberInSurvey(surveyId, number ?? 1);

        if (question is null)
            return NotFound("This question doesn't exist");

        return Ok(new QuestionViewModel(question));
    }

    [HttpPost("{surveyId}/next")]
    public IActionResult MoveOnNextQuestion(ResultAnswerModel resultAnswerModel)
    {

        return Ok("id");
    }
}