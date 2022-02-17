using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public async Task Delete(int id)
        {
            context.Remove(await context.Users.FirstOrDefaultAsync(x => x.Id == id));
            await context.SaveChangesAsync();
        }

        public async Task Update(User user)
        {
            context.Update(user);
            await context.SaveChangesAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await context.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await context.Users.ToListAsync();
        }
    }
}
