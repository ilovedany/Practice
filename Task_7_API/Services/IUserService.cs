using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_7.Services
{
    public interface IUserService
    {
        
        public Task<IEnumerable<User>> GetUsersAsync();
        public void AddUser(User user);
        public void DeleteUser(int id);
        public void PutUser(User user);
        
    }
}