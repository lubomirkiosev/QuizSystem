namespace QuizSystem.Web.Areas.Administration.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using QuizSystem.Services.Data;
    using QuizSystem.Web.ViewModels.Administration.Users;

    public class UsersController : AdministrationController
    {
        private readonly IUsersService userService;

        public UsersController(IUsersService userService)
        {
            this.userService = userService;
        }

        public IActionResult All()
        {
            var viewModel = new CollectionUserViewModel
            {
                Users =
                    this.userService.GetAll<AdminUserViewModel>(),
            };
            return this.View(viewModel);
        }
    }
}
