namespace SoftUniQuizSystem.Data.Models
{
    using System;
    using System.Collections.Generic;

    using SoftUniQuizSystem.Data.Common.Models;

    public class Course : BaseDeletableModel<int>
    {
        public Course()
        {
            this.Questions = new HashSet<Question>();
            this.Students = new HashSet<CourseStudent>();
        }

        public string Name { get; set; }

        public ICollection<Question> Questions { get; set; }

        public ICollection<CourseStudent> Students { get; set; }
    }
}
