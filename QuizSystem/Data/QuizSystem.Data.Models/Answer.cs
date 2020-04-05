namespace QuizSystem.Data.Models
{
    using QuizSystem.Data.Common.Models;

    public class Answer : BaseDeletableModel<int>
    {
        public int QuestionId { get; set; }

        public Question Question { get; set; }

        public string Text { get; set; }

        public bool IsCorrect { get; set; }
    }
}
