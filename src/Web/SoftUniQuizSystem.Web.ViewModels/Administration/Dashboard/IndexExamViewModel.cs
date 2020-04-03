namespace SoftUniQuizSystem.Web.ViewModels.Administration.Dashboard
{
    using SoftUniQuizSystem.Data.Models;
    using SoftUniQuizSystem.Services.Mapping;

    public class IndexExamViewModel : IMapFrom<Exam>
    {
        public int Id { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public string Title { get; set; }

        public int NumberOfQuestions { get; set; }

        public int TimeLimit { get; set; }
    }
}
