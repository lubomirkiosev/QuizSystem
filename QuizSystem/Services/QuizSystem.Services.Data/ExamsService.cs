namespace QuizSystem.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using QuizSystem.Data.Common.Repositories;
    using QuizSystem.Data.Models;
    using QuizSystem.Services.Mapping;

    public class ExamsService : IExamsService
    {
        private readonly IDeletableEntityRepository<Exam> examRepository;

        public ExamsService(IDeletableEntityRepository<Exam> examRepository)
        {
            this.examRepository = examRepository;
        }

        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            IQueryable<Exam> query =
                this.examRepository.All()
                .OrderByDescending(x => x.CreatedOn);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }

            return query.To<T>().ToList();
        }

        public async Task<int> CreateAsync(string name, int questionCount, int timeLimit, DateTime? startTime)
        {
            var exam = new Exam
            {
                Name = name,
                CountQuestion = questionCount,
                TimeLimit = timeLimit,
                StartTime = startTime,
            };

            await this.examRepository.AddAsync(exam);
            await this.examRepository.SaveChangesAsync();
            return exam.Id;
        }

        public T GetById<T>(int id)
        {
            var exam = this.examRepository.All().Where(x => x.Id == id)
                .To<T>().FirstOrDefault();
            return exam;
        }

        public async Task<int> Delete(int id)
        {
            var exam = this.examRepository.All().Where(x => x.Id == id)
                .To<Exam>().FirstOrDefault();

            return exam.Id;
        }

        public async Task DeleteConfirmed(int id)
        {
            var exam = this.examRepository.All().Where(x => x.Id == id).FirstOrDefault();
            this.examRepository.Delete(exam);

            this.examRepository.Delete(exam);
            await this.examRepository.SaveChangesAsync();
        }
    }
}
