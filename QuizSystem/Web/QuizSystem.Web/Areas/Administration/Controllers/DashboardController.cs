namespace QuizSystem.Web.Areas.Administration.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using QuizSystem.Services.Data;
    using QuizSystem.Web.ViewModels.Administration.Dashboard;

    public class DashboardController : AdministrationController
    {
        private readonly IExamsService examsService;

        public DashboardController(IExamsService examsService)
        {
            this.examsService = examsService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                Exams =
                    this.examsService.GetAll<AdminExamIndexViewModel>(),
            };

            return this.View(viewModel);
        }
    }
}
