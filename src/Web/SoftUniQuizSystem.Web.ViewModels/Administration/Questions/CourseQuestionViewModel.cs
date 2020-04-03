namespace SoftUniQuizSystem.Web.ViewModels.Administration.Questions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using SoftUniQuizSystem.Data.Models;
    using SoftUniQuizSystem.Services.Mapping;

    public class CourseQuestionViewModel : IMapFrom<Course>
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; }
    }
}
