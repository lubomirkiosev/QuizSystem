using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace QuizSystem.Web.Areas.Administration.Controllers
{
    public class AnswersController : AdministrationController
    {
        public IActionResult Create(int id)
        {

            return View();
        }
    }
}