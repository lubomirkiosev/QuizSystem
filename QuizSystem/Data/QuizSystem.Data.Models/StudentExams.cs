namespace QuizSystem.Data.Models
{
    using QuizSystem.Data.Common.Models;

    public class StudentExams : BaseDeletableModel<int>
    {
        public string ApplicationUserId { get; set; }

        public ApplicationUser User { get; set; }

        public int ExamId { get; set; }

        public Exam Exam { get; set; }
    }
}
