namespace QuizSystem.Data.Models
{
    using System.Collections.Generic;

    using QuizSystem.Data.Common.Models;

    public class Question : BaseDeletableModel<int>
    {
        public Question()
        {
            this.Answers = new HashSet<Answer>();
        }

        public int ExamId { get; set; }

        public Exam Exam { get; set; }

        public string Content { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }
}
