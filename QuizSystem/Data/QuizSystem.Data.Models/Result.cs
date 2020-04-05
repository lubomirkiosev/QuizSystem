namespace QuizSystem.Data.Models
{
    using QuizSystem.Data.Common.Models;

    public class Result : BaseDeletableModel<int>
    {
        public int UserId { get; set; }

        public ApplicationUser User { get; set; }

        public int ExamId { get; set; }

        public Exam Exam { get; set; }

        public int MaxPoints { get; set; }

        public int UserPoints { get; set; }
    }
}
