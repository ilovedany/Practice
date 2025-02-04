using HttpForm.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpForm.ViewModels
{
    public class SearchRankView : ObservableCollection<SpecialistRank>
    {
        public SearchRankView()
        {
            HttpClient httpClient = new HttpClient();
     
            var users = Task.Run(() => HttpRequest.HttpRank.SearchRankAsync<SpecialistRank>(httpClient, "http://localhost:5009/searchRank", 10)).Result;

            Add(users);

        }
    }
}
