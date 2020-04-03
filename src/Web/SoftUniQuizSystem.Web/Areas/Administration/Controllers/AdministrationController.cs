namespace SoftUniQuizSystem.Web.Areas.Administration.Controllers
{
    using SoftUniQuizSystem.Common;
    using SoftUniQuizSystem.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
