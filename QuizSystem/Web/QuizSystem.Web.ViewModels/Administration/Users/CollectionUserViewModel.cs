namespace QuizSystem.Web.ViewModels.Administration.Users
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CollectionUserViewModel
    {
        public IEnumerable<AdminUserViewModel> Users { get; set; }
    }
}
