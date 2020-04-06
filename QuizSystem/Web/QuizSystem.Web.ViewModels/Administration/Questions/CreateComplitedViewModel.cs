namespace QuizSystem.Web.ViewModels.Administration.Questions
{
    using QuizSystem.Data.Models;
    using QuizSystem.Services.Mapping;

    public class CreateComplitedViewModel : IMapFrom<Question>
    {
        public string Content { get; set; }

        public string AnswerA { get; set; }

        public bool IsCorrectA { get; set; }

        public string AnswerB { get; set; }

        public bool IsCorrectB { get; set; }

        public string AnswerC { get; set; }

        public bool IsCorrectC { get; set; }
    }
}
