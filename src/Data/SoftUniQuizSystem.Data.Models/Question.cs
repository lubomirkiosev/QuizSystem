namespace SoftUniQuizSystem.Data.Models
{
    using System.Collections.Generic;

    using SoftUniQuizSystem.Data.Common.Models;

    public class Question : BaseDeletableModel<int>
    {
        public Question()
        {
            this.Answers = new HashSet<Answer>();
        }

        public string Content { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }
}
