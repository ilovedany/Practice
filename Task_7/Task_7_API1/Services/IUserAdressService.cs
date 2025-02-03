
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Task_7.Services
{
    public interface IUserAdressService
    {
        public Task<IEnumerable<UserAdress>> GetAdressAsync();
        public void AddAdress(UserAdress userAdress);
        public void DeleteAdress(int id_adress);
        public void PutAdress(UserAdress userAdress);

    }
}
