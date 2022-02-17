using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Note.DAL.Models;

namespace Note.Services.Interfaces
{
    public interface IUserService
    {
        public Task AddUser(string name, string email, string password);
        public Task DeleteUser(int id);
        public Task<User> GetUserById(int id);
        public Task UpdateUser(int id, string name, string email, string password);
        public Task<List<User>> GetAllUsers();

    }
}
