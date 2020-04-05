namespace QuizSystem.Web.ViewModels.Administration.Users
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using QuizSystem.Data.Models;
    using QuizSystem.Services.Mapping;

    public class AdminUserViewModel : IMapFrom<ApplicationUser>
    {
        public string Id { get; set; }

        public virtual string Email { get; set; }

        public virtual string UserName { get; set; }
    }
}
