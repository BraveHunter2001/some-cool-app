using Microsoft.AspNetCore.Mvc;
using Services;
using some_cool_app.Models;
using some_cool_app.ViewModels;

namespace some_cool_app.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SurveysController(IQuestionsService questionsService, ISurveysService surveysService) : ControllerBase
{
    [HttpGet("{surveyId}/{number?}")]
    public IActionResult GetQuestion([FromRoute] int surveyId, [FromRoute] int? number)
    {
        var question = questionsService.GetQuestionByNumberInSurvey(surveyId, number ?? 1);

        if (question is null)
            return NotFound("This question doesn't exist");

        return Ok(new QuestionViewModel(question));
    }

    [HttpPost("{surveyId}/next")]
    public IActionResult MoveOnNextQuestion([FromRoute] int surveyId, [FromBody] ResultAnswerModel resultAnswerModel)
    {
        var nextQuestionId = surveysService.MoveOnNextQuestion(resultAnswerModel.InterviewId, surveyId, resultAnswerModel.QuestionId, resultAnswerModel.AnswerId);
        return Ok(nextQuestionId);
    }
}