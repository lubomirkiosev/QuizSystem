namespace SoftUniQuizSystem.Web.Areas.Administration.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SoftUniQuizSystem.Data.Models;
    using SoftUniQuizSystem.Services.Data;
    using SoftUniQuizSystem.Services.Mapping;
    using SoftUniQuizSystem.Web.ViewModels.Administration.Dashboard;

    public class ExamController : AdministrationController
    {
        private readonly IExamService examService;

        public ExamController(IExamService examService)
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
        public async Task<IActionResult> Create(ExamCreateModel input)
        {
            var exam = AutoMapperConfig.MapperInstance.Map<Exam>(input);
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            var examId = await this.examService.CreateAsync(input.Title, input.CourseId, input.NumberOfQuestions, input.TimeLimit);
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

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var exam = this.examService.GetById<Exam>(id);
            this.examService.Delete(exam);
            return this.RedirectToAction("Index", "Dashboard");
        }
    }
}
