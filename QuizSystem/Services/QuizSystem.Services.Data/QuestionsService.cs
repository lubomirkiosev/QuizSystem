using QuizSystem.Data.Common.Repositories;
using QuizSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuizSystem.Services.Data
{
    public class QuestionsService : IQuestionsService
    {
        private readonly IDeletableEntityRepository<Question> questionsRepository;

        public QuestionsService(IDeletableEntityRepository<Question> questionsRepository)
        {
            this.questionsRepository = questionsRepository;
        }

        public async Task<int> CreateAsync(int examId, string content)
        {
            var question = new Question
            {
                ExamId = examId,
                Content = content,
            };
            await this.questionsRepository.AddAsync(question);
            await this.questionsRepository.SaveChangesAsync();
            return question.Id;
        }
    }
}
