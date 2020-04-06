namespace QuizSystem.Web.ViewModels.Administration.Questions
{
    using System.Collections.Generic;

    using QuizSystem.Data.Models;
    using QuizSystem.Services.Mapping;

    public class CreateQuestionModel : IMapTo<Question>
    {
        public CreateQuestionModel()
        {
            this.ExamsNames = new HashSet<ExamDropDownModel>();
        }

        public int ExamId { get; set; }

        public IEnumerable<ExamDropDownModel> ExamsNames { get; set; }

        public string Content { get; set; }

        public string AnswerA { get; set; }

        public bool IsCorrectA { get; set; }

        public string AnswerB { get; set; }

        public bool IsCorrectB { get; set; }

        public string AnswerC { get; set; }

        public bool IsCorrectC { get; set; }
    }
}
