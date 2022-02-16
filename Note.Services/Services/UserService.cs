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
            this.userValidator=userValidator;
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
    }
}
