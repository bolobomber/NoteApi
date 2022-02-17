using FluentValidation;
using Note.DAL.Interface.Repositories;
using Note.DAL.Models;
using Note.Services.Interfaces;
using Note.Services.Validators;

namespace Note.Services.Services
{
    public class UserService : IUserService
    {   

        private readonly IUserRepository userRepository;
        private readonly UserValidator userValidator;

        public UserService(IUserRepository userRepository, UserValidator userValidator)
        {
            this.userRepository = userRepository;
            this.userValidator = userValidator;
        }
        public async Task AddUser(string name, string email, string password)
        {
            var user = new User()
            {
                Email = email,
                Password = password,
                Name = name
            };
            await userValidator.ValidateAndThrowAsync(user);
            await userRepository.Add(user);
        }

        public async Task DeleteUser(int id)
        { 
            await userRepository.Delete(id);
        }

        public async Task<User> GetUserById(int id)
        {
            return await userRepository.GetById(id);
        }

        public async Task UpdateUser(int id, string name, string email, string password)
        {
            var  a = await userRepository.GetAllUsers();
            var user = a.FirstOrDefault(x => x.Id == id);

            user.Name = name;
            user.Email = email;
            user.Password = password;
            await userValidator.ValidateAndThrowAsync(user);
            await userRepository.Update(user);
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await userRepository.GetAllUsers();
        }
    }
}
