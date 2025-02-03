using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
namespace Task_7.Services
{
    internal class SpecialistRankService : ISpecialistRankService
    {
        private readonly string _connectionString;

        public SpecialistRankService(string connectionString){

            _connectionString = connectionString;
        }
        public async Task<IEnumerable<SpecialistRank>> GetRankAsync()
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var user_adress = await db.QueryAsync<SpecialistRank>("SELECT Id_rank, Rank, Id FROM Specialist_rank");
                return user_adress.ToList();
            }
        }
        public void AddRank(SpecialistRank specialistRank)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "INSERT INTO Specialist_rank (Rank,Id) VALUES(@Rank, @Id); SELECT SCOPE_IDENTITY()";

                int rankId = db.Query<int>(sqlQuery, specialistRank).FirstOrDefault();

                specialistRank.Id_rank = rankId;
            }
        }

        
        public void DeleteRank(int id_rank)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "DELETE FROM Specialist_rank WHERE Id_rank = @id_rank";
                db.Execute(sqlQuery, new { id_rank });
            }
        }
        public void PutRank(SpecialistRank specialistRank)
        {
            using (var db = new SqlConnection(_connectionString))
            {
                var sqlQuery = "UPDATE Specialist_rank SET Rank = @Rank, Id = @Id WHERE Id_rank = @Id_rank";
                db.Execute(sqlQuery, specialistRank);

            }
        }
    }
}
