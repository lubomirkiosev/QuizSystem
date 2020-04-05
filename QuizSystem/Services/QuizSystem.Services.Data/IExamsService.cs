namespace QuizSystem.Services.Data
{
    using System.Collections.Generic;

    public interface IExamsService
    {
        IEnumerable<T> GetAll<T>(int? count = null);
    }
}
