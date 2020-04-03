namespace SoftUniQuizSystem.Web.ViewModels.Administration.Dashboard
{
    using SoftUniQuizSystem.Data.Models;
    using System.Collections.Generic;

    public class IndexViewModel
    {
        public IEnumerable<IndexExamViewModel> Exams { get; set; }
    }
}
