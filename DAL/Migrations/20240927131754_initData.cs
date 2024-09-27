using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class initData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
                INSERT INTO public."Surveys"
                ("Title")
                VALUES('MySurvey');
                
                INSERT INTO public."Interviews"
                ("SurveyId", "CurrentQuestionId")
                VALUES((select "Id" from  public."Surveys" where "Title"='MySurvey'), NULL);
                
                
                INSERT INTO public."Questions"
                ("Message", "NextQuestionId", "SurveyId")
                VALUES('q1', NULL, (select "Id" from  public."Surveys" where "Title"='MySurvey'));
                
                
                INSERT INTO public."Questions"
                ("Message", "NextQuestionId", "SurveyId")
                VALUES('q2', NULL, (select "Id" from  public."Surveys" where "Title"='MySurvey'));
                
                INSERT INTO public."Questions"
                ("Message", "NextQuestionId", "SurveyId")
                VALUES('q3', NULL, (select "Id" from  public."Surveys" where "Title"='MySurvey'));
                
                INSERT INTO public."Questions"
                ("Message", "NextQuestionId", "SurveyId")
                VALUES('q4', NULL, (select "Id" from  public."Surveys" where "Title"='MySurvey'));
                
                
                
                UPDATE public."Questions"
                SET "NextQuestionId"=(select "Id" from  public."Questions" where "Message"='q2')
                WHERE "Message"='q1';
                
                UPDATE public."Questions"
                SET "NextQuestionId"=(select "Id" from  public."Questions" where "Message"='q3')
                WHERE "Message"='q2';
                
                UPDATE public."Questions"
                SET "NextQuestionId"=(select "Id" from  public."Questions" where "Message"='q4')
                WHERE "Message"='q3';
                
                
                INSERT INTO public."Answers"
                ("Message", "QuestionId")
                VALUES('a1', (select "Id" from  public."Questions" where "Message"='q1'));
                
                INSERT INTO public."Answers"
                ("Message", "QuestionId")
                VALUES('a2', (select "Id" from  public."Questions" where "Message"='q1'));
                
                
                INSERT INTO public."Answers"
                ("Message", "QuestionId")
                VALUES('a1', (select "Id" from  public."Questions" where "Message"='q2'));
                
                INSERT INTO public."Answers"
                ("Message", "QuestionId")
                VALUES('a2', (select "Id" from  public."Questions" where "Message"='q2'));
                
                INSERT INTO public."Answers"
                ("Message", "QuestionId")
                VALUES('a3', (select "Id" from  public."Questions" where "Message"='q2'));
                
                
                INSERT INTO public."Answers"
                ("Message", "QuestionId")
                VALUES('a1', (select "Id" from  public."Questions" where "Message"='q3'));
                
                INSERT INTO public."Answers"
                ("Message", "QuestionId")
                VALUES('a2', (select "Id" from  public."Questions" where "Message"='q3'));
                
                INSERT INTO public."Answers"
                ("Message", "QuestionId")
                VALUES('a3', (select "Id" from  public."Questions" where "Message"='q3'));
                
                
                INSERT INTO public."Answers"
                ("Message", "QuestionId")
                VALUES('a1', (select "Id" from  public."Questions" where "Message"='q4'));
                
                INSERT INTO public."Answers"
                ("Message", "QuestionId")
                VALUES('a2', (select "Id" from  public."Questions" where "Message"='q4'));
                
                INSERT INTO public."Answers"
                ("Message", "QuestionId")
                VALUES('a3', (select "Id" from  public."Questions" where "Message"='q4'));
                
                INSERT INTO public."Answers"
                ("Message", "QuestionId")
                VALUES('a4', (select "Id" from  public."Questions" where "Message"='q4'));
                
                INSERT INTO public."Answers"
                ("Message", "QuestionId")
                VALUES('a5', (select "Id" from  public."Questions" where "Message"='q4'));
                
                INSERT INTO public."Answers"
                ("Message", "QuestionId")
                VALUES('a6', (select "Id" from  public."Questions" where "Message"='q4'));
                
                
                
                """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
