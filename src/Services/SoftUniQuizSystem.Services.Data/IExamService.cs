namespace SoftUniQuizSystem.Services.Data
{
    using SoftUniQuizSystem.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IExamService
    {
        Task<int> CreateAsync(string title, int courseId, int numberOfQuestions, int timeLimit);

        IEnumerable<T> GetAll<T>(int? count = null);

        T GetById<T>(int id);

        void Delete(Exam exam);
    }
}
