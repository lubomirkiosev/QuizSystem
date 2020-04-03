﻿namespace SoftUniQuizSystem.Data.Models
{
    using System.Collections.Generic;

    using SoftUniQuizSystem.Data.Common.Models;

    public class Question : BaseDeletableModel<int>
    {
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public string Content { get; set; }

        public string AnswerA { get; set; }

        public string AnswerB { get; set; }

        public string AnswerC { get; set; }

        public TrueAnswer TrueAnswer { get; set; }
    }
}
