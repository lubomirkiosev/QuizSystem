namespace QuizSystem.Web.ViewModels.Administration.Dashboard
{
    using System;
    using System.Collections.Generic;

    using QuizSystem.Data.Models;
    using QuizSystem.Services.Mapping;

    public class ExamDeleteViewModel : IMapFrom<Exam>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CountQuestion { get; set; }

        public int TimeLimit { get; set; }

        public DateTime? StartTime { get; set; }
    }
}
