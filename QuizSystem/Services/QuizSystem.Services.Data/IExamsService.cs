namespace QuizSystem.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using QuizSystem.Data.Models;

    public interface IExamsService
    {
        IEnumerable<T> GetAll<T>(int? count = null);

        Task<int> CreateAsync(string name, int countQuestion, int timeLimit, DateTime? startTime);

        T GetById<T>(int id);

        public Task<int> Delete(int id);

        public Task DeleteConfirmed(int id);
    }
}
