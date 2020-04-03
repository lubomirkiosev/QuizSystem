using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoftUniQuizSystem.Services.Data;
using SoftUniQuizSystem.Web.ViewModels.Administration.Users;

namespace SoftUniQuizSystem.Web.Areas.Administration.Controllers
{
    public class UsersController : AdministrationController
    {
        private readonly IUsersService userService;

        public UsersController(IUsersService userService)
        {
            this.userService = userService;
        }

        public IActionResult All()
        {
            var viewModel = new CollectionUsersViewModel
            {
                Users =
                    this.userService.GetAll<UserViewModel>(),
            };
            return this.View(viewModel);
        }
    }
}