using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Note.DAL.Interface.Repositories;
using Note.DAL.Models;

namespace Note.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly NoteContext context;
        public UserRepository(NoteContext context)
        {
            this.context = context;
        }


        public async Task Add(User user)
        {
            await context.AddAsync(user);
            await context.SaveChangesAsync();
        }

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task Update(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
