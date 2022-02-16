using System;
using System.Collections.Generic;
using Note.DAL.Models;

namespace Note.DAL.Interface.Repositories
{
    public interface IUserRepository
    {
        public Task Add(User user);
        public Task Delete(int Id);
        public Task Update(User user);
        public Task<User> GetById(int Id);
        public Task<List<User>> GetAllUsers();
    }
}
