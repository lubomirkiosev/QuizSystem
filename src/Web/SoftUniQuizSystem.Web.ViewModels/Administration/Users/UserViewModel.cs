namespace SoftUniQuizSystem.Web.ViewModels.Administration.Users
{
    using SoftUniQuizSystem.Data.Models;
    using SoftUniQuizSystem.Services.Mapping;

    public class UserViewModel : IMapFrom<ApplicationUser>
    {
        public string Id { get; set; }

        public virtual string Email { get; set; }

        public virtual string UserName { get; set; }
    }
}