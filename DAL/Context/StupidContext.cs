using DAL.Entities;

namespace DAL.Context;

public static class StupidContext
{
    static Question q1 = new Question()
    {
        Id = 1, Message = "Q 1?",
        Answers = [new() { Id = 1, Message = "A1" }, new() { Id = 2, Message = "A2" }],
        NextQuestionId = 2,
        NextQuestion = q2
    };

    static Question q2 = new Question()
    {
        Id = 2, Message = "Q 2?", Answers =
        [
            new() { Id = 3, Message = "A1" },
            new() { Id = 4, Message = "A2" },
            new() { Id = 5, Message = "A3" }
        ],
        NextQuestionId = 3,
        NextQuestion = q3
    };

    static Question q3 = new Question()
    {
        Id = 3,
        Message = "Q 3?",
        Answers =
        [
            new() { Id = 6, Message = "A1" },
            new() { Id = 7, Message = "A2" },
            new() { Id = 8, Message = "A3" },
            new() { Id = 9, Message = "A2" },
            new() { Id = 10, Message = "A3" }
        ]
    };

    public static List<Question> Questions =
    [
        q1, q2, q3
    ];

    public static List<Survey> Surveys =
    [
        new() { Id = 1, Questions = Questions }
    ];

    public static List<Result> Results = new();

    public static List<Interview> Interviews =
    [
        new() { Id = 1, SurveyId = 1 }
    ];
}