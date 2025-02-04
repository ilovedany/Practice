
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Task_7.Services
{
    public interface ISpecialistRankService
    {
        public Task<IEnumerable<SpecialistRank>> GetRankAsync();
        public void AddRank(SpecialistRank specialistRank);
        public void DeleteRank(int id_rank);
        public void PutRank(SpecialistRank specialistRank);
        public SpecialistRank GetRankToIDAsync(int id_rank);

    }
}
