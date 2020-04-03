namespace SoftUniQuizSystem.Web.ViewModels.Administration.Dashboard
{
    using System;
    using System.Collections.Generic;

    using SoftUniQuizSystem.Data.Models;
    using SoftUniQuizSystem.Services.Mapping;

    public class ExamDeleteViewModel : IMapFrom<Exam>
    {
        public int Id { get; set; }

        public int CourseId { get; set; }

        public string Title { get; set; }

        public int NumberOfQuestions { get; set; }

        public int TimeLimit { get; set; }
    }
}
