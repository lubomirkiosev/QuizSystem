namespace QuizSystem.Services.Data
{
    using System.Threading.Tasks;

    public interface IQuestionsService
    {
        Task<int> CreateAsync(int examId, string content, string answerA, bool correctA, string answerB, bool correctB, string answerC, bool correctC);

        T GetById<T>(int id);
    }
}
