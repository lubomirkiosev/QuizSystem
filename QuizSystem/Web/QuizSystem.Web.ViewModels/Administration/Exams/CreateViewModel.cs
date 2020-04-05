namespace QuizSystem.Web.ViewModels.Administration.Exams
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using QuizSystem.Data.Models;
    using QuizSystem.Services.Mapping;

    public class CreateViewModel : IMapTo<Exam>
    {
        public string Name { get; set; }

        public int CountQuestion { get; set; }

        public int TimeLimit { get; set; }

        public DateTime? StartTime { get; set; }
    }
}
