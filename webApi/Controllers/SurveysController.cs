using Microsoft.AspNetCore.Mvc;
using Services;
using some_cool_app.Models;

namespace some_cool_app.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SurveysController(ISurveysService surveysService, IInterviewService interviewService, IQuestionsService questionsService) : ControllerBase
{
    [HttpPost("{surveyId}/next")]
    public IActionResult MoveOnNextQuestion([FromRoute] int surveyId, [FromBody] ResultAnswerModel resultAnswerModel)
    {
        var survey = surveysService.GetSurveyById(surveyId);
        if (survey is null)
            return NotFound("Not found survey");

        var interview = interviewService.GetInterviewById(resultAnswerModel.InterviewId);
        if (interview is null)
            return NotFound("Not found interview");

        var question = questionsService.GetQuestionById(resultAnswerModel.QuestionId);
        if (question is null)
            return NotFound("Not found question");

        if (question.Answers.All(a => a.Id != resultAnswerModel.AnswerId))
            return BadRequest("This answer is not valid");

        var nextQuestionId = surveysService.MoveOnNextQuestion(survey, interview, question, resultAnswerModel.AnswerId);
        return Ok(nextQuestionId.HasValue ? nextQuestionId : "No further questions");
    }
}