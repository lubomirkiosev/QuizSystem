﻿namespace QuizSystem.Web.ViewModels.Administration.Dashboard
{
    using System;

    using QuizSystem.Data.Models;
    using QuizSystem.Services.Mapping;

    public class AdminExamIndexViewModel : IMapFrom<Exam>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CountQuestion { get; set; }

        public int TimeLimit { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? FinishTime { get; set; }
    }
}
