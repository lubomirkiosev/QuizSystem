namespace QuizSystem.Data.Models
{
    using System;
    using System.Collections.Generic;

    using QuizSystem.Data.Common.Models;

    public class Exam : BaseDeletableModel<int>
    {
        public Exam()
        {
            this.Questions = new HashSet<Question>();
            this.Result = new HashSet<Result>();
        }

        public string Name { get; set; }

        public int CountQuestion { get; set; }

        public int TimeLimit { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? FinishTime { get; set; }

        public ICollection<Result> Result { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}
