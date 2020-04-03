using System.Collections.Generic;

namespace SoftUniQuizSystem.Services.Data
{
    public interface IUsersService
    {
        IEnumerable<T> GetAll<T>();
    }
}
