using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
namespace Task_7.Services
{
    public class UserService : IUserService
    {

        private readonly string _connectionString;

        public UserService(string connectionString){

            _connectionString = connectionString;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var users = await db.QueryAsync<User>("SELECT Id, Name, Surname, Age, Email FROM Users");
                return users.ToList();
            }
        }
        public void AddUser(User user){
            using (var db = new SqlConnection(_connectionString)){
                var sqlQuery = "INSERT INTO Users (Name,Surname,Age,Email) VALUES(@Name, @Surname, @Age, @Email); SELECT SCOPE_IDENTITY()";

                int userId = db.Query<int>(sqlQuery,user).FirstOrDefault();

                user.Id = userId;
                
            }
        }
        public void DeleteUser(int id){
            using(var db = new SqlConnection(_connectionString)){
                var sqlQuery = "DELETE FROM Users WHERE Id = @id";
                db.Execute(sqlQuery, new { id });
            }
        }
        public void PutUser(User user){
            using(var db = new SqlConnection(_connectionString)){
                var sqlQuery = "UPDATE Users SET Name = @Name, Age = @Age WHERE Id = @Id";
                db.Execute(sqlQuery,user);
            }
        }
    }
}