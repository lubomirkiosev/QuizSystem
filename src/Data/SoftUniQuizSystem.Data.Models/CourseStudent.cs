namespace SoftUniQuizSystem.Data.Models
{
    using SoftUniQuizSystem.Data.Common.Models;

    public class CourseStudent : BaseDeletableModel<int>
    {
        public string UserId { get; set; }

        public virtual ApplicationUser Student { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
