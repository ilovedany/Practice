using HttpForm.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpForm.ViewModels
{
    public class GetRankView: ObservableCollection<SpecialistRank>
    {
        public GetRankView()
        {
            HttpClient httpClient = new HttpClient();
            var users = Task.Run(() => HttpRequest.HttpRank.GetRankAsync<SpecialistRank>(httpClient, "http://localhost:5009/getRank")).Result;
            foreach (var user in users)
            {
                Add(user);
            }
        }
    }
}
