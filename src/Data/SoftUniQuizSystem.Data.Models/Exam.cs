namespace SoftUniQuizSystem.Data.Models
{
    using System;
    using System.Collections.Generic;

    using SoftUniQuizSystem.Data.Common.Models;

    public class Exam : BaseDeletableModel<int>
    {
        public Exam()
        {
            this.Questions = new HashSet<Question>();
        }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public string Title { get; set; }

        public int NumberOfQuestions { get; set; }

        public ICollection<Question> Questions { get; set; }

        public int TimeLimit { get; set; }
    }
}
