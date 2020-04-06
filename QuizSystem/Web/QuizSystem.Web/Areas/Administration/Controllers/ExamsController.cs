namespace QuizSystem.Web.Areas.Administration.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using QuizSystem.Data.Models;
    using QuizSystem.Services.Data;
    using QuizSystem.Services.Mapping;
    using QuizSystem.Web.ViewModels.Administration.Dashboard;
    using QuizSystem.Web.ViewModels.Administration.Exams;

    public class ExamsController : AdministrationController
    {
        private readonly IExamsService examService;

        public ExamsController(IExamsService examService)
        {
            this.examService = examService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateViewModel input)
        {
            var exam = AutoMapperConfig.MapperInstance.Map<Exam>(input);
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            var examId = await this.examService.CreateAsync(input.Name, input.CountQuestion, input.TimeLimit, input.StartTime);
            this.TempData["Message"] = $"You added Exam with name {input.Name}";
            return this.RedirectToAction("Index", "Dashboard");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var exam = this.examService.GetById<ExamDeleteViewModel>(id);

            if (exam == null)
            {
                return this.NotFound();
            }

            return this.View(exam);
        }

        public IActionResult DeleteConfirmed(int id)
        {
            this.examService.DeleteConfirmed(id);
            return this.RedirectToAction("Index", "Dashboard");
        }
    }
}
