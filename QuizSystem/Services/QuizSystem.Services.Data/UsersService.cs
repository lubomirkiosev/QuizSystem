namespace QuizSystem.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using QuizSystem.Data.Common.Repositories;
    using QuizSystem.Data.Models;
    using QuizSystem.Services.Mapping;

    public class UsersService : IUsersService
    {
        private readonly IDeletableEntityRepository<ApplicationUser> userRepository;

        public UsersService(IDeletableEntityRepository<ApplicationUser> userRepository)
        {
            this.userRepository = userRepository;
        }

        public IEnumerable<T> GetAll<T>()
        {
            IQueryable<ApplicationUser> query =
               this.userRepository.All().OrderByDescending(x => x.CreatedOn);

            return query.To<T>().ToList();
        }
    }
}
