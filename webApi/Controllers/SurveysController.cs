using Microsoft.AspNetCore.Mvc;
using Services;
using some_cool_app.Models;

namespace some_cool_app.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SurveysController(ISurveysService surveysService, IInterviewService interviewService) : ControllerBase
{
    [HttpPost("{surveyId}/next")]
    public IActionResult MoveOnNextQuestion([FromRoute] int surveyId, [FromBody] ResultAnswerModel resultAnswerModel)
    {
        var survey = surveysService.GetSurveyById(surveyId);
        if (survey is null)
            return NotFound("Not found survey");

        var interview = interviewService.GetById(resultAnswerModel.InterviewId);
        if (interview is null)
            return NotFound("Not found interview");

        var nextQuestionId = surveysService.MoveOnNextQuestion(survey, interview, resultAnswerModel.QuestionId, resultAnswerModel.AnswerId);
        return Ok(nextQuestionId);
    }
}