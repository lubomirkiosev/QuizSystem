using QuizSystem.Data.Common.Repositories;
using QuizSystem.Data.Models;
using QuizSystem.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<int> CreateAsync(int examId, string content, string answerA, bool correctA, string answerB, bool correctB, string answerC, bool correctC)
        {
            var question = new Question
            {
                ExamId = examId,
                Content = content,
                AnswerA = answerA,
                IsCorrectA = correctA,
                AnswerB = answerB,
                IsCorrectB = correctB,
                AnswerC = answerC,
                IsCorrectC = correctC,
            };
            await this.questionsRepository.AddAsync(question);
            await this.questionsRepository.SaveChangesAsync();
            return question.Id;
        }

        public T GetById<T>(int id)
        {
            var question = this.questionsRepository.All().Where(x => x.Id == id)
                .To<T>().FirstOrDefault();
            return question;
        }
    }
}
