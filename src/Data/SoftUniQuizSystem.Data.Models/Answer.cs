namespace SoftUniQuizSystem.Data.Models
{
    using SoftUniQuizSystem.Data.Common.Models;

    public class Answer : BaseDeletableModel<int>
    {
        public int QuestionId { get; set; }

        public virtual Question Question { get; set; }

        public string Content { get; set; }
    }
}
