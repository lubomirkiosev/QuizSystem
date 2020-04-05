namespace QuizSystem.Web.ViewModels.Administration.Questions
{
    using QuizSystem.Data.Models;
    using QuizSystem.Services.Mapping;

    public class ExamDropDownModel : IMapFrom<Exam>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
