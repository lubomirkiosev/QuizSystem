namespace SoftUniQuizSystem.Web.Areas.Administration.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    public class QuestionsController : AdministrationController
    {
        public IActionResult Create()
        {
            return this.View();
        }
    }
}