﻿namespace QuizSystem.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IUsersService
    {
        IEnumerable<T> GetAll<T>();
    }
}
