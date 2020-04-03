namespace SoftUniQuizSystem.Web.Areas.Administration.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SoftUniQuizSystem.Services.Data;
    using SoftUniQuizSystem.Web.ViewModels.Administration.Dashboard;
    using System.Collections;
    using System.Collections.Generic;

    public class DashboardController : AdministrationController
    {
        private readonly IExamService examService;

        public DashboardController(IExamService examService)
        {
            this.examService = examService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                Exams =
                    this.examService.GetAll<IndexExamViewModel>(),
            };
            return this.View(viewModel);
        }
    }
}
