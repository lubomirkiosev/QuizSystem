namespace SoftUniQuizSystem.Web.ViewModels.Administration.Questions
{
    using SoftUniQuizSystem.Data.Models;
    using SoftUniQuizSystem.Services.Mapping;
    using System.Collections.Generic;

    public class CreateQuestionsViewModel : IMapTo<Question>
    {
        public string CourseName { get; set; }

        public string Content { get; set; }

        public string AnswerA { get; set; }

        public string AnswerB { get; set; }

        public string AnswerC { get; set; }

        public TrueAnswer TrueAnswer { get; set; }
    }
}
