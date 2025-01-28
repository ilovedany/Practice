using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
namespace Test1.Services
{
    public class ProductService : IProductService
    {
        

        private readonly string _connectionString;

        public ProductService(string connectionString){

            _connectionString = connectionString;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var users = await db.QueryAsync<User>("SELECT Id, Name, Age FROM Users");
                return users.ToList();
            }
        }
        public void AddUser(User user){
            using (var db = new SqlConnection(_connectionString)){
                var sqlQuery = "INSERT INTO Users (Name,Age) VALUES(@Name, @Age); SELECT SCOPE_IDENTITY()";

                int userId = db.Query<int>(sqlQuery,user).FirstOrDefault();
              
                user.Id = userId;
                
            }
        }

        public void DeleteUser(int id){
            using(var db = new SqlConnection(_connectionString)){
                var sqlQuery = "DELETE FROM Users WHERE Id = @Id";
                db.Execute(sqlQuery,new { id });
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