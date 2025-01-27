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
        string connectionString = @"Server=DESKTOP-QR21RPK;Database=Task_5;Trusted_Connection=True;";
        public List<User> GetUsers()
        {
            using (var db = new SqlConnection(connectionString))
            {
                return db.Query<User>("SELECT Id, Name, Age FROM Users").ToList();
            }

        }
        public void AddUser(User user){
            using (var db = new SqlConnection(connectionString)){
                var sqlQuery = "INSERT INTO Users (Name,Age) VALUES(@Name, @Age); SELECT SCOPE_IDENTITY()";

                int userId = db.Query<int>(sqlQuery,user).FirstOrDefault();
              
                user.Id = userId;
                
            }
        }

        public void DeleteUser(int id){
            using(var db = new SqlConnection(connectionString)){
                var sqlQuery = "DELETE FROM Users WHERE Id = @Id";
                db.Execute(sqlQuery,new { id });

            }
        }

        public void PutUser(User user){
            using(var db = new SqlConnection(connectionString)){
                var sqlQuery = "UPDATE Users SET Name = @Name, Age = @Age WHERE Id = @Id";
                db.Execute(sqlQuery,user);

            }
        }
    }
}