namespace QuizSystem.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IExamsService
    {
        IEnumerable<T> GetAll<T>(int? count = null);

        Task<int> CreateAsync(string name, int countQuestion, int timeLimit, DateTime? startTime);
    }
}
