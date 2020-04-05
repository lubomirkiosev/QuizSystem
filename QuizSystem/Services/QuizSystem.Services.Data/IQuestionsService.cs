namespace QuizSystem.Services.Data
{
    using System.Threading.Tasks;

    public interface IQuestionsService
    {
        Task<int> CreateAsync(int examId, string content);
    }
}
