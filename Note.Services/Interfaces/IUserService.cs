using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.Services.Interfaces
{
    public interface IUserService
    {
        public Task AddUser(string name, string email, string password);

    }
}
