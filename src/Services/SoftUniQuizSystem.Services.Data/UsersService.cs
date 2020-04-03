using SoftUniQuizSystem.Data.Common.Repositories;
using SoftUniQuizSystem.Data.Models;
using SoftUniQuizSystem.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniQuizSystem.Services.Data
{
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
