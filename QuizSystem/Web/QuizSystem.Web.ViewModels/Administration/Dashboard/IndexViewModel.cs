namespace QuizSystem.Web.ViewModels.Administration.Dashboard
{
    using System.Collections.Generic;

    public class IndexViewModel
    {
       public IEnumerable<AdminExamIndexViewModel> Exams { get; set; }
    }
}
