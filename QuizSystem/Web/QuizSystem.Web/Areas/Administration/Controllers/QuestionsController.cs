namespace QuizSystem.Web.Areas.Administration.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using QuizSystem.Data.Models;
    using QuizSystem.Services.Data;
    using QuizSystem.Services.Mapping;
    using QuizSystem.Web.ViewModels.Administration.Questions;

    public class QuestionsController : AdministrationController
    {
        private readonly IExamsService examsService;
        private readonly IQuestionsService questionsService;

        public QuestionsController(IExamsService examsService, IQuestionsService questionsService)
        {
            this.examsService = examsService;
            this.questionsService = questionsService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            var exams = this.examsService.GetAll<ExamDropDownModel>();
            var viewModel = new CreateQuestionModel
            {
                ExamsNames = exams,
            };

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateQuestionModel model)
        {
            var viewModel = AutoMapperConfig.MapperInstance.Map<Question>(model);
            if (!this.ModelState.IsValid)
            {
                return this.View(viewModel);
            }

            var questionId = await this.questionsService
                .CreateAsync(model.ExamId, model.Content);

            return this.RedirectToAction("Create", "Answers", questionId);
        }
    }
}
