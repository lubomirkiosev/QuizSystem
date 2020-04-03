using SoftUniQuizSystem.Data.Common.Repositories;
using SoftUniQuizSystem.Data.Models;
using SoftUniQuizSystem.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftUniQuizSystem.Services.Data
{
    public class ExamService : IExamService
    {
        private readonly IDeletableEntityRepository<Exam> examRepository;

        public ExamService(IDeletableEntityRepository<Exam> examRepository)
        {
            this.examRepository = examRepository;
        }

        public async Task<int> CreateAsync(string title, int courseId, int numberOfQuestions, int timeLimit)
        {
            var exam = new Exam
            {
                Title = title,
                CourseId = courseId,
                NumberOfQuestions = numberOfQuestions,
                TimeLimit = timeLimit,
            };

            await this.examRepository.AddAsync(exam);
            await this.examRepository.SaveChangesAsync();
            return exam.Id;
        }

        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            IQueryable<Exam> query =
                this.examRepository.All().OrderByDescending(x => x.CreatedOn);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return query.To<T>().ToList();
        }

        public T GetById<T>(int id)
        {
            var exam = this.examRepository.All().Where(x => x.Id == id)
                .To<T>().FirstOrDefault();
            return exam;
        }

        public void Delete(Exam exam)
        {
            this.examRepository.Delete(exam);
        }
    }
}
