using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
namespace Task_7.Services
{
    internal class UserAdressService : IUserAdressService
    {
        private readonly string _connectionString;

        public UserAdressService(string connectionString){

            _connectionString = connectionString;
        }
        public async Task<IEnumerable<UserAdress>> GetAdressAsync()
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var user_adress = await db.QueryAsync<UserAdress>("SELECT Adresses_Id, City, Adress FROM Adresses");
                return user_adress.ToList();
            }
        }
        public void AddAdress(UserAdress userAdress)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "INSERT INTO Adresses (City,Adress) VALUES(@City, @Adress); SELECT SCOPE_IDENTITY()";

                int userId = db.Query<int>(sqlQuery, userAdress).FirstOrDefault();

                userAdress.Adresses_Id = userId;
            }
        }
        public void DeleteAdress(int id_adress)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "DELETE FROM Adresses WHERE Adresses_Id = @id_adress";
                db.Execute(sqlQuery, new { id_adress });
            }
        }
        public void PutAdress(UserAdress userAdress)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "UPDATE Adresses SET City = @City, Adress = @Adress WHERE Adresses_Id = @Adresses_Id";
                db.Execute(sqlQuery, userAdress);

            }
        }
    }
}
