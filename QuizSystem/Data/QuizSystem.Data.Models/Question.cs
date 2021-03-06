﻿namespace QuizSystem.Data.Models
{
    using System.Collections.Generic;

    using QuizSystem.Data.Common.Models;

    public class Question : BaseDeletableModel<int>
    {
        public int ExamId { get; set; }

        public Exam Exam { get; set; }

        public string Content { get; set; }

        public string AnswerA { get; set; }

        public bool IsCorrectA { get; set; }

        public string AnswerB { get; set; }

        public bool IsCorrectB { get; set; }

        public string AnswerC { get; set; }

        public bool IsCorrectC { get; set; }


    }
}
