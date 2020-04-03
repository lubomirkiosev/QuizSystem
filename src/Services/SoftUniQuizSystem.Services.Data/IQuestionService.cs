namespace SoftUniQuizSystem.Services.Data
{
    using System.Threading.Tasks;

    public interface IQuestionService
    {
        Task<int> CreateAsync(string content, string answerA, string answerB, string answerC, string trueAswer);
    }
}
