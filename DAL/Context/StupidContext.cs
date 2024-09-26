using DAL.Entities;

namespace DAL.Context;

public static class StupidContext
{
    public static List<Question> Questions =
    [
        new Question()
        {
            Id = 1, Message = "Test 1?", NumberInServery = 1, SurveyId = 1,
            Answers =
            [
                new Answer() { Id = 1, Message = "Ans 1", QuestionId = 1 },
                new Answer() { Id = 2, Message = "Ans 2", QuestionId = 1 },
                new Answer() { Id = 3, Message = "Ans 3", QuestionId = 1 },
            ]
        },
        new Question()
        {
            Id = 2, Message = "Test 2?", NumberInServery = 2, SurveyId = 1,
            Answers =
            [
                new Answer() { Id = 4, Message = "Ans 1", QuestionId = 2 },
                new Answer() { Id = 5, Message = "Ans 2", QuestionId = 2 },
            ]
        },
        new Question()
        {
            Id = 3, Message = "Test 3?", NumberInServery = 3, SurveyId = 1,
            Answers =
            [
                new Answer() { Id = 6, Message = "Ans 1", QuestionId = 3 },
                new Answer() { Id = 7, Message = "Ans 2", QuestionId = 3 },
                new Answer() { Id = 8, Message = "Ans 3", QuestionId = 3 },
            ]
        },
        new Question()
        {
            Id = 4, Message = "Test 4?", NumberInServery = 4, SurveyId = 1,
            Answers =
            [
                new Answer() { Id = 9, Message = "Ans 1", QuestionId = 4 },
                new Answer() { Id = 10, Message = "Ans 2", QuestionId = 4 },
                new Answer() { Id = 11, Message = "Ans 3", QuestionId = 4 },
                new Answer() { Id = 12, Message = "Ans 4", QuestionId = 4 },
                new Answer() { Id = 13, Message = "Ans 5", QuestionId = 4 },
            ]
        },
    ];
}