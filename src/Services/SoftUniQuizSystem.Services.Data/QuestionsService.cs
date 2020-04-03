using SoftUniQuizSystem.Data.Common.Repositories;
using SoftUniQuizSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniQuizSystem.Services.Data
{
    public class QuestionsService : IQuestionService
    {
        private readonly IDeletableEntityRepository<Question> questionRepository;

        public QuestionsService(IDeletableEntityRepository<Question> questionRepository)
        {
            this.questionRepository = questionRepository;
        }

        public async Task<int> CreateAsync(string content, string answerA, string answerB, string answerC, string trueAswer)
        {
            TrueAnswer result;

            if (Enum.TryParse<TrueAnswer>(trueAswer, out result))
            {
                var question = new Question
                {
                    Content = content,
                    AnswerA = answerA,
                    AnswerB = answerB,
                    AnswerC = answerC,
                    TrueAnswer = result,
                };
                await this.questionRepository.AddAsync(question);
                await this.questionRepository.SaveChangesAsync();
                return question.Id;
            }
            else
            {
                throw new Exception("Invalid True Answer!");
            }
        }
    }
}
