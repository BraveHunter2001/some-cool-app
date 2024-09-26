using DAL.Entities;
using DAL.Repositories;

namespace Services;

public interface ISurveysService
{
    public int MoveOnNextQuestion(int interviewId, int surveyId, int questionId, int selectedAnswerId);
}

internal class SurveysService(
    IResultsRepository resultsRepository,
    IInterviewRepository interviewRepository,
    IQuestionsRepository questionsRepository
) : ISurveysService
{
    public int MoveOnNextQuestion(int interviewId, int surveyId, int questionId, int selectedAnswerId)
    {
        // сохраняем ответ
        resultsRepository.AddResult(new Result(surveyId, questionId, selectedAnswerId));

        // переключаем на следующий вопрос
        var interview = interviewRepository.GetById(interviewId);
        bool hasInterview = interview is not null;

        var currentNumberInServery = hasInterview && interview.LastSelectedQuestion is not null
            ? interview.LastSelectedQuestion.NumberInServery
            : 1;

        var nextQuestion = questionsRepository.GetQuestionByNumberInSurvey(surveyId, currentNumberInServery + 1);

        if (!hasInterview)
        {
            interview = new Interview() { SurveyId = surveyId, LastSelectedQuestion = nextQuestion };
            interviewRepository.AddInterview(interview);
            return nextQuestion.Id;
        }

        interview.LastSelectedQuestion = nextQuestion;
        return nextQuestion.Id;
    }
}